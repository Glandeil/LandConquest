﻿using LandConquest.DialogWIndows;
using LandConquest.Entities;
using LandConquest.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace LandConquest.Forms
{
    public partial class MainWindow : Window
    {

        public SqlConnection connection;
        User user;
        Player player;

        PlayerModel playerModel;
        UserModel userModel;
        TaxesModel taxesModel;
        LandModel landModel;
        CountryModel countryModel;
        PeasantModel peasantModel;
        StorageModel storageModel;
        EquipmentModel equipmentModel;
        MarketModel marketModel;
        MapModel mapModel;
        WarModel warModel;
        ArmyModel armyModel;
        BattleModel battleModel;

        Market market;
        PlayerStorage storage;
        PlayerEquipment equipment = new PlayerEquipment();
        Taxes taxes;
        Peasants peasants;
        ManufactureModel manufactureModel;
        List<Land> lands;
        List<Path> paths;
        List<Country> countries;
        List<War> wars;
        Land land;
        Country country;

        Thickness[] marginsOfWarButtons;
        int[] flagXY = new int[4];

        const int landsCount = 11;

        public MainWindow(SqlConnection _connection, User _user)
        {
            InitializeComponent();
            //this.Resources.Add("buttonGradientBrush", gradientBrush);
            user = _user;
            connection = _connection;

            player = new Player();
            storage = new PlayerStorage();
            peasants = new Peasants();
            country = new Country();
            market = new Market();

            marketModel = new MarketModel();
            userModel = new UserModel();
            taxesModel = new TaxesModel();
            landModel = new LandModel();
            countryModel = new CountryModel();
            peasantModel = new PeasantModel();
            manufactureModel = new ManufactureModel();
            playerModel = new PlayerModel();
            storageModel = new StorageModel();
            equipmentModel = new EquipmentModel();
            mapModel = new MapModel();
            warModel = new WarModel();
            //equipment = new PlayerEquipment();

            player = playerModel.GetPlayerInfo(_user, connection, player);
            PbExp.Maximum = Math.Pow(player.PlayerLvl, 2) * 500;
            PbExp.Value = player.PlayerExp;
            Level.Content = player.PlayerLvl;
            Console.WriteLine(player.PlayerExp);

            if (player.PlayerId == user.UserId)
            {
                labelName.Content = player.PlayerName;
                labelMoney.Content = player.PlayerMoney;
                labelDonation.Content = player.PlayerDonation;
            }

            taxes = new Taxes();
            taxes.PlayerId = player.PlayerId;

            Loaded += MainWindow_Loaded;
            connection = _connection;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            storage = storageModel.GetPlayerStorage(player, connection, storage);

            peasants = peasantModel.GetPeasantsInfo(player, connection, peasants);
            sliderTaxes.IsSnapToTickEnabled = true;

            taxes = taxesModel.GetTaxesInfo(taxes, connection);
            sliderTaxes.Value = taxes.TaxValue;

            List<Manufacture> manufactures = manufactureModel.GetManufactureInfo(player, connection);

            prodRatioValue.Content = (1 + (1 - Convert.ToDouble(taxes.TaxValue) / 5)).ToString();

            //storage.PlayerWood += Convert.ToInt32((DateTime.UtcNow.Subtract(manufactures[0].ManufactureProdStartTime).TotalSeconds / 3600) * manufactures[0].ManufactureProductsHour * (1 + (1 - Convert.ToDouble(taxes.TaxValue) / 5)));
            //storage.PlayerStone += Convert.ToInt32((DateTime.UtcNow.Subtract(manufactures[1].ManufactureProdStartTime).TotalSeconds / 3600) * manufactures[1].ManufactureProductsHour * (1 + (1 - Convert.ToDouble(taxes.TaxValue) / 5)));
            //storage.PlayerFood += Convert.ToInt32((DateTime.UtcNow.Subtract(manufactures[2].ManufactureProdStartTime).TotalSeconds / 3600) * manufactures[2].ManufactureProductsHour * (1 + (1 - Convert.ToDouble(taxes.TaxValue) / 5)));
            player.PlayerMoney += Convert.ToInt32((DateTime.UtcNow.Subtract(taxes.TaxSaveDateTime).TotalSeconds / 3600) * taxes.TaxMoneyHour);

            player = playerModel.UpdatePlayerMoney(player, connection);
            taxesModel.SaveTaxes(connection, taxes);
            labelMoney.Content = player.PlayerMoney;


            Thread myThread = new Thread(new ThreadStart(UpdateInfo));

            myThread.Start(); // запускаем поток

            lands = new List<Land>();
            paths = new List<Path>();

            for (int i = 0; i < landsCount; i++)
            {
                lands.Add(new Land());
            }

            countries = new List<Country>();

            for (int i = 0; i < countryModel.SelectLastIdOfStates(connection); i++)
            {
                countries.Add(new Country());
            }

            lands = landModel.GetLandsInfo(lands, connection);
            countries = countryModel.GetCountriesInfo(countries, connection);


            wars = new List<War>();

            for (int i = 0; i < warModel.SelectLastIdOfWars(connection); i++)
            {
                wars.Add(new War());
            }

            wars = warModel.GetWarsInfo(wars, connection);

            LoadWarsOnMap();
        }

        private void UpdateInfo()
        {
            while (true)
            {
                Thread.Sleep(10000);
                taxes = taxesModel.GetTaxesInfo(taxes, connection);
                //await MainWindow_Loaded(this.sender, RoutedEventArgs e); 
                player.PlayerMoney += Convert.ToInt32((DateTime.UtcNow.Subtract(taxes.TaxSaveDateTime).TotalSeconds / 3600) * taxes.TaxMoneyHour);

                player = playerModel.UpdatePlayerMoney(player, connection);
                taxesModel.SaveTaxes(connection, taxes);
                Dispatcher.BeginInvoke(new ThreadStart(delegate { labelMoney.Content = player.PlayerMoney; }));
                lands = landModel.GetLandsInfo(lands, connection);
                Dispatcher.BeginInvoke(new ThreadStart(delegate { RedrawGlobalMap(); }));
                //labelMoney.Content = player.PlayerMoney; 
            }
        }

        private void ImageStorage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            storage = storageModel.GetPlayerStorage(player, connection, storage);
            List<Manufacture> manufactures = manufactureModel.GetManufactureInfo(player, connection);
            List<Manufacture> playerLandManufactures = manufactureModel.GetPlayerLandManufactureInfo(player, connection);
            //base manufactures 
            storage.PlayerWood += Convert.ToInt32((DateTime.UtcNow.Subtract(manufactures[0].ManufactureProdStartTime).TotalSeconds / 3600) * manufactures[0].ManufactureProductsHour * (1 + (1 - Convert.ToDouble(taxes.TaxValue) / 5)));
            player.PlayerExp += Convert.ToInt32((DateTime.UtcNow.Subtract(manufactures[0].ManufactureProdStartTime).TotalSeconds / 3600) * manufactures[0].ManufactureProductsHour * (1 + (1 - Convert.ToDouble(taxes.TaxValue) / 5)));
            player = CheckLvlChange(player);

            storage.PlayerStone += Convert.ToInt32((DateTime.UtcNow.Subtract(manufactures[1].ManufactureProdStartTime).TotalSeconds / 3600) * manufactures[1].ManufactureProductsHour * (1 + (1 - Convert.ToDouble(taxes.TaxValue) / 5)));
            player.PlayerExp += Convert.ToInt32((DateTime.UtcNow.Subtract(manufactures[1].ManufactureProdStartTime).TotalSeconds / 3600) * manufactures[1].ManufactureProductsHour * (1 + (1 - Convert.ToDouble(taxes.TaxValue) / 5)));
            player = CheckLvlChange(player);

            storage.PlayerFood += Convert.ToInt32((DateTime.UtcNow.Subtract(manufactures[2].ManufactureProdStartTime).TotalSeconds / 3600) * manufactures[2].ManufactureProductsHour * (1 + (1 - Convert.ToDouble(taxes.TaxValue) / 5)));
            player.PlayerExp += Convert.ToInt32((DateTime.UtcNow.Subtract(manufactures[2].ManufactureProdStartTime).TotalSeconds / 3600) * manufactures[2].ManufactureProductsHour * (1 + (1 - Convert.ToDouble(taxes.TaxValue) / 5)));
            player = CheckLvlChange(player);
            //land manufactures

            //first land manufacture
            bool f = true;

            if (playerLandManufactures.Count == 0)
            {
                f = false;
                playerLandManufactures.Add(new Manufacture());
                playerLandManufactures.Add(new Manufacture());
                playerLandManufactures[0].ManufactureProdStartTime = DateTime.UtcNow;
                playerLandManufactures[0].ManufactureProductsHour = 0;

                playerLandManufactures[1].ManufactureProdStartTime = DateTime.UtcNow;
                playerLandManufactures[1].ManufactureProductsHour = 0;
            }

            switch (playerLandManufactures[0].ManufactureType)
            {
                case 4:
                    {
                        storage.PlayerIron += Convert.ToInt32((DateTime.UtcNow.Subtract(playerLandManufactures[0].ManufactureProdStartTime).TotalSeconds / 3600) * playerLandManufactures[0].ManufactureProductsHour * (1 + (1 - Convert.ToDouble(taxes.TaxValue) / 5)));
                        player.PlayerExp += Convert.ToInt32((DateTime.UtcNow.Subtract(playerLandManufactures[0].ManufactureProdStartTime).TotalSeconds / 3600) * playerLandManufactures[0].ManufactureProductsHour * (1 + (1 - Convert.ToDouble(taxes.TaxValue) / 5)));
                        player = CheckLvlChange(player);
                        break;
                    }
                case 5:
                    {
                        storage.PlayerGoldOre += Convert.ToInt32((DateTime.UtcNow.Subtract(playerLandManufactures[0].ManufactureProdStartTime).TotalSeconds / 3600) * playerLandManufactures[0].ManufactureProductsHour * (1 + (1 - Convert.ToDouble(taxes.TaxValue) / 5)));
                        player.PlayerExp += Convert.ToInt32((DateTime.UtcNow.Subtract(playerLandManufactures[0].ManufactureProdStartTime).TotalSeconds / 3600) * playerLandManufactures[0].ManufactureProductsHour * (1 + (1 - Convert.ToDouble(taxes.TaxValue) / 5)));
                        player = CheckLvlChange(player);
                        break;
                    }
                case 6:
                    {
                        storage.PlayerCopper += Convert.ToInt32((DateTime.UtcNow.Subtract(playerLandManufactures[0].ManufactureProdStartTime).TotalSeconds / 3600) * playerLandManufactures[0].ManufactureProductsHour * (1 + (1 - Convert.ToDouble(taxes.TaxValue) / 5)));
                        player.PlayerExp += Convert.ToInt32((DateTime.UtcNow.Subtract(playerLandManufactures[0].ManufactureProdStartTime).TotalSeconds / 3600) * playerLandManufactures[0].ManufactureProductsHour * (1 + (1 - Convert.ToDouble(taxes.TaxValue) / 5)));
                        player = CheckLvlChange(player);
                        break;
                    }
                case 7:
                    {
                        storage.PlayerGems += Convert.ToInt32((DateTime.UtcNow.Subtract(playerLandManufactures[0].ManufactureProdStartTime).TotalSeconds / 3600) * playerLandManufactures[0].ManufactureProductsHour * (1 + (1 - Convert.ToDouble(taxes.TaxValue) / 5)));
                        player.PlayerExp += Convert.ToInt32((DateTime.UtcNow.Subtract(playerLandManufactures[0].ManufactureProdStartTime).TotalSeconds / 3600) * playerLandManufactures[0].ManufactureProductsHour * (1 + (1 - Convert.ToDouble(taxes.TaxValue) / 5)));
                        player = CheckLvlChange(player);
                        break;
                    }
                case 8:
                    {
                        storage.PlayerLeather += Convert.ToInt32((DateTime.UtcNow.Subtract(playerLandManufactures[0].ManufactureProdStartTime).TotalSeconds / 3600) * playerLandManufactures[0].ManufactureProductsHour * (1 + (1 - Convert.ToDouble(taxes.TaxValue) / 5)));
                        player.PlayerExp += Convert.ToInt32((DateTime.UtcNow.Subtract(playerLandManufactures[0].ManufactureProdStartTime).TotalSeconds / 3600) * playerLandManufactures[0].ManufactureProductsHour * (1 + (1 - Convert.ToDouble(taxes.TaxValue) / 5)));
                        player = CheckLvlChange(player);
                        break;
                    }
            }
            //second land manufacture
            switch (playerLandManufactures[1].ManufactureType)
            {
                case 4:
                    {
                        storage.PlayerIron += Convert.ToInt32((DateTime.UtcNow.Subtract(playerLandManufactures[1].ManufactureProdStartTime).TotalSeconds / 3600) * playerLandManufactures[1].ManufactureProductsHour * (1 + (1 - Convert.ToDouble(taxes.TaxValue) / 5)));
                        player.PlayerExp += Convert.ToInt32((DateTime.UtcNow.Subtract(playerLandManufactures[1].ManufactureProdStartTime).TotalSeconds / 3600) * playerLandManufactures[1].ManufactureProductsHour * (1 + (1 - Convert.ToDouble(taxes.TaxValue) / 5)));
                        player = CheckLvlChange(player);
                        break;
                    }
                case 5:
                    {
                        storage.PlayerGoldOre += Convert.ToInt32((DateTime.UtcNow.Subtract(playerLandManufactures[1].ManufactureProdStartTime).TotalSeconds / 3600) * playerLandManufactures[1].ManufactureProductsHour * (1 + (1 - Convert.ToDouble(taxes.TaxValue) / 5)));
                        player.PlayerExp += Convert.ToInt32((DateTime.UtcNow.Subtract(playerLandManufactures[1].ManufactureProdStartTime).TotalSeconds / 3600) * playerLandManufactures[1].ManufactureProductsHour * (1 + (1 - Convert.ToDouble(taxes.TaxValue) / 5)));
                        player = CheckLvlChange(player);
                        break;
                    }
                case 6:
                    {
                        storage.PlayerCopper += Convert.ToInt32((DateTime.UtcNow.Subtract(playerLandManufactures[1].ManufactureProdStartTime).TotalSeconds / 3600) * playerLandManufactures[1].ManufactureProductsHour * (1 + (1 - Convert.ToDouble(taxes.TaxValue) / 5)));
                        player.PlayerExp += Convert.ToInt32((DateTime.UtcNow.Subtract(playerLandManufactures[1].ManufactureProdStartTime).TotalSeconds / 3600) * playerLandManufactures[1].ManufactureProductsHour * (1 + (1 - Convert.ToDouble(taxes.TaxValue) / 5)));
                        player = CheckLvlChange(player);
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("suda!!!!");
                        storage.PlayerGems += Convert.ToInt32((DateTime.UtcNow.Subtract(playerLandManufactures[1].ManufactureProdStartTime).TotalSeconds / 3600) * playerLandManufactures[1].ManufactureProductsHour * (1 + (1 - Convert.ToDouble(taxes.TaxValue) / 5)));
                        player.PlayerExp += Convert.ToInt32((DateTime.UtcNow.Subtract(playerLandManufactures[1].ManufactureProdStartTime).TotalSeconds / 3600) * playerLandManufactures[1].ManufactureProductsHour * (1 + (1 - Convert.ToDouble(taxes.TaxValue) / 5)));
                        player = CheckLvlChange(player);
                        break;
                    }
                case 8:
                    {
                        storage.PlayerLeather += Convert.ToInt32((DateTime.UtcNow.Subtract(playerLandManufactures[1].ManufactureProdStartTime).TotalSeconds / 3600) * playerLandManufactures[1].ManufactureProductsHour * (1 + (1 - Convert.ToDouble(taxes.TaxValue) / 5)));
                        player.PlayerExp += Convert.ToInt32((DateTime.UtcNow.Subtract(playerLandManufactures[1].ManufactureProdStartTime).TotalSeconds / 3600) * playerLandManufactures[1].ManufactureProductsHour * (1 + (1 - Convert.ToDouble(taxes.TaxValue) / 5)));
                        player = CheckLvlChange(player);
                        break;
                    }
            }

            //EXP and PB + Update Storage
            PbExp.Maximum = Math.Pow(player.PlayerLvl, 2) * 500;
            PbExp.Value = player.PlayerExp;

            Console.WriteLine(Convert.ToInt32((DateTime.UtcNow.Subtract(playerLandManufactures[1].ManufactureProdStartTime).TotalSeconds / 3600) * playerLandManufactures[1].ManufactureProductsHour * (1 + (1 - Convert.ToDouble(taxes.TaxValue) / 5))) + " tut");

            storageModel.UpdateStorage(connection, player, storage);

            manufactureModel.UpdateDateTimeForManufacture(manufactures, player, connection);
            if (f) manufactureModel.UpdateDateTimeForPlayerLandManufacture(playerLandManufactures, player, connection);


            StorageWindow storageWindow = new StorageWindow(this, connection, player, user);

            playerModel.UpdatePlayerExpAndLvl(player, connection);
            storageWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            storageWindow.Owner = this;
            storageWindow.Show();
        }

        private void ImageManufacture_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ManufactureWindow window = new ManufactureWindow(this, connection, player, storage);
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Owner = this;
            window.Show();
        }

        private void buttonCloseWindow_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
            Environment.Exit(0);

        }

        private void reload_button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow(connection, user);
            window.Show();
            this.Close();
        }


        private void SaveTaxes_Click(object sender, RoutedEventArgs e)
        {
            taxes.TaxValue = Convert.ToInt32(sliderTaxes.Value);
            taxes.TaxMoneyHour = taxes.TaxValue * peasants.PeasantsCount;
            taxesModel.SaveTaxes(connection, taxes);
        }

        private void sliderTaxes_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            prodRatioValue.Content = (1 + (1 - Convert.ToDouble(sliderTaxes.Value) / 5)).ToString();
        }

        private void recruitImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            storage = storageModel.GetPlayerStorage(player, connection, storage);
            equipment = equipmentModel.GetPlayerEquipment(player, connection, equipment);

            RecruitWindow window = new RecruitWindow(connection, player, storage, equipment);
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Owner = this;
            window.Show();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String taxQuery = "INSERT INTO dbo.ManufactureLvlData (lvl, wood, stone) VALUES (@lvl, @wood, @stone)";
            var taxCommand = new SqlCommand(taxQuery, connection);
            for (int i = 5; i <= 150; i++)
            {
                taxCommand.Parameters.AddWithValue("@lvl", i);
                taxCommand.Parameters.AddWithValue("@wood", i * 200 * 2.5);
                taxCommand.Parameters.AddWithValue("@stone", i * 100 * 2.5);
                taxCommand.ExecuteNonQuery();
            }
        }

        private void PathEnterHandler(object sender, RoutedEventArgs e)
        {
            try
            {
                Path senderPath = (Path)sender;

                System.Windows.Media.Color color = ((SolidColorBrush)senderPath.Fill).Color;
                color.R -= 10;
                color.G -= 10;
                color.B -= 10;

                senderPath.Fill = new SolidColorBrush(color);

                //HatchBrush hBrush = new HatchBrush(HatchStyle.Horizontal, System.Drawing.Color.Red);
                //Graphics.FromImage(hBrush, 0, 0, 100, 60);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButton.OK);
            }
        }

        private void PathLeaveHandler(object sender, RoutedEventArgs e)
        {
            try
            {
                Path senderPath = (Path)sender;

                System.Windows.Media.Color color = ((SolidColorBrush)senderPath.Fill).Color;
                color.R += 10;
                color.G += 10;
                color.B += 10;

                senderPath.Fill = new SolidColorBrush(color);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButton.OK);
            }
        }

        private void PathDownHandler(object sender, RoutedEventArgs e)
        {
            try
            {
                Path senderPath = (Path)sender;
                land = new Land();

                land = lands.ElementAt(Convert.ToInt32(senderPath.Name.Replace("Land", "")) - 1);
                lblLandNameOnGrid.Content = land.LandName;


                for (int i = 0; i < countries.Count; i++)
                {
                    if (land.CountryId == countries[i].CountryId)
                    {
                        lblCountryNameOnGrid.Content = countries[i].CountryName;
                        break;
                    }
                }

                //flagXY[0] = Convert.ToInt32(senderPath.Data.Bounds.Left + senderPath.Data.Bounds.Width / 2 + Convert.ToInt32(GlobalMap.Margin.Left));
                //flagXY[1] = Convert.ToInt32(senderPath.Data.Bounds.Top + senderPath.Data.Bounds.Height / 2 + Convert.ToInt32(GlobalMap.Margin.Top));
                //flagXY[2] = Convert.ToInt32(senderPath.Data.Bounds.Right + senderPath.Data.Bounds.Width / 2 + Convert.ToInt32(GlobalMap.Margin.Right));
                //flagXY[3] = Convert.ToInt32(senderPath.Data.Bounds.Bottom + senderPath.Data.Bounds.Height / 2 + Convert.ToInt32(GlobalMap.Margin.Bottom));


                switch (land.ResourceType1)
                {
                    case 4:
                        {
                            lblLandResource1NameOnGrid.Content = "iron";
                            imgLandResource1ImgOnGrid.Source = new BitmapImage(new Uri("/Pictures/iron.png", UriKind.Relative));
                            break;
                        }
                    case 5:
                        {
                            lblLandResource1NameOnGrid.Content = "gold_ore";
                            imgLandResource1ImgOnGrid.Source = new BitmapImage(new Uri("/Pictures/gold_ore.png", UriKind.Relative));
                            break;
                        }
                    case 6:
                        {
                            lblLandResource1NameOnGrid.Content = "copper";
                            imgLandResource1ImgOnGrid.Source = new BitmapImage(new Uri("/Pictures/copper.png", UriKind.Relative));
                            break;
                        }
                    case 7:
                        {
                            lblLandResource1NameOnGrid.Content = "gems";
                            imgLandResource1ImgOnGrid.Source = new BitmapImage(new Uri("/Pictures/gems.png", UriKind.Relative));
                            break;
                        }
                    case 8:
                        {
                            lblLandResource1NameOnGrid.Content = "leather";
                            imgLandResource1ImgOnGrid.Source = new BitmapImage(new Uri("/Pictures/leather.png", UriKind.Relative));
                            break;
                        }
                }

                switch (land.ResourceType2)
                {
                    case 4:
                        {
                            lblLandResource2NameOnGrid.Content = "iron";
                            imgLandResource2ImgOnGrid.Source = new BitmapImage(new Uri("/Pictures/iron.png", UriKind.Relative));
                            break;
                        }
                    case 5:
                        {
                            lblLandResource2NameOnGrid.Content = "gold_ore";
                            imgLandResource2ImgOnGrid.Source = new BitmapImage(new Uri("/Pictures/gold_ore.png", UriKind.Relative));
                            break;
                        }
                    case 6:
                        {
                            lblLandResource2NameOnGrid.Content = "copper";
                            imgLandResource2ImgOnGrid.Source = new BitmapImage(new Uri("/Pictures/copper.png", UriKind.Relative));
                            break;
                        }
                    case 7:
                        {
                            lblLandResource2NameOnGrid.Content = "gems";
                            imgLandResource2ImgOnGrid.Source = new BitmapImage(new Uri("/Pictures/gems.png", UriKind.Relative));
                            break;
                        }
                    case 8:
                        {
                            lblLandResource2NameOnGrid.Content = "leather";
                            imgLandResource2ImgOnGrid.Source = new BitmapImage(new Uri("/Pictures/leather.png", UriKind.Relative));
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButton.OK);
            }
        }



        private void PathLoadedHandler(object sender, RoutedEventArgs e)
        {
            try
            {
                Path senderPath = (Path)sender;
                paths.Add(senderPath);
                land = new Land();
                land = lands.ElementAt(Convert.ToInt32(senderPath.Name.Replace("Land", "")) - 1);


                Color color = (Color)ColorConverter.ConvertFromString(land.LandColor);

                senderPath.Fill = new SolidColorBrush(color);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButton.OK);
            }
        }

        private void ResourceMapBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            GlobalMap.Visibility = Visibility.Hidden;
            ResourceMap.Visibility = Visibility.Visible;
        }

        private void GlobalMapBtn_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ResourceMap.Visibility = Visibility.Hidden;
            GlobalMap.Visibility = Visibility.Visible;
        }


        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            settingsGrid.Visibility = Visibility.Hidden;
        }

        private void ExitButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            AuthorisationWindow window = new AuthorisationWindow();
            window.Show();
            this.Close();

        }
        private void playMusic()
        {
            SoundPlayer sound = new SoundPlayer();
            sound.SoundLocation = @"music.wav";
            sound.PlayLooping();

            //sound.SoundLocation = @"music2.wav";
            //sound.PlayLooping();

            //sound.SoundLocation = @"music3.wav";
            //sound.PlayLooping();
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            playMusic();
        }

        private void btnGoToLand_Click(object sender, RoutedEventArgs e)
        {

            peasants = peasantModel.GetPeasantsInfo(player, connection, peasants);
            List<int> list = playerModel.DeletePlayerManufactureLandData(peasants, player, connection);
            List<Manufacture> landManufactures = manufactureModel.GetLandManufactureInfo(player, connection);
            Console.WriteLine("playerRegion: " + player.PlayerCurrentRegion);
            Console.WriteLine("manufacture: " + landManufactures[0].ManufactureId + "  " + landManufactures[0].ManufacturePeasantWork);
            Console.WriteLine("list: " + list[0] + "  " + list[1]);
            manufactureModel.UpdateLandManufacturesWhenMove(connection, list, landManufactures);
            player = playerModel.UpdatePlayerLand(player, connection, land);

            //flag.Margin = new Thickness(flagXY[0] - 69, flagXY[1] - 36, 0, 0);
            //flag.Margin = new Thickness(Convert.ToDouble(GlobalMap.Margin.Left), Convert.ToDouble(GlobalMap.Margin.Top), 0, 0);

            //flag.Stretch
            flagXY = mapModel.CenterOfLand(land.LandId);
            flag.Margin = new Thickness(flagXY[0], flagXY[1], 0, 0);

            Console.WriteLine("flag coo: " + flagXY[0] + " " + flagXY[1]);
            Console.WriteLine("map coo: " + Convert.ToInt32(GlobalMap.Margin.Left) + " " + Convert.ToInt32(GlobalMap.Margin.Top));


        }

        private void buttonEstablishaState_Click(object sender, RoutedEventArgs e)
        {
            EstablishStateDialog win = new EstablishStateDialog(connection, player, land);
            win.Owner = this;
            win.Show();
        }

        public void RedrawGlobalMap()
        {
            for (int i = 0; i < paths.Count; i++)
            {
                Color color = (Color)ColorConverter.ConvertFromString(lands[i].LandColor);

                paths[i].Fill = new SolidColorBrush(color);
            }
        }

        private void buttonProfile_Click(object sender, RoutedEventArgs e)
        {
            ProfileWindow profileWindow = new ProfileWindow(this, connection, player, user);
            profileWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            profileWindow.Owner = this;
            profileWindow.Show();
        }

        public Player CheckLvlChange(Player player)
        {

            while (Math.Pow(player.PlayerLvl, 2) * 500 - player.PlayerExp <= 0)
            {
                player.PlayerLvl += 1;

                Level.Content = player.PlayerLvl.ToString();
                //запрос на ддобавление уровня
            }

            PbExp.Maximum = player.PlayerLvl * 2 * 500;
            PbExp.Value = player.PlayerExp;

            return player;
        }

        private void btnHideLandGrid_Click(object sender, RoutedEventArgs e)
        {
            Country_characters.Visibility = Visibility.Hidden;
        }

        private void btnShowLandGrid_Click(object sender, RoutedEventArgs e)
        {
            Country_characters.Visibility = Visibility.Visible;
        }

        private void buttonSettings_MouseEnter(object sender, MouseEventArgs e)
        {
            settingsGrid.Visibility = Visibility.Visible;
        }

        private void settingsGrid_MouseLeave(object sender, MouseEventArgs e)
        {
            settingsGrid.Visibility = Visibility.Hidden;
        }

        private void buttonTop_Click(object sender, RoutedEventArgs e)
        {
            RatingWindow ratingWindow = new RatingWindow(this, connection, player, user);
            ratingWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            ratingWindow.Owner = this;
            ratingWindow.Show();
        }

        private void test2_Click(object sender, RoutedEventArgs e)
        {
            //Console.WriteLine(land.LandName);
            landModel.AddLandManufactures(land, connection);
        }

        private void buttonChat_Click(object sender, RoutedEventArgs e)
        {
            ChatWindow chatWindow = new ChatWindow(player);
            chatWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            chatWindow.Owner = this;
            chatWindow.Show();
        }

        private void marketImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            storage = storageModel.GetPlayerStorage(player, connection, storage);
            market = marketModel.GetMarketInfo(player, connection, market);

            MarketWindow window = new MarketWindow(this, connection, storage, market, player);
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Owner = this;
            window.Show();
        }

        private void CountryImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CountryWindow win = new CountryWindow(connection, player);
            win.Show();
        }

        private void LandImage_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void DeclareWar_Click(object sender, RoutedEventArgs e)
        {
            ArmyModel armyModel = new ArmyModel();
            Army army = new Army();
            army = armyModel.GetArmyInfo(connection, player, army);

            BattleModel battleModel = new BattleModel();
            ArmyInBattle armyInBattle = new ArmyInBattle();

            int count = battleModel.CheckPlayerParticipation(connection, player);

            War war = new War();
            war.WarId = "lbOxckUUoYmKaEC1";

            if (count == 0)
            {

                armyInBattle.PlayerId = army.PlayerId;
                armyInBattle.ArmyId = army.ArmyId;
                armyInBattle.ArmySizeCurrent = army.ArmySizeCurrent;
                armyInBattle.ArmyType = army.ArmyType;
                armyInBattle.ArmyArchersCount = army.ArmyArchersCount;
                armyInBattle.ArmyInfantryCount = army.ArmyInfantryCount;
                armyInBattle.ArmySiegegunCount = army.ArmySiegegunCount;
                armyInBattle.ArmyHorsemanCount = army.ArmyHorsemanCount;

                //ПРОВЕРКА СТОРОНЫ ЗА КОТОРУЮ ВОЮЕТ ИГРОК. ДЕЛАТЬ ЧЕК ЧЕРЕЗ МЕСТОПОЛОЖЕНИЕ ИГРОКА
                // //
                //  Net
                // //

                // -------------------------------------------------------------------------------------------
                //Это говнокод. Мы просто предположили что чел атакующий.

                Random random = new Random();
                armyInBattle.LocalLandId = ReturnNumberOfCell(20, random.Next(1, 30));
                armyInBattle.ArmySide = 1; // hueta

                battleModel.InsertArmyIntoBattleTable(connection, armyInBattle, war);

            }

            List<ArmyInBattle> armiesInBattle = new List<ArmyInBattle>();
            for (int i = 0; i < battleModel.SelectLastIdOfArmies(connection, war); i++)
            {
                armiesInBattle.Add(new ArmyInBattle());
            }

            armiesInBattle = battleModel.GetArmiesInfo(connection, armiesInBattle, war);

            //armyModel.UpdateArmy(connection, army);
            // до сюда говно ------------------------------------------------------------------------------

            WarWindow window = new WarWindow(connection, player, armyInBattle, armiesInBattle, war);
            window.Show();
        }

        public int ReturnNumberOfCell(int row, int column)
        {
            int index = (row - 1) * 30 + column - 1;
            return index;
        }

        private void buttonStartBattle_Click(object sender, RoutedEventArgs e)
        {
            WarResultWindow warResultWindow = new WarResultWindow(connection, player);
            warResultWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            warResultWindow.Owner = this;
            warResultWindow.Show();
        }

        public void LoadWarsOnMap()
        {
            int[] landCenter = new int[1];
            marginsOfWarButtons = new Thickness[wars.Count];

            for (int i = 0; i < wars.Count; i++)
            {
                Line warLine = new Line();
                SymbalLayer.Children.Add(warLine);
                Console.WriteLine(wars[i].WarId + ' ' + wars[i].LandAttackerId + ' ' + wars[i].LandDefenderId);
                Console.WriteLine(SymbalLayer.Children.Count);
                landCenter = mapModel.CenterOfLand(wars[i].LandAttackerId);
                warLine.X1 = landCenter[0] + 15;
                warLine.Y1 = landCenter[1] + 30;
                landCenter = mapModel.CenterOfLand(wars[i].LandDefenderId);
                warLine.X2 = landCenter[0] + 15;
                warLine.Y2 = landCenter[1] + 30;
                warLine.Stroke = System.Windows.Media.Brushes.Black;
                warLine.StrokeThickness = 1;

                Image btnWar = new Image();
                btnWar.Height = 25;
                btnWar.Width = 25;
                btnWar.Source = new BitmapImage(new Uri("/Pictures/warSymbal.png", UriKind.Relative));
                btnWar.Margin = new Thickness(warLine.X1 + (warLine.X2 - warLine.X1) / 2 - 12, warLine.Y1 + (warLine.Y2 - warLine.Y1) / 2 - 15, 0, 0);
                btnWar.MouseLeftButtonDown += btnWar_MouseLeftButtonDown;
                btnWar.MouseEnter += btnWar_MouseEnter;
                btnWar.MouseLeave += btnWar_MouseLeave;

                marginsOfWarButtons[i] = btnWar.Margin;

                SymbalLayer.Children.Add(btnWar);
            }
        }

        private void btnWar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // переход в войну
            for (int j = 0; j < wars.Count; j++)
            {
                if (((Image)sender).Margin == marginsOfWarButtons[j])
                {
                    Console.WriteLine("Ключ войны = " + wars[j].WarId);

                    ArmyModel armyModel = new ArmyModel();
                    Army army = new Army();
                    army = armyModel.GetArmyInfo(connection, player, army);

                    BattleModel battleModel = new BattleModel();
                    ArmyInBattle armyInBattle = new ArmyInBattle();

                    int count = battleModel.CheckPlayerParticipation(connection, player);

                    War war = new War();
                    war.WarId = wars[j].WarId;

                    if (count == 0)
                    {

                        armyInBattle.PlayerId = army.PlayerId;
                        armyInBattle.ArmyId = army.ArmyId;
                        armyInBattle.ArmySizeCurrent = army.ArmySizeCurrent;
                        armyInBattle.ArmyType = army.ArmyType;
                        armyInBattle.ArmyArchersCount = army.ArmyArchersCount;
                        armyInBattle.ArmyInfantryCount = army.ArmyInfantryCount;
                        armyInBattle.ArmySiegegunCount = army.ArmySiegegunCount;
                        armyInBattle.ArmyHorsemanCount = army.ArmyHorsemanCount;

                        //ПРОВЕРКА СТОРОНЫ ЗА КОТОРУЮ ВОЮЕТ ИГРОК. ДЕЛАТЬ ЧЕК ЧЕРЕЗ МЕСТОПОЛОЖЕНИЕ ИГРОКА
                        // //
                        //  Net
                        // //

                        // -------------------------------------------------------------------------------------------
                        //Это говнокод. Мы просто предположили что чел атакующий.

                        Random random = new Random();
                        armyInBattle.LocalLandId = ReturnNumberOfCell(20, random.Next(1, 30));
                        armyInBattle.ArmySide = 1; // hueta

                        battleModel.InsertArmyIntoBattleTable(connection, armyInBattle, war);

                    }

                    List<ArmyInBattle> armiesInBattle = new List<ArmyInBattle>();
                    for (int i = 0; i < battleModel.SelectLastIdOfArmies(connection, war); i++)
                    {
                        armiesInBattle.Add(new ArmyInBattle());
                    }

                    armiesInBattle = battleModel.GetArmiesInfo(connection, armiesInBattle, war);

                    //armyModel.UpdateArmy(connection, army);
                    // до сюда говно ------------------------------------------------------------------------------

                    WarWindow window = new WarWindow(connection, player, armyInBattle, armiesInBattle, war);
                    window.Show();


                }
            }
        }

        private void btnWar_MouseEnter(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void btnWar_MouseLeave(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Arrow;
        }
    }
}

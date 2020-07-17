﻿using LandConquest.DialogWIndows;
using LandConquest.Entities;
using LandConquest.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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
    public partial class ManufactureWindow : Window
    {
        SqlConnection connection;
        Player player;
        MainWindow window;
        Peasants peasants;
        List<Manufacture> manufactures;
        List<Manufacture> landManufactures;
        List<Manufacture> playerLandManufactures;
        ManufactureModel model;
        PeasantModel peasantModel;
        PlayerStorage storage;
        int unemployedPeasantsCount;
        int employedPeasantsCount;
        int peasantsWorkingOnB1 = 0;
        int peasantsWorkingOnB2 = 0;

        public ManufactureWindow(MainWindow _window, SqlConnection _connection, Player _player, PlayerStorage _storage)
        {
            InitializeComponent();
            Loaded += ManufactureWindow_Loaded;
            window = _window;
            player = _player;
            storage = _storage;
            //user = _user;
            connection = _connection;
        }

        private void ManufactureWindow_Loaded(object sender, RoutedEventArgs e)
        {
            model = new ManufactureModel();
            peasantModel = new PeasantModel();
            peasants = new Peasants();
            
            peasants = peasantModel.GetPeasantsInfo(player, connection, peasants);

            Console.WriteLine("workers=" + peasants.PeasantsWork.ToString());

            employedPeasants.Content = peasants.PeasantsWork.ToString();
            unemployedPeasants.Content = (peasants.PeasantsCount - peasants.PeasantsWork).ToString();
            totalPeasants.Content = peasants.PeasantsMax.ToString();

            unemployedPeasantsCount = peasants.PeasantsCount - peasants.PeasantsWork;
            employedPeasantsCount = peasants.PeasantsWork;

            manufactures = new List<Manufacture>();
            manufactures = model.GetManufactureInfo(player, connection);

            landManufactures = new List<Manufacture>();
            landManufactures = model.GetLandManufactureInfo(player, connection);

            try
            {
                playerLandManufactures = model.GetPlayerLandManufactureInfo(player, connection);
                if (playerLandManufactures.Count == 0)
                {
                    playerLandManufactures = new List<Manufacture>();
                    for (int i = 0; i < 2; i++)
                    {
                        playerLandManufactures.Add(new Manufacture());
                        playerLandManufactures[i].ManufacturePeasantWork = 0;
                    }
                    //playerLandManufactures[0].ManufacturePeasantWork = 0;
                    //playerLandManufactures[1].ManufacturePeasantWork = 0;
                }
            }
            catch
            {
                Console.WriteLine("zashlo");
                playerLandManufactures[0].ManufacturePeasantWork = 0;
                playerLandManufactures[1].ManufacturePeasantWork = 0;
            }

            peasantsWorkingOnB1 = landManufactures[0].ManufacturePeasantWork;
            peasantsWorkingOnB2 = landManufactures[1].ManufacturePeasantWork;

            Quarrylvl.Content = manufactures[1].ManufactureLevel;
            PbQuarry.Maximum = manufactures[1].ManufacturePeasantMax;
            sliderQuarry.Value = manufactures[1].ManufacturePeasantWork;
            sliderQuarry.Maximum = manufactures[1].ManufacturePeasantMax;

            Sawmilllvl.Content = manufactures[0].ManufactureLevel;
            PbSawmill.Maximum = manufactures[0].ManufacturePeasantMax;
            sliderSawmill.Value = manufactures[0].ManufacturePeasantWork;
            sliderSawmill.Maximum = manufactures[0].ManufacturePeasantMax;

            Windmilllvl.Content = manufactures[2].ManufactureLevel;
            PbWindmill.Maximum = manufactures[2].ManufacturePeasantMax;
            sliderWindmill.Value = manufactures[2].ManufacturePeasantWork;
            sliderWindmill.Maximum = manufactures[2].ManufacturePeasantMax;
            //land manufactures content
            //building 1
            buildingName1.Content = landManufactures[0].ManufactureName;
            building1LvlAmount.Content = landManufactures[0].ManufactureLevel;
            PbBuilding1.Maximum = landManufactures[0].ManufacturePeasantMax - landManufactures[0].ManufacturePeasantWork + playerLandManufactures[0].ManufacturePeasantWork;
            sliderBuilding1.Value = playerLandManufactures[0].ManufacturePeasantWork;
            sliderBuilding1.Maximum = landManufactures[0].ManufacturePeasantMax - landManufactures[0].ManufacturePeasantWork + playerLandManufactures[0].ManufacturePeasantWork; //+ playerlm.pw;
            WorkingNowB1.Content = landManufactures[0].ManufacturePeasantWork;
            //building 2
            buildingName2.Content = landManufactures[1].ManufactureName;
            building2lvlAmount.Content = landManufactures[1].ManufactureLevel;
            PbBuilding2.Maximum = landManufactures[1].ManufacturePeasantMax - landManufactures[1].ManufacturePeasantWork + playerLandManufactures[1].ManufacturePeasantWork;
            sliderBuilding2.Value = playerLandManufactures[1].ManufacturePeasantWork;
            sliderBuilding2.Maximum = landManufactures[1].ManufacturePeasantMax - landManufactures[1].ManufacturePeasantWork + playerLandManufactures[1].ManufacturePeasantWork;
            WorkingNowB2.Content = landManufactures[1].ManufacturePeasantWork;
            //-----------------------------
            if (sliderQuarry.Value + Convert.ToInt32(unemployedPeasants.Content) <= PbQuarry.Maximum)
                sliderQuarry.Maximum = sliderQuarry.Value + Convert.ToInt32(unemployedPeasants.Content);
            if (sliderSawmill.Value + Convert.ToInt32(unemployedPeasants.Content) <= PbSawmill.Maximum)
                sliderSawmill.Maximum = sliderSawmill.Value + Convert.ToInt32(unemployedPeasants.Content);
            if (sliderWindmill.Value + Convert.ToInt32(unemployedPeasants.Content) <= PbWindmill.Maximum)
                sliderWindmill.Maximum = sliderWindmill.Value + Convert.ToInt32(unemployedPeasants.Content);
            if (sliderBuilding1.Value + Convert.ToInt32(unemployedPeasants.Content) <= sliderBuilding1.Maximum)
                sliderBuilding1.Maximum = sliderBuilding1.Value + Convert.ToInt32(unemployedPeasants.Content);
            if (sliderBuilding2.Value + Convert.ToInt32(unemployedPeasants.Content) <= sliderBuilding2.Maximum)
                sliderBuilding2.Maximum = sliderBuilding2.Value + Convert.ToInt32(unemployedPeasants.Content);
        }

        private void buttonBuy_Click(object sender, RoutedEventArgs e)
        {
            ManufactureBuyingDialog manufactureBuying = new ManufactureBuyingDialog();
            manufactureBuying.Show();
        }

        private void sliderQuarry_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            sliderQuarry.IsSnapToTickEnabled = true;
            PbQuarry.Value = sliderQuarry.Value;
            QuarryProdValueHour.Content = Convert.ToInt32(sliderQuarry.Value) * manufactures[1].ManufactureBaseProdValue;
        }

        private void sliderQuarry_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine(unemployedPeasantsCount);
            employedPeasants.Content = sliderQuarry.Value + sliderSawmill.Value + sliderWindmill.Value + sliderBuilding1.Value + sliderBuilding2.Value;
            unemployedPeasants.Content = peasants.PeasantsCount - sliderQuarry.Value - sliderSawmill.Value - sliderWindmill.Value - sliderBuilding1.Value - sliderBuilding2.Value;

            if (sliderSawmill.Value + Convert.ToInt32(unemployedPeasants.Content) <= PbSawmill.Maximum)
                sliderSawmill.Maximum = PbSawmill.Value + Convert.ToInt32(unemployedPeasants.Content);
            if (sliderWindmill.Value + Convert.ToInt32(unemployedPeasants.Content) <= PbWindmill.Maximum)
                sliderWindmill.Maximum = PbWindmill.Value + Convert.ToInt32(unemployedPeasants.Content);
            if (sliderBuilding1.Value + Convert.ToInt32(unemployedPeasants.Content) <= PbBuilding1.Maximum)
                sliderBuilding1.Maximum = PbBuilding1.Value + Convert.ToInt32(unemployedPeasants.Content);
            if (sliderBuilding2.Value + Convert.ToInt32(unemployedPeasants.Content) <= PbBuilding2.Maximum)
                sliderBuilding2.Maximum = PbBuilding2.Value + Convert.ToInt32(unemployedPeasants.Content);

            if (Convert.ToInt32(unemployedPeasants.Content) < 0)
            {
                sliderQuarry.Value = sliderQuarry.Value + Convert.ToInt32(unemployedPeasants.Content) + 200;
                unemployedPeasants.Content = 0;
                employedPeasants.Content = peasants.PeasantsCount;
                PbQuarry.Value = sliderQuarry.Value;
                sliderQuarry.Maximum = sliderQuarry.Value;
            }
        }

        private void sliderSawmill_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            employedPeasants.Content = sliderQuarry.Value + sliderSawmill.Value + sliderWindmill.Value + sliderBuilding1.Value + sliderBuilding2.Value;
            unemployedPeasants.Content = peasants.PeasantsCount - sliderQuarry.Value - sliderSawmill.Value - sliderWindmill.Value - sliderBuilding1.Value - sliderBuilding2.Value;

            if (sliderQuarry.Value + Convert.ToInt32(unemployedPeasants.Content) <= PbQuarry.Maximum)
                sliderQuarry.Maximum = PbQuarry.Value + Convert.ToInt32(unemployedPeasants.Content);
            if (sliderWindmill.Value + Convert.ToInt32(unemployedPeasants.Content) <= PbWindmill.Maximum)
                sliderWindmill.Maximum = PbWindmill.Value + Convert.ToInt32(unemployedPeasants.Content);
            if (sliderBuilding1.Value + Convert.ToInt32(unemployedPeasants.Content) <= PbBuilding1.Maximum)
                sliderBuilding1.Maximum = PbBuilding1.Value + Convert.ToInt32(unemployedPeasants.Content);
            if (sliderBuilding2.Value + Convert.ToInt32(unemployedPeasants.Content) <= PbBuilding2.Maximum)
                sliderBuilding2.Maximum = PbBuilding2.Value + Convert.ToInt32(unemployedPeasants.Content);
            if (Convert.ToInt32(unemployedPeasants.Content) < 0)
            {
                sliderSawmill.Value = sliderSawmill.Value + Convert.ToInt32(unemployedPeasants.Content);
                unemployedPeasants.Content = 0;
                employedPeasants.Content = peasants.PeasantsCount;
                PbSawmill.Value = sliderSawmill.Value;
                sliderSawmill.Maximum = sliderSawmill.Value;
            }
        }

        private void sliderWindmill_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            employedPeasants.Content = sliderQuarry.Value + sliderSawmill.Value + sliderWindmill.Value + sliderBuilding1.Value + sliderBuilding2.Value;
            unemployedPeasants.Content = peasants.PeasantsCount - sliderQuarry.Value - sliderSawmill.Value - sliderWindmill.Value - sliderBuilding1.Value - sliderBuilding2.Value;

            if (sliderQuarry.Value + Convert.ToInt32(unemployedPeasants.Content) <= PbQuarry.Maximum)
                sliderQuarry.Maximum = PbQuarry.Value + Convert.ToInt32(unemployedPeasants.Content);
            if (sliderSawmill.Value + Convert.ToInt32(unemployedPeasants.Content) <= PbSawmill.Maximum)
                sliderSawmill.Maximum = PbSawmill.Value + Convert.ToInt32(unemployedPeasants.Content);
            if (sliderBuilding1.Value + Convert.ToInt32(unemployedPeasants.Content) <= PbBuilding1.Maximum)
                sliderBuilding1.Maximum = PbBuilding1.Value + Convert.ToInt32(unemployedPeasants.Content);
            if (sliderBuilding2.Value + Convert.ToInt32(unemployedPeasants.Content) <= PbBuilding2.Maximum)
                sliderBuilding2.Maximum = PbBuilding2.Value + Convert.ToInt32(unemployedPeasants.Content);

            if (Convert.ToInt32(unemployedPeasants.Content) < 0)
            {
                sliderWindmill.Value = sliderWindmill.Value + Convert.ToInt32(unemployedPeasants.Content);
                unemployedPeasants.Content = 0;
                employedPeasants.Content = peasants.PeasantsCount;
                PbWindmill.Value = sliderWindmill.Value;
                sliderWindmill.Maximum = sliderWindmill.Value;
            }
        }

        private void sliderWindmill_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            sliderWindmill.IsSnapToTickEnabled = true;
            PbWindmill.Value = sliderWindmill.Value;
            WindmillProdValueHour.Content = Convert.ToInt32(sliderWindmill.Value) * manufactures[2].ManufactureBaseProdValue;
        }

        private void sliderSawmill_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            sliderSawmill.IsSnapToTickEnabled = true;
            PbSawmill.Value = sliderSawmill.Value;
            SawmillProdValueHour.Content = Convert.ToInt32(sliderSawmill.Value) * manufactures[0].ManufactureBaseProdValue;
        }

        private void BtnStartProduction_Click(object sender, RoutedEventArgs e)
        {
            manufactures[0].ManufacturePeasantWork = Convert.ToInt32(sliderSawmill.Value);
            manufactures[1].ManufacturePeasantWork = Convert.ToInt32(sliderQuarry.Value);
            manufactures[2].ManufacturePeasantWork = Convert.ToInt32(sliderWindmill.Value);

            peasants.PeasantsWork = Convert.ToInt32(employedPeasants.Content);
            Console.WriteLine("workers=" + peasants.PeasantsWork);
            peasantModel = new PeasantModel();
            peasants = peasantModel.UpdatePeasantsInfo(peasants, connection);

            manufactures[0].ManufactureProductsHour = Convert.ToInt32(SawmillProdValueHour.Content);
            
            manufactures[1].ManufactureProductsHour = Convert.ToInt32(QuarryProdValueHour.Content);

            manufactures[2].ManufactureProductsHour = Convert.ToInt32(WindmillProdValueHour.Content);

            landManufactures = model.GetLandManufactureInfo(player, connection);            

            //хуета полнейшая - сделай новую сущность для городских мануфактур игрока
            landManufactures[0].ManufacturePeasantWork = Convert.ToInt32(sliderBuilding1.Value + Convert.ToInt32(WorkingNowB1.Content) - playerLandManufactures[0].ManufacturePeasantWork);
            landManufactures[1].ManufacturePeasantWork = Convert.ToInt32(sliderBuilding2.Value + Convert.ToInt32(WorkingNowB2.Content) - playerLandManufactures[1].ManufacturePeasantWork);

            playerLandManufactures[0].ManufactureProductsHour = Convert.ToInt32(building1ProdValueHour.Content);
            playerLandManufactures[1].ManufactureProductsHour = Convert.ToInt32(building2ProdValueHour.Content);

            Console.WriteLine("b2_bv = " + Convert.ToInt32(building2ProdValueHour.Content));

            playerLandManufactures[0].ManufacturePeasantWork = Convert.ToInt32(sliderBuilding1.Value);
            playerLandManufactures[1].ManufacturePeasantWork = Convert.ToInt32(sliderBuilding2.Value);

            playerLandManufactures[0].ManufactureId = landManufactures[0].ManufactureId;
            playerLandManufactures[1].ManufactureId = landManufactures[1].ManufactureId;

            playerLandManufactures[0].ManufactureType = landManufactures[0].ManufactureType;
            playerLandManufactures[1].ManufactureType = landManufactures[1].ManufactureType;

            playerLandManufactures[0].ManufactureProductsHour = Convert.ToInt32(building1ProdValueHour.Content);
            playerLandManufactures[1].ManufactureProductsHour = Convert.ToInt32(building2ProdValueHour.Content); 

            //не забудь убрать лох //убрал кста
            model.InsertOrUpdateLandManufactures(playerLandManufactures, player, connection); //это пользовательская сущность городской мануфактуры
            //возвращаю костыль
            //model.UpdateLandManufactures(landManufactures, player, connection);
            //---------------------
            model.UpdateDateTimeForManufacture(manufactures, player, connection);
            model.UpdateLandManufactures(landManufactures, connection); //это общая сущность - тут хранятся общие данные игроков.
        }

        private void buttonQuarryUpgrade_Click(object sender, RoutedEventArgs e)
        {
            ManufactureUpgradeDialog dialogwindow = new ManufactureUpgradeDialog(connection, storage, manufactures[1], player);
            dialogwindow.Show();
        }

        private void buttonSawmillUpgrade_Click(object sender, RoutedEventArgs e)
        {
            ManufactureUpgradeDialog dialogwindow = new ManufactureUpgradeDialog(connection, storage, manufactures[0], player);
            dialogwindow.Show();
        }

        private void buttonWindmillUpgrade_Click(object sender, RoutedEventArgs e)
        {
            ManufactureUpgradeDialog dialogwindow = new ManufactureUpgradeDialog(connection, storage, manufactures[2], player);
            dialogwindow.Show();
        }

        private void button_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void sliderBuilding1_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            employedPeasants.Content = sliderQuarry.Value + sliderSawmill.Value + sliderWindmill.Value + sliderBuilding1.Value + sliderBuilding2.Value;
            unemployedPeasants.Content = peasants.PeasantsCount - sliderQuarry.Value - sliderSawmill.Value - sliderWindmill.Value - sliderBuilding1.Value - sliderBuilding2.Value;

            if (sliderSawmill.Value + Convert.ToInt32(unemployedPeasants.Content) <= PbSawmill.Maximum)
                sliderSawmill.Maximum = PbSawmill.Value + Convert.ToInt32(unemployedPeasants.Content);
            if (sliderQuarry.Value + Convert.ToInt32(unemployedPeasants.Content) <= PbQuarry.Maximum)
                sliderQuarry.Maximum = PbQuarry.Value + Convert.ToInt32(unemployedPeasants.Content);
            if (sliderWindmill.Value + Convert.ToInt32(unemployedPeasants.Content) <= PbWindmill.Maximum)
                sliderWindmill.Maximum = PbWindmill.Value + Convert.ToInt32(unemployedPeasants.Content);
            if (sliderBuilding2.Value + Convert.ToInt32(unemployedPeasants.Content) <= PbBuilding2.Maximum)
                sliderBuilding2.Maximum = PbBuilding2.Value + Convert.ToInt32(unemployedPeasants.Content);


            if (Convert.ToInt32(unemployedPeasants.Content) < 0)
            {
                sliderBuilding1.Value = sliderBuilding1.Value + Convert.ToInt32(unemployedPeasants.Content) + 200;
                unemployedPeasants.Content = 0;
                employedPeasants.Content = peasants.PeasantsCount;
                PbBuilding1.Value = sliderBuilding1.Value;
                sliderBuilding1.Maximum = sliderBuilding1.Value;
            }
        }

        private void sliderBuilding1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            sliderBuilding1.IsSnapToTickEnabled = true;
            PbBuilding1.Value = sliderBuilding1.Value;
            building1ProdValueHour.Content = Convert.ToInt32(sliderBuilding1.Value - peasantsWorkingOnB1) * landManufactures[0].ManufactureBaseProdValue;
        }

        private void sliderBuilding2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            sliderBuilding2.IsSnapToTickEnabled = true;
            PbBuilding2.Value = sliderBuilding2.Value;
            building2ProdValueHour.Content = Convert.ToInt32(sliderBuilding2.Value - peasantsWorkingOnB2) * landManufactures[1].ManufactureBaseProdValue;
        }

        private void sliderBuilding2_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            employedPeasants.Content = sliderQuarry.Value + sliderSawmill.Value + sliderWindmill.Value + sliderBuilding1.Value + sliderBuilding2.Value;
            unemployedPeasants.Content = peasants.PeasantsCount - sliderQuarry.Value - sliderSawmill.Value - sliderWindmill.Value - sliderBuilding1.Value - sliderBuilding2.Value;

            if (sliderSawmill.Value + Convert.ToInt32(unemployedPeasants.Content) <= PbSawmill.Maximum)
                sliderSawmill.Maximum = PbSawmill.Value + Convert.ToInt32(unemployedPeasants.Content);
            if (sliderQuarry.Value + Convert.ToInt32(unemployedPeasants.Content) <= PbQuarry.Maximum)
                sliderQuarry.Maximum = PbQuarry.Value + Convert.ToInt32(unemployedPeasants.Content);
            if (sliderWindmill.Value + Convert.ToInt32(unemployedPeasants.Content) <= PbWindmill.Maximum)
                sliderWindmill.Maximum = PbWindmill.Value + Convert.ToInt32(unemployedPeasants.Content);
            if (sliderBuilding1.Value + Convert.ToInt32(unemployedPeasants.Content) <= PbBuilding1.Maximum)
                sliderBuilding1.Maximum = PbBuilding1.Value + Convert.ToInt32(unemployedPeasants.Content);


            if (Convert.ToInt32(unemployedPeasants.Content) < 0)
            {
                sliderBuilding2.Value = sliderBuilding2.Value + Convert.ToInt32(unemployedPeasants.Content) + 200;
                unemployedPeasants.Content = 0;
                employedPeasants.Content = peasants.PeasantsCount;
                PbBuilding2.Value = sliderBuilding2.Value;
                sliderBuilding2.Maximum = sliderBuilding2.Value;
            }
        }
    }
}
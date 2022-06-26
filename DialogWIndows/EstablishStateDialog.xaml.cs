﻿using LandConquestDB.Entities;
using LandConquestDB.Models;
using System;
using System.Resources;
using System.Windows;

namespace LandConquest.DialogWIndows
{

    public partial class EstablishStateDialog : Window
    {
        private Player player;
        private Land land;
        private LandModel landModel;
        private CountryModel countryModel;

        public EstablishStateDialog(Player _player, Land _land)
        {
            InitializeComponent();
            player = _player;
            land = _land;
            Loaded += Window_Loaded;
        }

        private void EstablishState_Click(object sender, RoutedEventArgs e)
        {
            Country country = CountryModel.EstablishState(player, land, StateColor.Color);
            LandModel.UpdateLandInfo(land, country);
            CountryModel.UpdateCountryCapital(country, land.LandId);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            landModel = new LandModel();
            countryModel = new CountryModel();

            landDescriptionTextBlock.Text = String.Format(Languages.Resources.LocLabelThisLandIsIndependentDescription_Text, land.LandName);
        }

        private void buttonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

﻿using ESO_LangEditorGUI.Controller;
using ESO_LangEditorLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Unicode;
using System.Windows;

namespace ESO_LangEditorGUI.View
{
    /// <summary>
    /// PackToRelase.xaml 的交互逻辑
    /// </summary>
    public partial class PackToRelase : Window
    {
        List<string> modifyList = new List<string>();
        PackAddonFiles packFiles;

        public PackToRelase()
        {
            InitializeComponent();
            CHSorCHT_comboBox.ItemsSource = GeneratingChsOrChtCombox();
            CHSorCHT_comboBox.SelectedIndex = 0;
            packFiles = new PackAddonFiles(this);
        }

        private ObservableCollection<string> GeneratingChsOrChtCombox()
        {
            ObservableCollection<string> chsOrchtList = new ObservableCollection<string>
            {
                "打包简体",
                "打包繁体",
            };

            return chsOrchtList;
        }

        private void Pack_button_Click(object sender, RoutedEventArgs e)
        {
            string esoZhVersion = EsoZhVersion.Text;
            string apiVersion = APIversion_textBox.Text;
            int chsORcht = CHSorCHT_comboBox.SelectedIndex;

            if (CheckField())
                packFiles.ProcessFiles(esoZhVersion, apiVersion);
            else
                MessageBox.Show("汉化版本号与API版本号不得为空！");


            //ModifyFiles();
            //CopyResList();

            //packFiles.ModifyFiles();

        }

        private bool CheckField()
        {
            if (!string.IsNullOrWhiteSpace(EsoZhVersion.Text) & !string.IsNullOrWhiteSpace(APIversion_textBox.Text))
                return true;
            else
                return false;
        }

        private bool CheckResFolder()
        {
            if (Directory.Exists("Resources"))
                return true;
            else
                return false;
        }
    }
}

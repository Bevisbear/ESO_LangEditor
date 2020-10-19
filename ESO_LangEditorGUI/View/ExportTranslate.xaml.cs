﻿using ESO_LangEditorGUI.Model;
using ESO_LangEditorGUI.ViewModels;
using ESO_LangEditorLib;
using ESO_LangEditorLib.Models;
using ESO_LangEditorLib.Models.Client.Enum;
using ESO_LangEditorLib.Services.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace ESO_LangEditorGUI.View
{
    /// <summary>
    /// ExportTranslate.xaml 的交互逻辑
    /// </summary>
    public partial class ExportTranslate : Window
    {
        //private List<LangTextDto> SearchData;
        //private List<LuaUIData> SearchLuaData;
        //private List<UIstrFile> SearchStrData;
        //private ExportTranslateWindowViewModel _dataContext = new ExportTranslateWindowViewModel();

        private bool isLua;

        LangTextRepository db = new LangTextRepository();

        public ExportTranslate()
        {
            InitializeComponent();

            DataContext = new ExportTranslateWindowViewModel(LangDataGrid);

            //textBlock_SelectionInfo.Text = "";
            //ExportTranslate_Button.IsEnabled = false;

            //GeneratingColumns();
            //InitDataGrid();


        }


        private async Task InitDataGrid()
        {

            //textBlock_Info.Text = "正在查找……";

            if (isLua)
            {

                //SearchLuaData = await Task.Run(() => db.GetLangTexts("1", SearchTextType.TranslateStatus));

                //Translated_DataGrid.ItemsSource = SearchLuaData;

                //textBlock_Info.Text = "总计搜索到 " + SearchLuaData.Count + " 条结果。";

                //ExportTranslate_Button.IsEnabled = true;
            }
            else
            {

                //SearchData = await Task.Run(() => db.GetLangTexts("1", SearchTextType.TranslateStatus));

                //Translated_DataGrid.ItemsSource = SearchData;

                //textBlock_Info.Text = "总计搜索到 " + SearchData.Count + " 条结果。";

                //ExportTranslate_Button.IsEnabled = true;
            }
            
        }

        private void ExportTranslate_Button_Click(object sender, RoutedEventArgs e)
        {
            var exportTranslate = new ExportFromDB();
            string exportPath;

            if (isLua)
            {
                //exportPath = exportTranslate.ExportTranslateDB(SearchLuaData);
            }
            else
            {
                //exportPath = exportTranslate.ExportTranslateDB(SearchData);
            }

            //MessageBox.Show(GetTimeToFileName());
            //MessageBox.Show("导出成功，请将 " + exportPath + " 发送给校对或导入人员。", "提示", MessageBoxButton.OK, MessageBoxImage.Information);

            //if (File.Exists(exportPath))
            //{
            //    MessageBox.Show("导出成功，请将 " + exportPath + " 发送给校对或导入人员。", "提示", MessageBoxButton.OK, MessageBoxImage.Information);
            //}
            //else
            //{
            //    MessageBox.Show("导出失败！", "错误", MessageBoxButton.OK, MessageBoxImage.Error);
            //}

        }

        private void GeneratingColumns()
        {
            //Translated_DataGrid.Columns.Clear();

            //if (isLua)
            //{
            //    DataGridTextColumn c1 = new DataGridTextColumn();
            //    c1.Header = "UI ID";
            //    c1.Binding = new Binding("UniqueID");
            //    c1.Width = 200;
            //    Translated_DataGrid.Columns.Add(c1);

            //    DataGridTextColumn c2 = new DataGridTextColumn();
            //    c2.Header = "英文";
            //    c2.Width = 200;
            //    c2.Binding = new Binding("Text_EN");
            //    Translated_DataGrid.Columns.Add(c2);

            //    DataGridTextColumn c3 = new DataGridTextColumn();
            //    c3.Header = "汉化";
            //    c3.Width = 200;
            //    c3.Binding = new Binding("Text_ZH");
            //    Translated_DataGrid.Columns.Add(c3);
            //}
            //else
            //{
            //    DataGridTextColumn c1 = new DataGridTextColumn();
            //    c1.Header = "ID";
            //    c1.Binding = new Binding("UniqueID");
            //    //c1.Width = 50;
            //    Translated_DataGrid.Columns.Add(c1);

            //    DataGridTextColumn c2 = new DataGridTextColumn();
            //    c2.Header = "英文";
            //    //c2.Width = 100;
            //    c2.Binding = new Binding("Text_EN");
            //    Translated_DataGrid.Columns.Add(c2);

            //    DataGridTextColumn c3 = new DataGridTextColumn();
            //    c3.Header = "汉化";
            //    c3.Width = 200;
            //    c3.Binding = new Binding("Text_ZH");
            //    Translated_DataGrid.Columns.Add(c3);
            //}

        }

        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //private void IsStr_checkBox_Checked(object sender, RoutedEventArgs e)
        //{
        //    Translated_DataGrid.ItemsSource = null;

        //    isLua = true;

        //    GeneratingColumns();
        //    InitDataGrid();
        //}

        //private void IsStr_checkBox_Unchecked(object sender, RoutedEventArgs e)
        //{
        //    Translated_DataGrid.ItemsSource = null;

        //    isLua = false;

        //    GeneratingColumns();
        //    InitDataGrid();
        //}
        
    }
}

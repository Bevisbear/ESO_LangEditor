﻿using ESO_Lang_Editor.Model;
using ESO_LangEditorLib;
using ESO_LangEditorLib.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace ESO_Lang_Editor.View
{
    /// <summary>
    /// ImportTranslateDB.xaml 的交互逻辑
    /// </summary>
    public partial class ImportTranslateDB : Window
    {
        private ObservableCollection<string> IDList;
        private List<string> filePath = new List<string>();
        List<string> fileList = new List<string>();
        List<LangText> SearchData = new List<LangText>();
        //private List<UIstrFile> SearchStrData;

        private bool isStr;

        private ParserCsv importDB = new ParserCsv();

        public ImportTranslateDB()
        {
            InitializeComponent();
            GeneratingColumns(false);
        }

        private void GeneratingColumns(bool isStr)
        {
            if (isStr)
            {
                DataGridTextColumn c1 = new DataGridTextColumn();
                c1.Header = "UI ID";
                c1.Binding = new Binding("UI_ID");
                c1.Width = 200;
                TranslateData_dataGrid.Columns.Add(c1);

                DataGridTextColumn c2 = new DataGridTextColumn();
                c2.Header = "英文";
                c2.Width = 200;
                c2.Binding = new Binding("UI_EN");
                TranslateData_dataGrid.Columns.Add(c2);

                DataGridTextColumn c3 = new DataGridTextColumn();
                c3.Header = "汉化";
                c3.Width = 200;
                c3.Binding = new Binding("UI_ZH");
                TranslateData_dataGrid.Columns.Add(c3);
            }
            else
            {
                DataGridTextColumn c1 = new DataGridTextColumn();
                c1.Header = "ID";
                c1.Binding = new Binding("UniqueID");
                //c1.Width = 80;
                TranslateData_dataGrid.Columns.Add(c1);

                DataGridTextColumn c2 = new DataGridTextColumn();
                c2.Header = "英文";
                //c2.Width = 100;
                c2.Binding = new Binding("Text_EN");
                TranslateData_dataGrid.Columns.Add(c2);

                DataGridTextColumn c3 = new DataGridTextColumn();
                c3.Header = "汉化";
                //c3.Width = 300;
                c3.Binding = new Binding("Text_ZH");
                TranslateData_dataGrid.Columns.Add(c3);
            }

        }

        private void Import_button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Multiselect = true
            };

            if (dialog.ShowDialog(this) == true)
            {
                if (dialog.FileName.EndsWith(".LangDB") || dialog.FileName.EndsWith(".db"))
                {
                    foreach (var file in dialog.FileNames)
                    {
                        fileList.Add(System.IO.Path.GetFileName(file));
                        filePath.Add(file);
                    }
                    FileID_listBox.ItemsSource = fileList;
                }
                else
                {
                    MessageBox.Show("仅支持读取 .db 文件！", "提示", MessageBoxButton.OK, MessageBoxImage.Information);
                    FileID_listBox.ItemsSource = "";
                }
                //TotalFiles_textBlock.Text = "共 " + fileList.Count().ToString() + " 个文件，已选择 0 个。";
            }
        }


        private async void IDList_SelectChanged(object sender, SelectionChangedEventArgs e)
        {
            int seletedIndex = FileID_listBox.SelectedIndex;
            string dbPath;

            if (filePath.Count >= 0 && seletedIndex == -1)
            {
                dbPath = filePath.ElementAt(0);
                DataGridSet(dbPath);
            }
            else
            {
                dbPath = filePath.ElementAt(seletedIndex);
                DataGridSet(dbPath);
            }

            if (isStr)
            {
                //var strDB = new UI_StrController();
                //SearchStrData = strDB.FullSearchStrDB(dbPath);

                //foreach (var data in SearchStrData)
                //{
                //    TranslateData_dataGrid.Items.Add(data);
                //}
                ////textBlock_Info.Text = "总计搜索到" + LangSearch.Items.Count + "条结果。";

                //TotalFiles_textBlock.Text = "共 " + filePath.Count().ToString() + " 个文件，已选择 " + FileID_listBox.SelectedItems.Count + " 个。";
            }
            else
            {
                if(dbPath.EndsWith(".db"))
                {
                    var oldTranslate = new ImportOldTranslateDB();

                    SearchData = oldTranslate.FullSearchData(dbPath);
                    TranslateData_dataGrid.ItemsSource = SearchData;
                    textBlock_Info.Text = "共 " + filePath.Count().ToString() + " 个文件，已选择 " + FileID_listBox.SelectedItems.Count + " 个。";
                    textBlock_SelectionInfo.Text = "当前文件共 " + SearchData.Count + " 条文本。";
                }
                else
                {
                    SearchData = await importDB.ExportReaderToListAsync(dbPath);
                    TranslateData_dataGrid.ItemsSource = SearchData;

                    textBlock_Info.Text = "共 " + filePath.Count().ToString() + " 个文件，已选择 " + FileID_listBox.SelectedItems.Count + " 个。";
                    textBlock_SelectionInfo.Text = "当前文件共 " + SearchData.Count + " 条文本。";
                }
                
            }
            


            

        }

        private async void ImportToDB_button_Click(object sender, RoutedEventArgs e)
        {
            var db = new LangDbController();

            if (isStr)
            {
                //var strDB = new UI_StrController();
                //bool isSuccess;
                //List<UIstrFile> importData;

                //foreach (var s in FileID_listBox.SelectedItems)
                //{
                //    //按GUI列表选择的对象数目来读取索引，用索引探测已选定的文件路径来搜索翻译后的数据库文件，然后将所有内容存储到变量中。
                //    importData = strDB.FullSearchStrDB(filePath.ElementAt(FileID_listBox.Items.IndexOf(s)));
                //    isSuccess = strDB.UpdateTextScFromImportDB(importData);;

                //    if (isSuccess)
                //        MessageBox.Show("导入成功！", "成功", MessageBoxButton.OK, MessageBoxImage.Information);
                //    else
                //        MessageBox.Show("导入失败！请检查文件！", "失败", MessageBoxButton.OK, MessageBoxImage.Error);
                //}
            }
            else
            {
                if (filePath.Count >=1)
                {
                    if (ImportAll_Checkbox.IsChecked == true)
                    {
                        foreach (var f in filePath)
                        {
                            SearchData = await importDB.ExportReaderToListAsync(f);
                            TranslateData_dataGrid.ItemsSource = SearchData;

                            textBlock_Total.Text = "正在导入第 " + (filePath.IndexOf(f) + 1) + " 项";

                            OpenFile_button.IsEnabled = false;
                            ImportToDB_button.IsEnabled = false;
                            ImportAll_Checkbox.IsEnabled = false;
                            ImportToDB_button.Content = "导入中……";

                            await db.UpdateLangsZH(SearchData);

                           
                        }
                        textBlock_Total.Text = "导入完毕！";
                    }
                    else
                    {
                        OpenFile_button.IsEnabled = false;
                        ImportToDB_button.IsEnabled = false;
                        ImportAll_Checkbox.IsEnabled = false;
                        ImportToDB_button.Content = "导入中……";

                        int importlines = await db.UpdateLangsZH(SearchData);

                        MessageBox.Show("导入了 " + importlines + " 条翻译");

                    }
                }


                OpenFile_button.IsEnabled = true;
                ImportToDB_button.IsEnabled = true;
                ImportAll_Checkbox.IsEnabled = true;
                ImportToDB_button.Content = "导入";

            }

            

        }

        public void DataGridSet(string DBPath)
        {
            //TranslateData_dataGrid.Columns.Clear();
            //TranslateData_dataGrid.Items.Clear();

            //if (CheckTableIfExist("Pregame", DBPath) || CheckTableIfExist("Client", DBPath))
            //{
            //    isStr = true;
            //    GeneratingColumns(true);
            //}
            //else
            //{
            //    isStr = false;
            //    GeneratingColumns(false);
            //}


        }

        private void CheckIfExist()
        {




        }

        #region  检查表是否存在

        //public bool CheckTableIfExist(string tableName, string DBPath)
        //{
        //    using (SQLiteConnection conn = new SQLiteConnection("Data Source=" + DBPath + ";Version=3;"))
        //    {
        //        conn.Open();
        //        SQLiteCommand cmd = new SQLiteCommand();
        //        cmd.Connection = conn;

        //        try
        //        {
        //            cmd.CommandText = "SELECT name FROM sqlite_master WHERE type='table' AND name='" + tableName + "';";
        //            var table = cmd.ExecuteScalar();

        //            if (table != null && table.ToString() == tableName)
        //                return true;
        //            else
        //                return false;
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new Exception("查询数据表" + tableName + "失败：" + ex.Message);
        //        }


        //    }
        //}

        #endregion
    }
}
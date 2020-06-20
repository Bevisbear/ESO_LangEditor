﻿using ESO_LangEditorLib;
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Data;
using System.Threading.Tasks;
using System.Collections.Immutable;
using ESO_LangEditorLib.Models;
using ESO_Lang_Editor.Model;

namespace ESO_Lang_Editor.View
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        //private MainWindowOption windowsOptions;
        private List<LangText> SearchData;
        private List<LangText> SelectedDatas;
        //LangText SelectedData;

        //UIstrFile SelectedStrData;
        private List<LuaUIData> searchLuaData;
        private List<LuaUIData> SelectedLuaDatas;
        private bool isLua;

        ObservableCollection<string> searchTextInPosition;
        ObservableCollection<string> searchTextType;

        LangDbController db = new LangDbController();

        IDCatalog IDtypeName = new IDCatalog();

        public MainWindow()
        {
            //windowsOptions = new MainWindowOption();
            //DataContext = windowsOptions;
            InitializeComponent();
            SearchTextBox.IsEnabled = false;
            SearchButton.IsEnabled = false;


            SearchTextInPositionInit();
            SearchTextTypeInit();
            

            string version = " v2.2.0";

            Title = "ESO文本查询编辑器" + version;

            textBlock_Info.Text = "暂无查询";
            textBlock_SelectionInfo.Text = "无选择条目";


            //LangSearch.AutoGeneratingColumn += LangDataGridAutoGenerateColumns;

            GeneratingColumns();

            //var db = new SqliteController();
            //db.CreateTable();

            //using (var db = new LangDbContext())
            //{
            //    db.Database.EnsureCreated();
            //}

            UpdatedDB_Check();

        }


        private void GeneratingColumns()
        {
            LangData.Columns.Clear();

            if (isLua)
            {
                DataGridTextColumn c1 = new DataGridTextColumn();
                c1.Header = "UI ID";
                c1.Binding = new Binding("UniqueID");
                c1.Width = 200;
                LangData.Columns.Add(c1);

                DataGridTextColumn c2 = new DataGridTextColumn();
                c2.Header = "英文";
                //c2.Width = 150;
                c2.Binding = new Binding("Text_EN");
                LangData.Columns.Add(c2);

                DataGridTextColumn c3 = new DataGridTextColumn();
                c3.Header = "汉化";
                //c3.Width = 200;
                c3.Binding = new Binding("Text_ZH");
                LangData.Columns.Add(c3);
            }
            else
            {
                DataGridTextColumn c1 = new DataGridTextColumn();
                c1.Header = "文本ID";
                c1.Binding = new Binding("UniqueID");
                c1.Width = 150;
                LangData.Columns.Add(c1);

                DataGridTextColumn c2 = new DataGridTextColumn();
                c2.Header = "英文";
                //c2.Width = 200;
                c2.Binding = new Binding("Text_EN");
                LangData.Columns.Add(c2);

                DataGridTextColumn c3 = new DataGridTextColumn();
                c3.Header = "汉化";
                //c3.Width = 200;
                c3.Binding = new Binding("Text_ZH");
                LangData.Columns.Add(c3);
            }

        }

        private async void SearchButton_Click(object sender, RoutedEventArgs e)
        {

            await SearchDB();

            //if (SearchStr_checkBox.IsChecked == true)
            //{
            //    await SearchDB();
            //}
            //else
            //{
            //    await SearchDB();
            //}

        }


        private void LangSearch_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataGrid datagrid = sender as DataGrid;
            Point aP = e.GetPosition(datagrid);
            IInputElement obj = datagrid.InputHitTest(aP);
            DependencyObject target = obj as DependencyObject;

            if (SelectedDatas != null)
                SelectedDatas.Clear();

            while (target != null)
            {
                if (target is DataGridRow)
                    if (datagrid.SelectedIndex != -1)
                    {
                        if (isLua)
                        {
                            TextEditor textEditor = new TextEditor((LuaUIData)datagrid.SelectedItem,ref IDtypeName);
                            textEditor.Show();
                        }
                        else
                        {
                            //SelectedData = ;
                            TextEditor textEditor = new TextEditor((LangText)datagrid.SelectedItem, ref IDtypeName);
                            textEditor.Show();
                            //MessageBox.Show((LangData)datagrid.SelectedItem);
                        }


                    }

                target = VisualTreeHelper.GetParent(target);
            }
        }

        private void CreateDB_Click(object sender, RoutedEventArgs e)
        {
            var createDBWindow = new CreateDB_ImportCSV();

            createDBWindow.Show();

        }

        private void CsvFileCompare_Click(object sender, RoutedEventArgs e)
        {
            //var compareCsvWindows = new CompareCsvWindow();
            //compareCsvWindows.Show();
        }

        private void CsvCompareWithDB_Click(object sender, RoutedEventArgs e)
        {
            var compareWithDBWindows = new CompareWithDBWindow();
            compareWithDBWindows.Show();
        }

        private void ExportTranslate_Click(object sender, RoutedEventArgs e)
        {
            var exportTranslateWindow = new ExportTranslate();
            exportTranslateWindow.Show();
        }


        private void SearchTextInPositionInit()
        {
            searchTextInPosition = new ObservableCollection<string>();

            searchTextInPosition.Add("包含全文");
            searchTextInPosition.Add("仅包含开头");
            searchTextInPosition.Add("仅包含结尾");

            SearchTextPositionComboBox.ItemsSource = searchTextInPosition;
            SearchTextPositionComboBox.SelectedIndex = 0;
        }

        private void SearchTextTypeInit()
        {
            searchTextType = new ObservableCollection<string>();

            searchTextType.Add("搜编号");
            searchTextType.Add("搜英文");
            searchTextType.Add("搜译文");

            SearchTypeComboBox.ItemsSource = searchTextType;
            SearchTypeComboBox.SelectedIndex = 1;
        }

        private void ExportID_Click(object sender, RoutedEventArgs e)
        {
            //int[] ID = new int[] { 38727365, 198758357, 132143172 };

            ////var export = new ExportFromDB();
            //export.ExportIDArray(ID);
        }

        private void ImportTranslate_Click(object sender, RoutedEventArgs e)
        {
            var importTranslate = new ImportTranslateDB();
            importTranslate.Show();
        }

        private async void SearchTextBlock_EnterPress(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && SearchTextBox.IsFocused)
            {

                await SearchDB();

                //if (SearchStr_checkBox.IsChecked == true)
                //{
                    
                //}
                //else
                //{
                //    await SearchDB();
                //}
            }
        }

        private void LangSearchDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            textBlock_SelectionInfo.Text = "已选择 " + LangData.SelectedItems.Count + " 条文本";

        }

        private void LangSearch_MouseRightUp(object sender, MouseButtonEventArgs e)
        {
            DataGrid grid = (DataGrid)sender;
            var selectedItems = grid.SelectedItems;

            if (isLua)
            {
                if (SelectedLuaDatas != null)
                    SelectedLuaDatas.Clear();

                SelectedLuaDatas = new List<LuaUIData>();

                if (selectedItems.Count > 1)
                {
                    foreach (var selectedItem in selectedItems)
                    {
                        if (selectedItem != null)
                            SelectedLuaDatas.Add((LuaUIData)selectedItem);
                    }

                    TextEditor textEditor = new TextEditor(SelectedLuaDatas, ref IDtypeName);
                    textEditor.Show();
                }
            }
            else
            {
                if (SelectedDatas != null)
                    SelectedDatas.Clear();

                SelectedDatas = new List<LangText>();

                if (selectedItems.Count > 1)
                {
                    foreach (var selectedItem in selectedItems)
                    {
                        if (selectedItem != null)
                            SelectedDatas.Add((LangText)selectedItem);
                    }

                    TextEditor textEditor = new TextEditor(SelectedDatas, ref IDtypeName);
                    textEditor.Show();
                }
            }

        }

        private async Task SearchDB()
        {
            int selectedSearchType = SearchTypeComboBox.SelectedIndex;
            int selectedSearchTextPosition = SearchTextPositionComboBox.SelectedIndex;
            string searchText = SearchTextBox.Text;

            SearchButton.IsEnabled = false;
            SearchButton.Content = "正在搜索……";
            SearchTextBox.IsEnabled = false;

            

            MessageBoxResult result = MessageBoxResult.Cancel;

            if (SearchTextBox.Text == "" || SearchTextBox.Text == " ")
            {
                result = MessageBox.Show("留空将执行全局搜索，即搜索数据库内全部内容，确定要执行吗？", "内存爆炸警告",
                    MessageBoxButton.OKCancel, MessageBoxImage.Warning);
            }
            else
            {
                await GetLangData(selectedSearchType, selectedSearchTextPosition, searchText);

            }

            switch (result)
            {
                case MessageBoxResult.OK:
                    await GetLangData(selectedSearchType, selectedSearchTextPosition, searchText);
                    break;
                case MessageBoxResult.Cancel:
                    break;
            }

            //LangData.ItemsSource = SearchData;
            SearchButton.IsEnabled = true;
            SearchButton.Content = "搜索";
            SearchTextBox.IsEnabled = true;

            textBlock_Info.Text = GetInfoBlockText();
        }

        private async Task GetLangData(int selectedSearchType, int selectedSearchTextPosition, string searchText)
        {
            if(isLua)
            {
                searchLuaData = await Task.Run(() =>
                {
                    var query = db.GetLuaLangsListAsync(selectedSearchType, selectedSearchTextPosition, searchText);
                    return query;
                });
                LangData.ItemsSource = searchLuaData;
            }
            else
            {
                SearchData = await Task.Run(() =>
                {
                    var query = db.GetLangsListAsync(selectedSearchType, selectedSearchTextPosition, searchText);
                    return query;
                });
                LangData.ItemsSource = SearchData;
            }
        }

        private string GetInfoBlockText()
        {
            return "总计搜索到" + LangData.Items.Count + "条结果。";
        }


        private void OpenHelpURLinBrowser(object sender, RoutedEventArgs e)
        {
            GoToSite("https://bevisbear.com/eso-lang-editor-help-doc");
        }

        public static void GoToSite(string url)
        {
            //System.Diagnostics.Process.Start(url);
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void ExportToLang_Click(object sender, RoutedEventArgs e)
        {
            ToLang();
        }

        private void ExportToCHT_Click(object sender, RoutedEventArgs e)
        {
            ToCHT();
        }

        private void DatabaseModiy_Click(object sender, RoutedEventArgs e)
        {
            //var databaseWindow = new DatabaseModifyWindow();

            //databaseWindow.Show();
        }

        private void ToLang()
        {
            var export = new ExportFromDB();
            MessageBoxResult resultExport = MessageBox.Show("输出数据库的文本内容至Text,文件名分别为ID.txt 与Text.txt"
                + Environment.NewLine
                + "其中ID文件为合并ID, Text为内容。"
                + "点击确定开始输出，不导出请点取消。"
                + Environment.NewLine
                + "点击确定之后请耐心等待，输出完毕后会弹出提示!", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Information);
            switch (resultExport)
            {
                case MessageBoxResult.OK:
                    export.ExportAsText();
                    MessageBox.Show("导出完成!", "完成", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
                case MessageBoxResult.Cancel:
                    break;
            }

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"EsoExtractData\EsoExtractData.exe";

            MessageBoxResult resultToLang = MessageBox.Show("将导出的Text文件直接转换为.lang文件，是否导出简体？"
                + Environment.NewLine
                + "点击“是”导出简体，点击“否”导出繁体（需要先转换至繁体中文）"
                + Environment.NewLine
                + "什么都不做请点取消。"
                + Environment.NewLine
                + "点击之后请耐心等待!", "提示", MessageBoxButton.YesNo, MessageBoxImage.Information);

            switch (resultToLang)
            {
                case MessageBoxResult.Yes:
                    startInfo.Arguments = @" -x _tmp\Text.txt -i _tmp\ID.txt -t -o zh.lang";
                    break;
                case MessageBoxResult.No:
                    startInfo.Arguments = @" -x _tmp\Text_cht.txt -i _tmp\ID.txt -t -o zh.lang";
                    break;
            }

            if (resultToLang != MessageBoxResult.Cancel)
            {
                Process proc = new Process
                {
                    StartInfo = startInfo
                };
                proc.Start();
                proc.WaitForExit();

                MessageBox.Show("完成！");

                //System.IO.Directory.Delete("_tmp", true);
            }
        }

        private void ToCHT()
        {
            var export = new ExportFromDB();

            export.ExportAsText();


            ProcessStartInfo startOpenCCInfo = new ProcessStartInfo();
            startOpenCCInfo.FileName = @"opencc\opencc.exe";
            startOpenCCInfo.Arguments = @" -i _tmp\Text.txt -o _tmp\Text_cht.txt -c opencc\s2twp.json";

            Process opencc = new Process();
            opencc.StartInfo = startOpenCCInfo;
            opencc.Start();
            opencc.WaitForExit();



            ProcessStartInfo startEEDInfo = new ProcessStartInfo();
            startEEDInfo.FileName = @"EsoExtractData\EsoExtractData.exe";
            startEEDInfo.Arguments = @" -x _tmp\Text_cht.txt -i _tmp\ID.txt -t -o zht.lang";

            Process eed = new Process();
            eed.StartInfo = startEEDInfo;
            eed.Start();
            eed.WaitForExit();


            MessageBox.Show("完成！");
        }


        private async Task UpdatedDB_Check()
        {
            string csvDataUpdatePath = @"Data\LangData.update";


            #region  检查CSV数据库更新
            if (File.Exists(@"Data\LangData.db") && File.Exists(csvDataUpdatePath))
            {
                var db = new LangDbController();
                SearchData = await db.GetLangsListAsync(5, 0, "1");
                searchLuaData = await db.GetLuaLangsListAsync(5, 0, "1");

                if (SearchData.Count >= 1)
                {
                    var exportTranslate = new ExportFromDB();
                    string exportPath = exportTranslate.ExportTranslateDB(SearchData);

                    if (File.Exists(exportPath))
                    {
                        MessageBox.Show("发现了新版数据库，但你本地已查询到翻译过但未导出的文本，现已将翻译过的文本导出。"
                            + Environment.NewLine
                            + "请将 " + exportPath + " 发送给校对或导入人员，你自己也请使用导入翻译功能导入到更新的数据库！",
                            "提示", MessageBoxButton.OK, MessageBoxImage.Information);

                    }
                    else
                    {
                        MessageBox.Show("发现了新版数据库，但你本地已查询到翻译过但未导出的文本，但导出失败！", "错误", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                if (searchLuaData.Count >= 1)
                {
                    var exportTranslate = new ExportFromDB();
                    string exportPath = exportTranslate.ExportTranslateDB(searchLuaData);

                    if (File.Exists(exportPath))
                    {
                        MessageBox.Show("发现了新版数据库，但你本地已查询到翻译过但未导出的文本，现已将翻译过的文本导出。"
                            + Environment.NewLine
                            + "请将 " + exportPath + " 发送给校对或导入人员，你自己也请使用导入翻译功能导入到更新的数据库！",
                            "提示", MessageBoxButton.OK, MessageBoxImage.Information);

                    }
                    else
                    {
                        MessageBox.Show("发现了新版数据库，但你本地已查询到翻译过但未导出的文本，但导出失败！", "错误", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }

                GC.Collect();
                GC.WaitForPendingFinalizers();
                File.Delete(@"Data\LangData.db");
                File.Move(csvDataUpdatePath, @"Data\LangData.db");
                File.Delete(csvDataUpdatePath);

                SearchTextBox.IsEnabled = true;
                SearchButton.IsEnabled = true;

            }
            else if (File.Exists(@"Data\LangData.db"))
            {
                SearchTextBox.IsEnabled = true;
                SearchButton.IsEnabled = true;
            }
            else if (File.Exists(csvDataUpdatePath))
            {
                File.Move(csvDataUpdatePath, @"Data\LangData.db");
                File.Delete(csvDataUpdatePath);

                SearchTextBox.IsEnabled = true;
                SearchButton.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("无法找到数据库文件！", "错误", MessageBoxButton.OK, MessageBoxImage.Error);
                SearchTextBox.IsEnabled = false;
                SearchButton.IsEnabled = false;
            }
            #endregion

        }

        //private void str_Click(object sender, RoutedEventArgs e)
        //{
        //    var str = new UIstrFile();
        //    //str.createDB();
        //}


        private void SearchStr_checkBox_Checked(object sender, RoutedEventArgs e)
        {

            if(LangData.Items.Count >= 1)
            {
                LangData.ItemsSource = null;

                isLua = true;
                GeneratingColumns();
            }
            else
            {
                isLua = true;
                GeneratingColumns();
            }

        }

        private void SearchStr_checkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            if (LangData.Items.Count >= 1)
            {
                LangData.ItemsSource = null;

                isLua = false;
                GeneratingColumns();
            }
            else
            {
                isLua = false;
                GeneratingColumns();
            }
        }


        private void ExportToStr_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("导出UI STR内容"
                + Environment.NewLine
                + "点击“是”导出，点击“否”什么都不做。"
                + Environment.NewLine
                + "点击之后请耐心等待!", "提示", MessageBoxButton.YesNo, MessageBoxImage.Information);

            var strExport = new ExportFromDB();

            switch (result)
            {
                case MessageBoxResult.Yes:
                    strExport.ExportStrDB();
                    break;
                case MessageBoxResult.No:
                    break;

            }
        }
    }
}

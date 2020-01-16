﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ESO_Lang_Editor.Model;

namespace ESO_Lang_Editor.View
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowOption windowsOptions;
        List<LangSearchModel> SearchData;

        public MainWindow()
        {
            windowsOptions = new MainWindowOption();
            DataContext = windowsOptions;
            InitializeComponent();
            textBlock_Info.Text = "";
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            if (LangSearch.Items.Count > 1)
                SearchData = null;
                LangSearch.Items.Clear();

            SearchData = windowsOptions.SearchLang(SearchCheck());

            foreach (var data in SearchData)
            {
                LangSearch.Items.Add(data);
            }
            textBlock_Info.Text = "总计搜索到" + LangSearch.Items.Count + "条结果。";
        }

        private void LangSearch_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DataGrid datagrid = sender as DataGrid;
            Point aP = e.GetPosition(datagrid);
            IInputElement obj = datagrid.InputHitTest(aP);
            DependencyObject target = obj as DependencyObject;


            while (target != null)
            {
                if (target is DataGridRow)
                    if (datagrid.SelectedIndex != -1 )
                    {
                        LangSearchModel data = (LangSearchModel)datagrid.SelectedItem;
                        TextEditor textEditor = new TextEditor(data);
                        textEditor.Show();
                        //MessageBox.Show(data.Text_SC);

                    }

                target = VisualTreeHelper.GetParent(target);
            }
        }
        private string SearchCheck()
        {
            //获得已选择的搜索文本所在位置， 默认selectedSearchTextPosition = 0
            int selectedSearchTextPosition = SearchTextPositionComboBox.SelectedIndex;
            var selectedSearchType = SearchTypeComboBox.SelectedIndex;
            string searchText = SearchTextBox.Text;
            string SearchContent;

            switch (selectedSearchTextPosition)
            {
                case 0:
                    SearchContent = "%" + searchText + "%";   //全文搜索
                    break;
                case 1:
                    SearchContent = searchText + "%";         //仅在开头
                    break;
                case 2:
                    SearchContent = "%" + searchText;         //仅在结尾
                    break;
                default:
                    SearchContent = "%" + searchText + "%";   //出错直接全文搜索
                    break;
            }
            return SearchContent;
        }

        private void CsvFileCompare_Click(object sender, RoutedEventArgs e)
        {
            var compareCsvWindows = new CompareCsvWindow();
            compareCsvWindows.Show();
        }

        private void CsvCompareWithDB_Click(object sender, RoutedEventArgs e)
        {
            var compareWithDBWindows = new CompareWithDBWindow();
            compareWithDBWindows.Show();
        }
    }
}

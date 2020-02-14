﻿using ESO_Lang_Editor.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ESO_Lang_Editor.View
{
    /// <summary>
    /// DatabaseModifyWindow.xaml 的交互逻辑
    /// </summary>
    public partial class DatabaseModifyWindow : Window
    {
        ObservableCollection<string> addFieldType;
        

        public DatabaseModifyWindow()
        {
            InitializeComponent();

            AddFieldTypeComboxInit();
        }

        private void AddFieldTypeComboxInit()
        {
            addFieldType = new ObservableCollection<string>();

            addFieldType.Add("int");
            addFieldType.Add("string");

            InputType_comboBox.ItemsSource = addFieldType;
            InputType_comboBox.SelectedIndex = 0;

        }

        private void AddField_button_Click(object sender, RoutedEventArgs e)
        {
            string fieldName = FieldNameInput_textBox.Text;
            string initContent = InitContentInput_textBox.Text;
            int seletedType = InputType_comboBox.SelectedIndex;

            var DBFile = new SQLiteController();


            if (fieldName != "" && !fieldName.Contains(" ") && initContent != "" && !initContent.Contains(" "))
            {
                if (seletedType == 0)
                {
                    if (IsTextAllowed(initContent))
                    {
                        DBFile.FieldAdd(fieldName, "int", System.Convert.ToInt32(initContent));
                        Console.WriteLine("字段名：{0}, 类型：int, 初始内容：{1}，创建成功。", fieldName, initContent);
                    }
                    else
                    {
                        MessageBox.Show("非 int 类型的初始内容请选择 string，如为 int 请仅输入半角数字！", "警告",
                        MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
                else
                {
                    DBFile.FieldAdd(fieldName, "string", initContent);
                    Console.WriteLine("字段名：{0}, 类型：string, 初始内容：{1}，创建成功。", fieldName, initContent);
                }
            }
            else
            {
                MessageBox.Show("两个输入框都不能为空或包含空格！", "警告",
                        MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            

        }

        private static readonly Regex _regex = new Regex("[^0-9.-]+");
        private static bool IsTextAllowed(string text)
        {
            return !_regex.IsMatch(text);
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Windows;
using ESO_LangEditorGUI.ViewModels;
using ESO_LangEditorModels;

namespace ESO_LangEditorGUI.View
{
    /// <summary>
    /// TextEditor_SearchReplace.xaml 的交互逻辑
    /// </summary>
    public partial class TextEditor_SearchReplace : Window
    {
        //List<LangTextDto> LangList;
       // ListSearchReplace searchReplace = new ListSearchReplace();
        //TextEditor textWindow;

        public TextEditor_SearchReplace(List<LangTextDto> list)
        {
            InitializeComponent();
            //LangList = list;
            DataContext = new SearchReplaceViewModel(list, LangDataGrid);
            //textWindow = window;
            //CheckBox_OnlyMatchWord.IsChecked = true;
        }

       
        
    }
}

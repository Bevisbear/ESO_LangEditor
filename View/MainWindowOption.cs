﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Data;
using ESO_Lang_Editor.Model;

namespace ESO_Lang_Editor.View
{
    public class MainWindowOption
    {

        private string searchTextInPosition = "包含全文";
        private string searchType = "搜英文";

        //public ICollectionView LangData { get; private set; }

        public string SearchTextInPosition
        {
            
            get { return searchTextInPosition; }
            set
            {
                searchTextInPosition = value;
                OnPropertyChanged(nameof(SearchTextInPosition));
            }
        }

        public string SearchType
        {

            get { return searchType; }
            set
            {
                searchType = value;
                OnPropertyChanged(nameof(SearchType));
            }
        }

        public List<LangSearchModel> SearchLang(string SearchBarText)
        {
            var DBFile = new SQLiteController();

            var da1 = DBFile.SearchData(SearchBarText);

            return da1;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}

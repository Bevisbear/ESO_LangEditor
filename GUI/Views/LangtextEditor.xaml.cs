﻿using Core.Models;
using GUI.Views.UserControls;
using GUI.EventAggres;
using GUI.ViewModels;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;

namespace GUI.Views
{
    /// <summary>
    /// LangtextEditor.xaml 的交互逻辑
    /// </summary>
    public partial class LangtextEditor : Window
    {
        public LangtextEditor(LangTextDto langTextDto)
        {
            InitializeComponent();

            var vm = DataContext as LangtextEditorViewModel;
            vm.Load(langTextDto);

            //Closed += TextEditorWindow_Closed;

            vm.OnRequestClose += (s, e) => Close();

        }

        public LangtextEditor(List<LangTextDto> langTextDtoList)
        {
            InitializeComponent();

            var vm = DataContext as LangtextEditorViewModel;
            vm.Load(langTextDtoList);

            vm.OnRequestClose += (s, e) => Close();

            AddHandler(UC_LangDataGrid.DataGridSelectionChangedEvent,
                new RoutedEventHandler(DataGridSelectionChangedEvent));
        }

        private void DataGridSelectionChangedEvent(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as LangtextEditorViewModel;
            DataGridSelectedItemEventArgs args = (DataGridSelectedItemEventArgs)e;

            var langtextDto = args.LangTextDto;
            vm.SetCurrentItemFromList(langtextDto);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            var vm = DataContext as LangtextEditorViewModel;
            if (vm.LangTextZh != vm.CurrentLangText.TextZh)
            {
                base.OnClosing(e);
                MessageBoxResult result = MessageBox.Show("确定要关闭窗口？当前文本修改后未保存。", "关闭确认", MessageBoxButton.OKCancel, MessageBoxImage.Question);
                e.Cancel = result == MessageBoxResult.Cancel;
            }
            else
            {
                base.OnClosing(e);
            }

        }

    }
}

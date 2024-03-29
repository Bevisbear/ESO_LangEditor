﻿using GUI.Command;
using GUI.EventAggres;
using GUI.Services;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace GUI.ViewModels
{
    public class MainMenuListViewModel : BindableBase
    {
        private MenuItem _mainMenuList;
        private List<string> _roleList = new List<string>();
        private ObservableCollection<MenuItemContent> _topMenu;

        public ObservableCollection<MenuItemContent> TopMenu
        {
            get => _topMenu;
            set => SetProperty(ref _topMenu, value);
        }

        private IEventAggregator _ea;
        //private IBackendService _backendService;

        public Window WindowLink(string windowClassName)
        {
            Assembly windowClass = GetType().Assembly;

            object window = windowClass.CreateInstance(windowClassName);
            if (window == null)
            {
                throw new TypeLoadException("Unable to create window: " + windowClassName);
            }
            return (Window)window;
        }

        public MainMenuListViewModel(IEventAggregator ea/*, IBackendService backendService*/)
        {
            _ea = ea;
            //_backendService = backendService;
            //_ea.GetEvent<RoleListUpdateEvent>().Subscribe(UpdateRoleList);
            LoadMemu();
        }

        //private void UpdateRoleList(List<string> roleList)
        //{
        //    if (_roleList != roleList)
        //    {
        //        _roleList = roleList;
        //        LoadMemu();
        //    }
        //    foreach (var role in roleList)
        //    {
        //        Debug.WriteLine(role);
        //    }
        //}

        private void LoadMemu()
        {
            string windowNamespace = "GUI.Views.";
            TopMenu = null;

            TopMenu = new ObservableCollection<MenuItemContent>
            {
                new MenuItemContent
                {
                    Header="游戏文件相关", ChildMenuItems=new ObservableCollection<MenuItemContent>
                    {
                        //new MenuItemContent
                        //{
                        //    Header = "导入翻译文本",
                        //    Command = new ExcuteViewModelMethod(OpenWindowByICommand),
                        //    CommandParameter = windowNamespace + "ImportTranslate",
                        //},
                        new MenuItemContent
                        {
                            Header = "CSV和Lua与数据库对比",
                            Command = new ExcuteViewModelMethod(OpenWindowByICommand),
                            CommandParameter = windowNamespace + "CompareWithDBWindow",
                            //Visible = RoleToVisibility("Admin"),
                        },

                        new MenuItemContent {
                            Header = "导出为游戏文件",
                            Command = new ExcuteViewModelMethod(OpenWindowByICommand),
                            CommandParameter = windowNamespace + "PackToRelase",
                            //Visible = RoleToVisibility("Editor"),
                        }
                    }

                },
                //new MenuItemContent
                //{
                //    Header="导出", ChildMenuItems=new ObservableCollection<MenuItemContent>
                //    {
                //        //new MenuItemContent   //导出译文窗口参数
                //        //{
                //        //    Header = "导出已翻译内容",                                        //菜单标题
                //        //    Command = new ExcuteViewModelMethod(OpenWindowByICommand),      //菜单Command 打开窗口
                //        //    CommandParameter = windowNamespace + "ExportTranslate",  //窗口名 - 必须包含命名空间
                //        //},
                        
                //        //new MenuItemContent
                //        //{
                //        //    Header = "导出文本至.lang",
                //        //    Command = new ExcuteViewModelMethod(ExportLang),
                //        //    //CommandParameter = "GUI.Views.ExportTranslate"
                //        //},
                //        //new MenuItemContent
                //        //{
                //        //    Header = "导出UI Str内容",
                //        //    Command = new ExcuteViewModelMethod(ExportLuaToStr), 
                //        //    //CommandParameter = "GUI.Views.ExportTranslate"
                //        //},
                //    }

                //},
                //new MenuItemContent
                //{
                //    Header="高级", ChildMenuItems=new ObservableCollection<MenuItemContent>
                //    {

                //        new MenuItemContent {
                //            Header = "审核待通过文本",
                //            Command = new ExcuteViewModelMethod(OpenWindowByICommand),
                //            CommandParameter = windowNamespace + "LangTextReviewWindow",
                //            Visible = RoleToVisibility("Editor"),
                //        },

                //        new MenuItemContent {
                //            Header = "编辑ID类型名称",
                //            Command = new ExcuteViewModelMethod(OpenWindowByICommand),
                //            CommandParameter = windowNamespace + "LangTypeCatalogWindow",
                //            //Visible = RoleToVisibility("Editor"),
                //        },
                //        new MenuItemContent {
                //            Header = "审核ID类型名称",
                //            Command = new ExcuteViewModelMethod(OpenWindowByICommand),
                //            CommandParameter = windowNamespace + "LangTypeCatalogReviewWindow",
                //            //Visible = RoleToVisibility("Editor"),
                //        },
                //        new MenuItemContent {
                //            Header = "游戏API与版本号",
                //            Command = new ExcuteViewModelMethod(OpenWindowByICommand),
                //            CommandParameter = windowNamespace + "NewGameVersionWindow",
                //            //Visible = RoleToVisibility("Editor"),
                //        },

                //    }

                //},
                //new MenuItemContent
                //{
                //    Header="用户", ChildMenuItems=new ObservableCollection<MenuItemContent>
                //    {
                //        new MenuItemContent {
                //            Header = "用户角色编辑",
                //            Command = new ExcuteViewModelMethod(OpenWindowByICommand),
                //            CommandParameter = windowNamespace + "UserRoleEditor",
                //            Visible = RoleToVisibility("Admin"),
                //        },
                //        new MenuItemContent {
                //            Header="资料修改",
                //            Command = new ExcuteViewModelMethod(OpenWindowByICommand),
                //            CommandParameter = windowNamespace + "UserProfileSetting",
                //        },

                //        new MenuItemContent {
                //            Header = "登出",
                //            Command = new ExcuteViewModelMethod(LogoutByICommand),
                //            //CommandParameter = windowNamespace + "UserRoleEditor",
                //            //Visible = RoleToVisibility("Admin"),
                //        },

                //        //new MenuItemContent { Header = "服务器线路" , ChildMenuItems=new ObservableCollection<MenuItemContent>
                //        //{
                //        //    new MenuItemContent { Header = "IKDC2(IPv4)" },
                //        //    new MenuItemContent { Header = "IKDC2(IPv6)" }
                //        //}},
                //        //new MenuItemContent {Header="导出UI Str内容" },
                //        //new MenuItemContent {Header="一键发布" }
                //    }

                //},
                //new MenuItemContent
                //{
                //    Header="资料修改",
                //    Command = new ExcuteViewModelMethod(OpenWindowByICommand),
                //    CommandParameter = windowNamespace + "UserProfileSetting",

                //},
                new MenuItemContent
                {
                    Header="帮助", ChildMenuItems=new ObservableCollection<MenuItemContent>
                    {
                        new MenuItemContent
                        {
                            Header = "使用说明",
                            Command = new ExcuteViewModelMethod(GoToSite),
                            CommandParameter = "https://langeditor-doc.bevisbear.com"
                        }
                    }

                },
            };
        }

        //private bool isRole(string roleName)
        //{
        //    return _roleList.Contains(roleName);
        //}

        //private Visibility RoleToVisibility(string roleName)
        //{
        //    return _roleList.Contains(roleName) ? Visibility.Visible : Visibility.Collapsed;
        //}

        private void OpenWindowByICommand(object o)
        {
            var window = WindowLink(o.ToString());
            window.Owner = Application.Current.MainWindow;
            window.Show();
        }

        private void LogoutByICommand(object o)
        {
            _ea.GetEvent<LogoutEvent>().Publish();
        }

        public static void GoToSite(object urlo)
        {
            string url = urlo as string;
            //System.Diagnostics.Process.Start(url);
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            };
            Process.Start(psi);
        }

    }


    public class MenuItemContent : BindableBase
    {
        public ObservableCollection<MenuItemContent> ChildMenuItems { get; set; }
        private string _header;
        private ICommand _command;
        private object _commandParameter;
        private bool _isVisible = true;
        private Visibility _visible = Visibility.Visible;

        public string Header
        {
            get => _header;
            set => SetProperty(ref _header, value);
        }

        public ICommand Command
        {
            get => _command;
            set => SetProperty(ref _command, value);
        }

        public object CommandParameter
        {
            get => _commandParameter;
            set => SetProperty(ref _commandParameter, value);
        }

        public bool IsVisible
        {
            get => _isVisible;
            set => SetProperty(ref _isVisible, value);
        }

        public Visibility Visible
        {
            get => _visible;
            set => SetProperty(ref _visible, value);
        }


    }


}

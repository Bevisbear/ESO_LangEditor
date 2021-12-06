﻿using Core.Models;
using GUI;
using GUI.Command;
using GUI.EventAggres;
using GUI.Services;
using MaterialDesignThemes.Wpf;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace GUI.ViewModels
{
    public class LangtextEditorViewModel : BindableBase
    {
        private LangTextDto _currentLangText;
        private string _langtextInfo;
        private string _langTextZh;
        private Visibility _dataListVisbility;
        private ObservableCollection<LangTextDto> _gridData;
        private LangTextDto _gridSelectedItem;
        private string _mdNotifyContent;
        private bool _isInReview;
        private Visibility _jpVisibility = Visibility.Collapsed;
        private string _langIdTypeName;
        private string _langGameVersionName;
        private string _langZhModifyTime;

        public LangTextDto CurrentLangText
        {
            get => _currentLangText;
            set => SetProperty(ref _currentLangText, value);
        }

        public string LangTextZh
        {
            get => _langTextZh;
            set => SetProperty(ref _langTextZh, value);
        }

        public Visibility DataListVisbility
        {
            get => _dataListVisbility;
            set => SetProperty(ref _dataListVisbility, value);
        }

        public ObservableCollection<LangTextDto> GridData
        {
            get => _gridData;
            set => SetProperty(ref _gridData, value);
        }

        public LangTextDto GridSelectedItem
        {
            get => _gridSelectedItem;
            set => SetProperty(ref _gridSelectedItem, value);
        }

        public string MdNotifyContent
        {
            get => _mdNotifyContent;
            set => SetProperty(ref _mdNotifyContent, value);
        }

        public bool IsInReview
        {
            get => _isInReview;
            set => SetProperty(ref _isInReview, value);
        }

        public bool IsDisplayJp
        {
            get => App.LangConfig.AppSetting.IsDisplayJp;
            set => App.LangConfig.AppSetting.IsDisplayJp = value;
        }

        public Visibility JpVisibility
        {
            get => _jpVisibility;
            set => SetProperty(ref _jpVisibility, value);
        }

        public string LangIdTypeName
        {
            get => _langIdTypeName;
            set => SetProperty(ref _langIdTypeName, value);
        }

        public string LangGameVersionName
        {
            get => _langGameVersionName;
            set => SetProperty(ref _langGameVersionName, value);
        }

        public string LangZhModifyTime
        {
            get => _langZhModifyTime;
            set => SetProperty(ref _langZhModifyTime, value);
        }

        public Visibility ReasonForVisibility => Visibility.Collapsed;

        public bool AutoQueryLangTextInReview
        {
            get => App.LangConfig.AppSetting.IsAutoQueryLangTextInReview;
            set => App.LangConfig.AppSetting.IsAutoQueryLangTextInReview = value;
        }

        public string LangtextInfo
        {
            get => _langtextInfo;
            set
            {
                SetProperty(ref _langtextInfo, "ID：" + CurrentLangText.TextId + "，类型：" + /*_ba +*/ "，"
                   + GetVersionName() + " 版本加入或修改，"
                   + CompareEditTime());
            }
        }

        public ExcuteViewModelMethod LangEditorSaveButton => new ExcuteViewModelMethod(SaveCurrentToDb);
        public SnackbarMessageQueue EditorMessageQueue { get; }
        public event EventHandler OnRequestClose;

        private IEventAggregator _ea;
        private ILangTextRepoClient _langTextRepoClient;
        private ILangTextAccess _langTextAccess;
        private IBackendService _backendService;

        public LangtextEditorViewModel(IEventAggregator ea, ILangTextRepoClient langTextRepoClient, 
            ILangTextAccess langTextAccess, IBackendService backendService)
        {
            _ea = ea;
            _langTextRepoClient = langTextRepoClient;
            _langTextAccess = langTextAccess;
            _backendService = backendService;
            EditorMessageQueue = new SnackbarMessageQueue();

            _ea.GetEvent<DataGridSelectedItemInEditor>().Subscribe(SetCurrentItemFromList);

        }

        public async void Load(LangTextDto langTextDto)
        {
            CurrentLangText = langTextDto;
            LangTextZh = langTextDto.TextZh;
            LangtextInfo = "update";
            DataListVisbility = Visibility.Collapsed;

            if (langTextDto.LangtextInReivewId != null)
            {
                IsInReview = true;
            }
        }

        public void Load(List<LangTextDto> langTextDtoList)
        {
            GridData = new ObservableCollection<LangTextDto>(langTextDtoList);

            if (GridData.Count > 1)
            {
                CurrentLangText = GridData.ElementAt(0);
                GridSelectedItem = CurrentLangText;
                DataListVisbility = Visibility.Visible;
            }
            LangTextZh = CurrentLangText.TextZh;
            LangtextInfo = "update";
        }

        private string CompareEditTime()
        {
            string resultWord;

            if (CurrentLangText.EnLastModifyTimestamp > CurrentLangText.ZhLastModifyTimestamp)
            {
                resultWord = "英文已修改，翻译可能不匹配或待译。";
            }
            else
            {
                resultWord = "文本可能已翻译或为初始化内容。";
            }

            return resultWord;
        }

        private async Task<string> GetVersionName()
        {
            var gameVersion = await _langTextRepoClient.GetGameVersion(CurrentLangText.GameApiVersion);

            return gameVersion.Version_ZH;

            //return App.gameUpdateVersionName.GetVersionName(CurrentLangText.UpdateStats);
        }

        //private string GetIdCategory()
        //{
        //    return App.iDCatalog.GetCategory(CurrentLangText.IdType);
        //}

        private async void SaveCurrentToDb(object o)
        {
            //var user = App.User;

            if (App.User == null)
            {
                MessageBox.Show("用户无效，保存失败！");
            }
            else
            {
                if (LangTextZh != CurrentLangText.TextZh)
                {
                    var time = DateTime.UtcNow;
                    var langtextUpdateZh = new LangTextForUpdateZhDto
                    {
                        Id = CurrentLangText.Id,
                        TextZh = LangTextZh,
                        ZhLastModifyTimestamp = time,
                        UserId = App.User.Id,
                    };

                    if (await _langTextRepoClient.UpdateLangtextZh(langtextUpdateZh))
                    {
                        CurrentLangText.TextZh = LangTextZh;

                        if (GridData != null && GridData.Count > 1)
                        {
                            //var removeitem = GridData.Single(l => l.Id == CurrentLangText.Id);
                            GridData.Remove(GridData.Single(l => l.Id == CurrentLangText.Id));

                            if (GridData.ElementAtOrDefault(0) != null)
                            {
                                SetCurrentItemFromList(GridData.ElementAtOrDefault(0));
                            }
                        }
                        else
                        {

                            OnRequestClose(this, new EventArgs());
                            _ea.GetEvent<SendMessageQueueToMainWindowEventArgs>().Publish("文本ID：" + CurrentLangText.TextId + " 保存成功！"
                                + "需重新搜索才会刷新表格。");
                            _ea.GetEvent<UploadLangtextZhUpdateEvent>().Publish(langtextUpdateZh);
                        }

                    }
                    else
                    {
                        MdNotifyContent = "文本保存失败！";
                    }
                }
                else
                {
                    EditorMessageQueue.Enqueue("哦豁，没检测到和原来的文本有什么区别，所以没保存。");
                }
            }

        }

        public async void SetCurrentItemFromList(LangTextDto langTextDto)
        {
            if (langTextDto != null)
            {
                Debug.WriteLine(langTextDto.TextZh);

                CurrentLangText = langTextDto;
                GridSelectedItem = langTextDto;
                LangTextZh = CurrentLangText.TextZh;
                LangtextInfo = "update";

                if(langTextDto.LangtextInReivewId != null)
                {
                    IsInReview = true;
                }
            }


        }

        //private async Task QueryCurrentLangFromInReview()
        //{
        //    if (AutoQueryLangTextInReview)
        //    {
        //        var lang = await _langTextAccess.GetLangTextFromReview(CurrentLangText.Id);

        //        if (lang != null)
        //        {
        //            IsInReview = true;
        //        }
        //    }
        //}

    }
}

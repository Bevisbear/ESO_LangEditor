﻿using ESO_LangEditor.Core.EnumTypes;
using ESO_LangEditor.Core.Models;
using ESO_LangEditor.GUI.NetClient;
using ESO_LangEditorGUI.EventAggres;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ESO_LangEditorGUI.Services.AccessServer
{
    public class AccountService
    {
        IEventAggregator _ea;

        public AccountService(IEventAggregator ea)
        {
            _ea = ea;
        }

        public void LoginCheck()
        {
            _ea.GetEvent<ConnectProgressString>().Publish("正在登录……");
            _ea.GetEvent<ConnectStatusChangeEvent>().Publish(ClientConnectStatus.Connecting);

            if (App.LangConfig.UserRefreshToken != "" & App.LangConfig.UserRefreshToken != "")
            {
                LoginByToken();
            }

            if (App.LangConfig.UserRefreshToken == "" || App.LangConfig.UserRefreshToken == "")
            {
                _ea.GetEvent<LoginRequiretEvent>().Publish();
            }
        }


        public async Task<bool> Login(LoginUserDto loginUserDto)
        {
            ApiAccess apiclient = new ApiAccess();

            try
            {
                var tokenDto = await apiclient.GetLoginToken(loginUserDto);

                if (tokenDto != null)
                {
                    SaveToken(tokenDto);
                    _ea.GetEvent<ConnectStatusChangeEvent>().Publish(ClientConnectStatus.Login);
                    _ea.GetEvent<ConnectProgressString>().Publish("登录成功");
                    GetUserRoleFromToken(tokenDto.AuthToken);
                    return true;
                }
                else
                {
                    return false;
                }
                    
            }
            catch(HttpRequestException ex)
            {
                _ea.GetEvent<ConnectProgressString>().Publish(ex.Message);
                _ea.GetEvent<ConnectStatusChangeEvent>().Publish(ClientConnectStatus.ConnectError);

                return false;
            }
            
                
        }

        public async void LoginByToken()
        {
            ApiAccess apiclient = new ApiAccess();

            try
            {
                var tokenDto = await apiclient.GetRefreshedTokenByCurrentToken(new TokenDto
                {
                    AuthToken = App.LangConfig.UserAuthToken,
                    RefreshToken = App.LangConfig.UserRefreshToken,
                });

                if (tokenDto != null)
                {
                    SaveToken(tokenDto);
                    _ea.GetEvent<ConnectStatusChangeEvent>().Publish(ClientConnectStatus.Login);
                    _ea.GetEvent<ConnectProgressString>().Publish("登录成功");
                    GetUserRoleFromToken(tokenDto.AuthToken);
                }
                else
                {
                    _ea.GetEvent<LoginRequiretEvent>().Publish();
                }
                    
            }
            catch(HttpRequestException ex)
            {
                _ea.GetEvent<ConnectProgressString>().Publish(ex.Message);
                _ea.GetEvent<ConnectStatusChangeEvent>().Publish(ClientConnectStatus.ConnectError);
            }
            
        }

        public List<string> GetUserRoleFromToken(string token)
        {
            string userRoleClaim = "http://schemas.microsoft.com/ws/2008/06/identity/claims/role";

            var jsontoken = new JwtSecurityTokenHandler().ReadJwtToken(token);
            var roleList = jsontoken.Claims.Where(claim => claim.Type == userRoleClaim)
                .Select(c => c.Value).ToList();

            foreach(var role in roleList)
            {
                Debug.WriteLine(role);
            }

            _ea.GetEvent<RoleListUpdateEvent>().Publish(roleList);

            return roleList;
        }

        private void SaveToken(TokenDto tokenDto)
        {
            var username = GetUserNameFromToken(tokenDto.AuthToken);
            var config = App.LangConfig;

            config.UserAuthToken = tokenDto.AuthToken;
            config.UserRefreshToken = tokenDto.RefreshToken;
            config.UserName = username;

            App.LangConfig.UserAuthToken = tokenDto.AuthToken;
            App.LangConfig.UserRefreshToken = tokenDto.RefreshToken;

            AppConfigClient.Save(config);
        }

        private string GetUserNameFromToken(string token)
        {
            string userNameClaim = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name";

            var jsontoken = new JwtSecurityTokenHandler().ReadJwtToken(token);
            var userName = jsontoken.Claims.First(claim => claim.Type == userNameClaim).Value;
            
            return userName;
        }


    }
}

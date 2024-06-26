﻿using CommunitySite.Components.Dialogs;
using CommunitySite.Data.ViewModels;
using MudBlazor;

namespace CommunitySite.Services.UserViewServices
{
    public class UserViewService : IUserViewService
    {
        private readonly IDialogService _dialogService;

        public UserViewService(IDialogService dialogService)
        {
            _dialogService = dialogService;
        }

        public async Task UpdateUserDialog(UserViewModel user)
        {
            var parameters = new DialogParameters
            {
                ["userViewModel"] = user
            };

            var dialog = await _dialogService.ShowAsync<ProfileDialog>("Edit user", parameters);
            await dialog.Result;
        }
    }
}

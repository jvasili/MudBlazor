﻿using System;
using Microsoft.AspNetCore.Components;

namespace MudBlazor.Dialog
{
    public interface IDialogService
    {
        IDialogReference Show<TComponent>() where TComponent : ComponentBase;

        IDialogReference Show<TComponent>(string title) where TComponent : ComponentBase;

        IDialogReference Show<TComponent>(string title, DialogOptions options) where TComponent : ComponentBase;

        IDialogReference Show<TComponent>(string title, DialogParameters parameters) where TComponent : ComponentBase;

        IDialogReference Show<TComponent>(string title, DialogParameters parameters = null, DialogOptions options = null) where TComponent : ComponentBase;

        IDialogReference Show(Type component);

        IDialogReference Show(Type component, string title);

        IDialogReference Show(Type component, string title, DialogOptions options);

        IDialogReference Show(Type component, string title, DialogParameters parameters);

        IDialogReference Show(Type component, string title, DialogParameters parameters, DialogOptions options);
    }
}
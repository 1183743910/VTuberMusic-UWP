﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using VTuberMusic.Tools;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=234238 上介绍了“空白页”项模板

namespace VTuberMusic.Page
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class SettingsPage
    {
        public SettingsPage()
        {
            this.InitializeComponent();
        }

        private void HXD_is_me_Click(object sender, RoutedEventArgs e)
        {
            MainPage.pageFrame.Navigate(typeof(Settings.HXD_is_me.HXD));
        }

        private void Log_Click(object sender, RoutedEventArgs e)
        {
            MainPage.pageFrame.Navigate(typeof(Settings.Log));
        }
    }
}

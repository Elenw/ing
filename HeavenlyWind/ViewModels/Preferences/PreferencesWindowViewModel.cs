﻿using Sakuno.KanColle.Amatsukaze.Models;
using Sakuno.KanColle.Amatsukaze.Services;
using Sakuno.KanColle.Amatsukaze.ViewModels.Plugins;
using Sakuno.SystemInterop.Dialogs;
using Sakuno.UserInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using System.Windows.Media;

namespace Sakuno.KanColle.Amatsukaze.ViewModels.Preferences
{
    public class PreferencesWindowViewModel : WindowViewModel
    {
        public static PreferencesWindowViewModel Instance { get; } = new PreferencesWindowViewModel();

        public IList<SystemFont> SystemFonts { get; }

        public IList<PluginViewModel> LoadedPlugins { get; }

        public bool IsAutoRotationSupported => CurrentDockExtension.IsAutoRotationSupported;

        public ICommand OpenScreenshotFolderPickerCommand { get; }

        PreferencesWindowViewModel()
        {
            var rSystemFonts = Fonts.SystemFontFamilies.Select(r => new SystemFont(r)).ToList();
            var rCurrentFont = Preference.Current.UI.Font;
            if (!rSystemFonts.Any(r => r.FontFamily.Source == rCurrentFont))
                rSystemFonts.Insert(0, new SystemFont(rCurrentFont));

            SystemFonts = rSystemFonts.AsReadOnly();

            LoadedPlugins = PluginService.Instance.LoadedPlugins.Select(r => new PluginViewModel(r)).ToList().AsReadOnly();

            OpenScreenshotFolderPickerCommand = new DelegatedCommand(() => GetFilenameWithCommonFolderPicker(r => Preference.Current.Browser.Screenshot.Destination = r));
        }

        void GetFilenameWithCommonFolderPicker(Action<string> rpContinuation)
        {
            using (var rFolderPicker = new CommonOpenFileDialog() { FolderPicker = true })
            {
                if (rFolderPicker.Show() == CommonFileDialogResult.OK)
                    rpContinuation(rFolderPicker.Filename);
            }
        }
    }
}

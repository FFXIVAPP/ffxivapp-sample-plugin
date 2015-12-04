// Sample.Plugin ~ Initializer.cs
// Initializer.cs
// 
// Copyright © 2007 - 2015 Ryan Wilson - All Rights Reserved
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Globalization;
using System.Windows;
using System.Windows.Media;
using System.Xml.Linq;
using FFXIVAPP.Common.Controls;
using Sample.Plugin.Properties;
using Sample.Plugin.Views;

namespace Sample.Plugin
{
    internal static class Initializer
    {
        /// <summary>
        /// </summary>
        public static void LoadSettings()
        {
            if (Constants.XSettings != null)
            {
                foreach (var xElement in Constants.XSettings.Descendants()
                                                  .Elements("Setting"))
                {
                    var xKey = (string) xElement.Attribute("Key");
                    var xValue = (string) xElement.Element("Value");
                    if (String.IsNullOrWhiteSpace(xKey) || String.IsNullOrWhiteSpace(xValue))
                    {
                        return;
                    }
                    Settings.Default.SetValue(xKey, xValue, CultureInfo.InvariantCulture);
                    if (!Constants.Settings.Contains(xKey))
                    {
                        Constants.Settings.Add(xKey);
                    }
                }
            }
        }

        /// <summary>
        /// </summary>
        public static void ApplyTheming()
        {
            SetupFont(ref MainView.View.ChatLogFD);
            SetupColor(ref MainView.View.ChatLogFD);
        }

        private static void SetupFont(ref xFlowDocument flowDoc)
        {
            var font = Settings.Default.ChatFont;
            flowDoc._FD.FontFamily = new FontFamily(font.Name);
            flowDoc._FD.FontWeight = font.Bold ? FontWeights.Bold : FontWeights.Regular;
            flowDoc._FD.FontStyle = font.Italic ? FontStyles.Italic : FontStyles.Normal;
            flowDoc._FD.FontSize = font.Size;
        }

        private static void SetupColor(ref xFlowDocument flowDoc)
        {
            flowDoc._FD.Background = new SolidColorBrush(Settings.Default.ChatBackgroundColor);
        }

        #region Declarations

        #endregion
    }
}

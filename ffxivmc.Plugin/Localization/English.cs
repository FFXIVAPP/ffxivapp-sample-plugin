
﻿// Sample.Plugin ~ English.cs
// English.cs
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

using System.Windows;

namespace ffxivmc.Plugin.Localization
{
    public abstract class English
    {
        private static readonly ResourceDictionary Dictionary = new ResourceDictionary();

        /// <summary>
        /// </summary>
        /// <returns> </returns>
        public static ResourceDictionary Context()
        {
            Dictionary.Clear();
            Dictionary.Add("sample_", "PLACEHOLDER");
            Dictionary.Add("sample_ChatLogTabHeader", "Item Log");
            Dictionary.Add("sample_ClearChatLogMessage", "Clear Item Log");
            Dictionary.Add("sample_ClearChatLogToolTip", "Clear Item Log");
            return Dictionary;
        }
    }
}

// Sample.Plugin ~ LogPublisher.cs
// LogPublisher.cs
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
using FFXIVAPP.Common.Utilities;
using FFXIVAPP.Memory.Core;
using NLog;
using Sample.Plugin.Properties;
using Sample.Plugin.Views;

namespace Sample.Plugin.Utilities
{
    public static class LogPublisher
    {
        public static void Process(ChatLogEntry chatEntry)
        {
            try
            {
                var timeStampColor = Settings.Default.TimeStampColor.ToString();
                var timeStamp = chatEntry.TimeStamp.ToString("[HH:mm:ss] ");
                var line = chatEntry.Line.Replace("  ", " ");
                var color = (Constants.Colors.ContainsKey(chatEntry.Code)) ? Constants.Colors[chatEntry.Code][0] : "FFFFFF";
                FFXIVAPP.Common.Constants.FD.AppendFlow(timeStamp, "", line, new[]
                {
                    timeStampColor, "#" + color
                }, MainView.View.ChatLogFD._FDR);
            }
            catch (Exception ex)
            {
                Logging.Log(LogManager.GetCurrentClassLogger(), "", ex);
            }
        }
    }
}

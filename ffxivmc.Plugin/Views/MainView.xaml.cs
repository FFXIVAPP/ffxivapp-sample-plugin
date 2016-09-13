
// Sample.Plugin ~ MainView.xaml.cs
// MainView.xaml.cs
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
using System.Collections.ObjectModel;

namespace ffxivmc.Plugin.Views
{
    /// <summary>
    ///     Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView
    {
        public static MainView View;
        private ObservableCollection<OutputLine> OutputList = new ObservableCollection<OutputLine>();

        public MainView()
        {
            InitializeComponent();
            View = this;

            OutputList.Add(new OutputLine
            {
                Text = "Initialized",
                Time = DateTime.Now.ToShortTimeString()
            });

            this.OutputListView.ItemsSource = OutputList;
            
        }

        public void AddOutput(string text)
        {
            OutputList.Insert(0,new OutputLine
            {
                Text = text,
                Time = DateTime.Now.ToShortTimeString()
            });

            if (OutputList.Count > 50)
            {
                OutputList.RemoveAt(OutputList.Count - 1);
            }

        }
    }

    public class OutputLine
    {
        public string Text { get; set; }
        public string Time { get; set;  }
    }
}

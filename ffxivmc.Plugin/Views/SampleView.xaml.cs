
﻿// Sample.Plugin ~ SampleView.xaml.cs
// SampleView.xaml.cs
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

namespace ffxivmc.Plugin.Views
{
    /// <summary>
    ///     Interaction logic for SampleView.xaml
    /// </summary>
    public partial class SampleView
    {
        public static SampleView View;

        public SampleView()
        {
            InitializeComponent();
            View = this;
        }
    }
}

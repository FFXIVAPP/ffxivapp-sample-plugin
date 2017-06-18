// Sample.Plugin ~ SampleViewModel.cs
// 
// Copyright © 2007 - 2017 Ryan Wilson - All Rights Reserved
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

using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using FFXIVAPP.Common.ViewModelBase;

namespace Sample.Plugin.ViewModels
{
    internal sealed class SampleViewModel : INotifyPropertyChanged
    {
        public SampleViewModel()
        {
            SampleCommand = new DelegateCommand(Sample);
            SampleCommandT = new DelegateCommand<object>(SampleT);
        }

        #region Property Bindings

        private static SampleViewModel _instance;

        public static SampleViewModel Instance
        {
            get { return _instance ?? (_instance = new SampleViewModel()); }
        }

        #endregion

        #region Declarations

        public ICommand SampleCommand { get; private set; }
        public ICommand SampleCommandT { get; private set; }

        #endregion

        #region Loading Functions

        #endregion

        #region Utility Functions

        #endregion

        #region Command Bindings

        /// <summary>
        /// </summary>
        public static void Sample()
        {
            //do something here
        }

        /// <summary>
        /// </summary>
        public static void SampleT(object parameter)
        {
            //do something here
        }

        #endregion

        #region Implementation of INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private void RaisePropertyChanged([CallerMemberName] string caller = "")
        {
            PropertyChanged(this, new PropertyChangedEventArgs(caller));
        }

        #endregion
    }
}

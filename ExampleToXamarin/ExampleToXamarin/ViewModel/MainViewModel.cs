using System;
using System.Collections.Generic;
using System.Text;

using System.Windows.Input;
using Xamarin.Forms;

using Unity;

using ExampleToXamarin.Helpers;
using ExampleToXamarin.IOC;
using ExampleToXamarin.Infrastructure.Implementation;
using ExampleToXamarin.Infrastructure.Interface;

namespace ExampleToXamarin.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private IRandomAddresses randomAddresses;

        #region Property
        private static string rndPublic;
        public string RndPublic
        {
            get { return rndPublic; }
            set { rndPublic = value; NotifyPropertyChanged(); }
        }
        #endregion

        #region Command
        public ICommand CommandStart { get; }
        #endregion

        #region Constructor
        public MainViewModel()
        {
            this.randomAddresses = DIContainer.container.unity.Resolve<IRandomAddresses>();

            CommandStart = new ButtonCommand(delegate { randomAddresses.NewRandom(HandlerResult); });
        }

        #endregion

        #region Actions
        private void HandlerResult(string RndPublic)
        {
            this.RndPublic = RndPublic;
        }
        #endregion
    }
}

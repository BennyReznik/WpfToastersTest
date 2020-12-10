using Caliburn.Micro;
using System.Windows;
using WpfToastersTest.ViewModels;

namespace WpfToastersTest
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ToasterTestMainViewModel>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPBinding
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page, INotifyPropertyChanged
    {

        DispatcherTimer dispatcherTimer = new DispatcherTimer();

        public MainPage()
        {
            this.InitializeComponent();

            dispatcherTimer.Interval = TimeSpan.FromSeconds(1);
            dispatcherTimer.Tick += DispatcherTimer_Tick;

            this.DataContext = this;
        }

        void DispatcherTimer_Tick(object sender, object e)
        {
            Propriedade++;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        int propriedade;
        public int Propriedade
        {
            get
            {
                return this.propriedade;
            }
            set
            {
                if (this.propriedade != value)
                {
                    this.propriedade = value;
                    if (this.PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Propriedade"));
                    }
                }
            }
        }

        async void Atribuidor()
        {
            // Propriedade = await Contador();
        }

        private Task<int> Contador()
        {
            return Task.Run(() => { return 1; });
        }

    }
}

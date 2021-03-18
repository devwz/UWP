using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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

namespace Binding
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page, INotifyPropertyChanged
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.DataContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        int property1;
        public int Property1
        {
            get
            {
                return property1;
            }
            set
            {
                if (property1 != value)
                {
                    property1 = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Property1"));
                    }
                }
            }
        }

        int property2;
        public int Property2
        {
            get
            {
                return property2;
            }
            set
            {
                property2 = value;
                OnPropertyChanged("Property2");
            }
        }

        public void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        DispatcherTimer dispatcher = new DispatcherTimer();

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            dispatcher.Tick += Dispatcher_Tick;
            dispatcher.Interval = TimeSpan.FromSeconds(1);
            dispatcher.Start();
        }

        private void Dispatcher_Tick(object sender, object e)
        {
            // Property1++;
            Assign();
        }

        async void Assign()
        {
            Property1 += await Counter();
            Property2 += await Counter();
        }

        System.Threading.Tasks.Task<int> Counter()
        {
            return System.Threading.Tasks.Task.Run(() => { return 1; });
        }
    }
}

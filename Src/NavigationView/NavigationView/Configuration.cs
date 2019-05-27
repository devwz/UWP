using NavigationView.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace NavigationView
{
    public partial class MainPage : Page
    {
        public const string FEATURE_NAME = "Navigation View";

        List<Scenario> pages = new List<Scenario>
        {
            new Scenario() { Title = "Home", Page = typeof(HomePage) },
            new Scenario() { Title = "Page 1", Page = typeof(BlankPage_1) },
            new Scenario() { Title = "Page 2", Page = typeof(BlankPage_2) },
            new Scenario() { Title = "Page 3", Page = typeof(BlankPage_3) }
        };
    }

    public class Scenario
    {
        public string Title { get; set; }
        public Type Page { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BindableLayoutPractice
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = this;
        }

        public ObservableCollection<Model> Data { get; set; } = new ObservableCollection<Model>
        {
            new Model{Text="Pink",Color=Color.DeepPink,Row=0,Column=0},
            new Model{Text="Crimson",Color=Color.Crimson,Row=0,Column=1},
            new Model{Text="Aqua",Color=Color.Aqua,Row=1,Column=0},
            new Model{Text="Blue",Color=Color.Blue,Row=1,Column=1},
        };
    }

    public class Model
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public string Text { get; set; }
        public Color Color { get; set; }

    }
}

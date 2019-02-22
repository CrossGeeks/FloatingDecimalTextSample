using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FloatingDecimalTextSample
{
    public partial class MainPage : ContentPage
    {
        public double Amount { get; set; } = 180.45;
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }
    }
}

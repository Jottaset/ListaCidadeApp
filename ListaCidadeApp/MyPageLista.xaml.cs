using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ListaCidadeApp.Model;

namespace ListaCidadeApp
{
    public partial class MyPageLista : ContentPage
    {

        public MyPageLista(List<string> listaNova)
        {
            InitializeComponent();
            ListaCidade.ItemsSource = listaNova;
        }
    }
}

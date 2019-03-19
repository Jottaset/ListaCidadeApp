using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ListaCidadeApp.Model;

namespace ListaCidadeApp
{
    public partial class MainPage : ContentPage
    {
        List<Cidade> listacidade = new List<Cidade>();
        List<string> stringlista = new List<string>();

        void GravarDados(object sender, System.EventArgs e)
        {
            Cidade cidade = new Cidade();

            cidade.nome = label_cidade.Text;
            cidade.uf =   label_estado.Text;

            listacidade.Add(cidade);
            stringlista.Add(cidade.nome + " " + cidade.uf);

            label_cidade.Text = string.Empty;
            label_estado.Text = string.Empty;
        }

        void ChecarDados(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MyPageLista(stringlista));
        }

        public MainPage()
        {
            InitializeComponent();

            }         
    }
}

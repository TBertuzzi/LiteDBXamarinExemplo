using LiteDB;
using LiteDBXamarinExemplo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LiteDBXamarinExemplo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void btnGerarPorco_Clicked(object sender, EventArgs e)
        {
            LiteRepository repositorio = new LiteRepository("MeuBanco.db");

            Porco porco = new Porco
            {
                Nome = "Rodolfo",
                Idade = 3,
                Apelidos = new string[] { "Rodie", "Rodolfinho" },
                VirouBacon = false
            };

            repositorio.Insert<Porco>(porco);

            lStatusPorco.Text = "Porco Criado!";
    }
        private void btnTransformaBacon_Clicked(object sender, EventArgs e)
        {
            LiteRepository repositorio = new LiteRepository("MeuBanco.db");

           List<Porco> Porcos = repositorio.Query<Porco>().ToList();

            if (Porcos.Count > 0)
            {
                var porco = Porcos[0];
                porco.VirouBacon = true;
                repositorio.Update<Porco>(porco);

                lStatusPorco.Text = "Virou Bacon";
            }

        }
    }
}

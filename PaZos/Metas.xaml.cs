using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PaZos
{
	public partial class Metas : ContentPage
	{

		public Metas ()
		{
			InitializeComponent ();
			cargarImagenes ();


			/*
			var embeddedImage = new Image { Aspect = Aspect.AspectFill };
			embeddedImage.Source = ImageSource.FromResource ("PaZos.Resources.meta.png");
			embeddedImage.WidthRequest = 338;
			embeddedImage.HeightRequest = 200;

			var abslayout = new AbsoluteLayout ();
			abslayout.Children.Add(embeddedImage, new Point(0,50));

			ScrollView scrollview = new ScrollView {
				Content = abslayout
			};

			Content = scrollview;

			*/

			// Dictionary to get Color from color name.
			Dictionary<string, int> tiposMetas = new Dictionary<string, int>
			{
				{ "Emprendimiento", 1 }, 
				{ "Personal", 2 }
			};

			//Picker picker = new Picker
			//{
			//	Title = "Tipo de meta",
			//	VerticalOptions = LayoutOptions.CenterAndExpand
			//};

			foreach (string tipoMeta in tiposMetas.Keys)
			{
				pkTipoMeta.Items.Add(tipoMeta);
			}

			//stk1.Children.Add (picker);

		}

		private void cargarImagenes(){
			imgMeta1.Source = ImageSource.FromResource ("PaZos.Resources.meta1.png");
			// = ImageSource.FromResource ("PaZos.Resources.fondapp.png");
		}

	}
}


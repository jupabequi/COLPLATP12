using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XLabs.Forms.Controls;

namespace PaZos
{
	public partial class AccionesDia : ContentPage
	{



		MasterDetailPage master;
		private NavigationPage NPdias;

		List<AccionesAhorradoras> ListaAcciones;
		Usuario usuario;
		List<ExtendedEntry> txtaccion, txtvalor;
		List<int> idaccion;
		int dia;
		RelativeLayout layout;

		public AccionesDia (MasterDetailPage masterDetail, int tdia, Usuario tusuario)
		{
			usuario = tusuario;
			dia = tdia;

			var guardaritem = new ToolbarItem {
				Text = "Guardar"
			};
			guardaritem.Clicked += (object sender, System.EventArgs e) => 
			{
				guardarAcciones();
			};

			ToolbarItems.Add(guardaritem);
			this.Title = "Acciones ahorradoras";

			master = masterDetail;

			layout = new RelativeLayout ();

			//Colocar background
			var imgBackground = new Image () {
				Source = ImageSource.FromResource ("PaZos.Resources.FondoAcciones.png"),
				Aspect = Aspect.AspectFill
			};

			layout.Children.Add (imgBackground,
				Constraint.Constant (0),
				Constraint.Constant (0),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Height;
				}));
			//Fin Colocar background 

			//Dias
			var imgDias = new Image ();


			switch (dia){

			case 1:
				imgDias.Source = ImageSource.FromResource ("PaZos.Resources.Dias.lunes.png");
				break;
			case 2:
				imgDias.Source = ImageSource.FromResource ("PaZos.Resources.Dias.martes.png");
				break;
			case 3:
				imgDias.Source = ImageSource.FromResource ("PaZos.Resources.Dias.miercoles.png");
				break;
			case 4:
				imgDias.Source = ImageSource.FromResource ("PaZos.Resources.Dias.Jueves.png");
				break;
			case 5:
				imgDias.Source = ImageSource.FromResource ("PaZos.Resources.Dias.Viernes.png");
				break;
			case 6:
				imgDias.Source = ImageSource.FromResource ("PaZos.Resources.Dias.Sabado.png");
				break;
			case 7:
				imgDias.Source = ImageSource.FromResource ("PaZos.Resources.Dias.Domingo.png");
				break;

			};
			


			layout.Children.Add (imgDias,
				Constraint.Constant (15),
				Constraint.Constant (15),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 52;
				}));

			int y = 15;
			var lbdia = new Button () {
				Text = "",
				TextColor = Color.White,
				//BackgroundColor = Color.Blue
			};
			/*lbdia.Clicked += (sender, args) => {
				Selected();
			};*/

			layout.Children.Add (lbdia,
				Constraint.Constant (15),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return 250;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 52;
				}));


			//End Dias


			cargarAcciones ();




		}

		public void Selected()
		{
			/*
			NPdias = new NavigationPage (
				new acciones (master)
			);

			master.Detail = NPdias;
			*/
		}
		public async void guardarAcciones(){

			int i;
			ListaAcciones = new List<AccionesAhorradoras> ();
			for (i = 0; i < txtvalor.Count-1; i++) {
				ListaAcciones.Add(new AccionesAhorradoras(){
					accion=txtaccion [i].Text,
					valor=Convert.ToDouble(txtvalor [i].Text),
					dia=dia,
					uso=usuario.Id,
					Id=idaccion[i]
				});

				var respuesta = await new RestAccionesAhorradoras ().actualizar (ListaAcciones [i]);
			}

			if(txtaccion[i].Text!="" && txtaccion[i].Text!= null){
				ListaAcciones.Add(new AccionesAhorradoras(){
					accion=txtaccion [i].Text,
					valor=Convert.ToDouble(txtvalor [i].Text),
					dia=dia,
					uso=usuario.Id
				});

				var respuesta = await new RestAccionesAhorradoras ().guardar (ListaAcciones [i]);
			}

			//cargarAcciones ();

			var label = new Label ();
		}
		public async void cargarAcciones(){


			var Lista = await new RestAccionesAhorradoras ().get (usuario);

			int j = Lista.Count+1;
			int y = 15;
			Label lbvalor;
			Double total=0;

			txtaccion = new List<ExtendedEntry> ();
			txtvalor = new List<ExtendedEntry> ();
			idaccion = new List<int> ();

			int i, a=1;
			y = 52 + y + 10;

			for (i = 1; i < j; i++) {
				
				total = total + Lista [i-1].valor;
				idaccion.Add (Lista [i - 1].Id);

				if (Lista [i - 1].dia == dia) {
					
					txtaccion.Add (new ExtendedEntry () {
						Placeholder = "Acción " + a.ToString (),
						Text = Lista [i - 1].accion,
						Font = Font.OfSize ("TwCenMT-Condensed", 18)
					});
					layout.Children.Add (txtaccion [a - 1],
						Constraint.Constant (20),
						Constraint.Constant (y + 90 * (a - 1)),
						Constraint.RelativeToParent ((Parent) => {
							return Parent.Width - 40;
						}),
						Constraint.RelativeToParent ((Parent) => {
							return 40;
						}));	


					lbvalor = new Label () {
						Text = "Valor",
						FontSize = 18,
						FontFamily = "TwCenMT-Condensed"
					};
					layout.Children.Add (lbvalor,
						Constraint.RelativeToParent ((Parent) => {
							return Parent.Width - 20 - 150 - 45;
						}),
						Constraint.Constant (y + 55 + 90 * (a - 1)),
						Constraint.RelativeToParent ((Parent) => {
							return 100;
						}),
						Constraint.RelativeToParent ((Parent) => {
							return 40;
						}));	

					txtvalor.Add (new ExtendedEntry () {
						Text = Lista [i - 1].valor.ToString ("N0"),
						Font = Font.OfSize ("TwCenMT-Condensed", 18),
						XAlign = TextAlignment.End
						
					});
					txtvalor[a - 1].Behaviors.Add (new NumberValidatorBehavior ());
					layout.Children.Add (txtvalor [a - 1],
						Constraint.RelativeToParent ((Parent) => {
							return Parent.Width - 20 - 150;
						}),
						Constraint.Constant (y + 45 + 90 * (a - 1)),
						Constraint.RelativeToParent ((Parent) => {
							return 150;
						}),
						Constraint.RelativeToParent ((Parent) => {
							return 40;
						}));	

					a++;
				}
			}

			txtaccion.Add ( new ExtendedEntry () {
				Placeholder = "Acción " + a.ToString(),
				Font = Font.OfSize("TwCenMT-Condensed",18)
			});
			layout.Children.Add (txtaccion[a-1],
				Constraint.Constant (20),
				Constraint.Constant (y+90*(a-1)),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width - 40;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));	


			lbvalor = new Label (){
				Text = "Valor",
				FontSize=18,
				FontFamily =  "TwCenMT-Condensed"
			};
			layout.Children.Add (lbvalor,
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width - 20 - 150 - 45;
				}),
				Constraint.Constant (y+55+90*(a-1)),
				Constraint.RelativeToParent ((Parent) => {
					return 100;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));	

			txtvalor.Add (new ExtendedEntry () {
				Font = Font.OfSize("TwCenMT-Condensed",18),
				XAlign=TextAlignment.End
			});
			txtvalor[a-1].Behaviors.Add (new NumberValidatorBehavior ());
			layout.Children.Add (txtvalor[a-1],
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width - 20 - 150;
				}),
				Constraint.Constant (y+45+90*(a-1)),
				Constraint.RelativeToParent ((Parent) => {
					return 150;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));	
			
			y = y + 90 * (a);

			lbvalor = new Label (){
				Text = "Valor total",
				FontSize=18,
				FontFamily =  "TwCenMT-Condensed"
			};
			layout.Children.Add (lbvalor,
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width - 20 - 200 - 60;
				}),
				Constraint.Constant (y+5),
				Constraint.RelativeToParent ((Parent) => {
					return 60;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));

			ExtendedEntry txttotal = new ExtendedEntry () {
				Font = Font.OfSize("TwCenMT-Condensed",18),
				XAlign=TextAlignment.End,
				IsEnabled=false,
				Text="$ " + total.ToString("N0")
			};
			layout.Children.Add (txttotal,
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width - 20 - 200;
				}),
				Constraint.Constant (y),
				Constraint.RelativeToParent ((Parent) => {
					return 200;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return 40;
				}));	


			ScrollView scrollview = new ScrollView {

				Content = layout

			};


			Content = scrollview;





			var Label = new Label ();

		}
		public async void actualizarAcciones(){
			var respuesta = await new RestAccionesAhorradoras ().actualizar (ListaAcciones [0]);
		}

	}
}


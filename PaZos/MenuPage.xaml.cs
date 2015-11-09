﻿using System;
using System.Collections.Generic;


using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace PaZos
{
	public partial class MenuPage : ContentPage
	{

		ObservableCollection<MenuItem> Items;


		MasterDetailPage master;

		TableView tableView;

		private NavigationPage metas;
		private NavigationPage acciones;
		private NavigationPage evaluacion;
		private NavigationPage progreso;
		private NavigationPage acerca;


		public MenuPage (MasterDetailPage masterDetail)
		{
			
	
	
			Title = "-";
			//Icon = "slideout.png";
			master = masterDetail;


			var layout = new RelativeLayout();

			var Fondo = new Image { Aspect = Aspect.AspectFill };
			Fondo.Source = ImageSource.FromResource ("PaZos.Resources.FondoLogin.png");
			layout.Children.Add(Fondo, 
				Constraint.Constant (0),
				Constraint.Constant (0),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Width;
				}),
				Constraint.RelativeToParent ((Parent) => {
					return Parent.Height-40;
				}));

			var imgMeta = new Image ();
			imgMeta.Source = ImageSource.FromResource ("PaZos.Resources.metas.png");
			
            var imgAcciones = new Image ();
			imgAcciones.Source = ImageSource.FromResource ("PaZos.Resources.Acciones.png");
			
			var imgEvaluacion = new Image ();
			imgEvaluacion.Source = ImageSource.FromResource ("PaZos.Resources.Evaluacion.png");
		
			var imgprogreso = new Image ();
			imgprogreso.Source = ImageSource.FromResource ("PaZos.Resources.progreso.png");
			
			var imgacercade = new Image ();
			imgacercade.Source = ImageSource.FromResource ("PaZos.Resources.acercade.png");
			

			
            



			var logoutButton = new Button { Text = "Logout" };
			logoutButton.Clicked += (sender, e) => {
				App.Current.Logout();
			};

			int y = 30;

            layout.Children.Add(imgMeta,
                Constraint.Constant(0),
                Constraint.Constant(y),
                Constraint.RelativeToParent((Parent) =>
                {
                    return 270;
                }),
                Constraint.RelativeToParent((Parent) =>
                {
                    return 60;
                }));
            var lbMeta = new Button()
            {
                Text = "Metas",
                TextColor = Color.White,
				FontSize=26,
				FontFamily =  "MyriadPro-Bold",
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Center
            };
            lbMeta.Clicked += (sender, args) =>
            {
                Selected(1);
            };

			layout.Children.Add(lbMeta,
                Constraint.Constant(0),
                Constraint.Constant(y),
                Constraint.RelativeToParent((Parent) =>
                {
                    return 270;
                }),
                Constraint.RelativeToParent((Parent) =>
                {
                    return 60;
                }));

			y=y+60;
            layout.Children.Add(imgAcciones,
                Constraint.Constant(0),
                Constraint.Constant(y),
                Constraint.RelativeToParent((Parent) =>
                {
                    return 270;
                }),
                Constraint.RelativeToParent((Parent) =>
                {
                    return 60;
                }));
            var lbAcciones = new Button()
            {
                Text = "Acciones ahorradoras",
                TextColor = Color.White,
				FontSize=26,
				FontFamily =  "MyriadPro-Bold",
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Center
            };
            lbAcciones.Clicked += (sender, args) =>
            {
                Selected(2);
            };


            layout.Children.Add(lbAcciones,
                Constraint.Constant(0),
                Constraint.Constant(y),
                Constraint.RelativeToParent((Parent) =>
                {
                    return 270;
                }),
                Constraint.RelativeToParent((Parent) =>
                {
                    return 60;
                }));
            
			y=y+60;
            layout.Children.Add(imgEvaluacion,
                Constraint.Constant(0),
                Constraint.Constant(y),
                Constraint.RelativeToParent((Parent) =>
                {
                    return 270;
                }),
                Constraint.RelativeToParent((Parent) =>
                {
                    return 60;
                }));
            var lbEvaluacion = new Button()
            {
                Text = "Evaluación del día",
                TextColor = Color.White,
				FontSize=26,
				FontFamily =  "MyriadPro-Bold",
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Center
            };
            lbEvaluacion.Clicked += (sender, args) =>
            {
                Selected(3);
            };

            layout.Children.Add(lbEvaluacion,
                Constraint.Constant(0),
                Constraint.Constant(y),
                Constraint.RelativeToParent((Parent) =>
                {
                    return 270;
                }),
                Constraint.RelativeToParent((Parent) =>
                {
                    return 60;
                }));
			y=y+60;
            layout.Children.Add(imgprogreso,
                Constraint.Constant(0),
                Constraint.Constant(y),
                Constraint.RelativeToParent((Parent) =>
                {
                    return 270;
                }),
                Constraint.RelativeToParent((Parent) =>
                {
                    return 60;
                }));
            var lbprogreso = new Button()
            {
                Text = "Progreso",
                TextColor = Color.White,
				FontSize=26,
				FontFamily =  "MyriadPro-Bold",
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Center
            };
            lbprogreso.Clicked += (sender, args) =>
            {
                Selected(4);
            };

            layout.Children.Add(lbprogreso,
                Constraint.Constant(0),
                Constraint.Constant(y),
                Constraint.RelativeToParent((Parent) =>
                {
                    return 270;
                }),
                Constraint.RelativeToParent((Parent) =>
                {
                    return 60;
                }));

			y=y+60;
            layout.Children.Add(imgacercade,
                Constraint.Constant(0),
				Constraint.Constant(y),
                Constraint.RelativeToParent((Parent) =>
                {
                    return 270;
                }),
                Constraint.RelativeToParent((Parent) =>
                {
                    return 60;
                }));
            var lbacercade = new Button()
            {
                Text = "Acerca de..",
                TextColor = Color.White,
				FontSize=26,
				FontFamily =  "MyriadPro-Bold",
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions.Center
            };
            lbacercade.Clicked += (sender, args) =>
            {
                Selected(5);
            };

            layout.Children.Add(lbacercade,
                Constraint.Constant(0),
                Constraint.Constant(y),
                Constraint.RelativeToParent((Parent) =>
                {
                    return 270;
                }),
                Constraint.RelativeToParent((Parent) =>
                {
                    return 60;
                }));


            //Content = layout;
			Content = new StackLayout {
				BackgroundColor = Color.Black,
				VerticalOptions = LayoutOptions.FillAndExpand,
				Children = {
					layout,
                    logoutButton
				}
			};

		}

		public void Selected(int option)
		{
			switch (option) {

			case 1:
				master.Detail = metas ??
					(metas = new NavigationPage (
					new Metas (master)
				)
				);
				break;
			case 2:
				master.Detail = acciones ??
					(acciones = new NavigationPage (
						new acciones (master)
				)
				);
				break;
			case 3:
				master.Detail = evaluacion ??
					(evaluacion = new NavigationPage (
						new evaluacion (master)
				)
				);
				break;
			case 4:
				master.Detail = progreso ??
					(progreso = new NavigationPage (
					new progreso (master)
				)
				);
				break;
			case 5:
				master.Detail = acerca ??
					(acerca = new NavigationPage (
					new acerca (master)
				)
				);
				break;

			}

			master.IsPresented = false;

		}
	}
}


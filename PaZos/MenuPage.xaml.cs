using System;
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

			
			var imgMeta = new Image ();
			imgMeta.Source = ImageSource.FromResource ("PaZos.Resources.meta.png");
			
            var imgAcciones = new Image ();
			imgAcciones.Source = ImageSource.FromResource ("PaZos.Resources.Acciones.png");
			
			var imgEvaluacion = new Image ();
			imgEvaluacion.Source = ImageSource.FromResource ("PaZos.Resources.Evaluacion.png");
		
			var imgprogreso = new Image ();
			imgprogreso.Source = ImageSource.FromResource ("PaZos.Resources.progreso.png");
			
			var imgacercade = new Image ();
			imgacercade.Source = ImageSource.FromResource ("PaZos.Resources.acercade.png");
			

			
            var layout = new RelativeLayout();



			var logoutButton = new Button { Text = "Logout" };
			logoutButton.Clicked += (sender, e) => {
				App.Current.Logout();
			};

            layout.Children.Add(imgMeta,
                Constraint.Constant(0),
                Constraint.Constant(0),
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
                Text = "",
                TextColor = Color.White,
                Opacity=0
                //BackgroundColor = Color.Blue
            };
            lbMeta.Clicked += (sender, args) =>
            {
                Selected(1);
            };

            layout.Children.Add(lbMeta,
                Constraint.Constant(0),
                Constraint.Constant(0),
                Constraint.RelativeToParent((Parent) =>
                {
                    return 270;
                }),
                Constraint.RelativeToParent((Parent) =>
                {
                    return 60;
                }));

            layout.Children.Add(imgAcciones,
                Constraint.Constant(0),
                Constraint.Constant(60),
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
                Text = "",
                TextColor = Color.White,
                Opacity = 0
                //BackgroundColor = Color.Blue
            };
            lbAcciones.Clicked += (sender, args) =>
            {
                Selected(2);
            };

            layout.Children.Add(lbAcciones,
                Constraint.Constant(0),
                Constraint.Constant(60),
                Constraint.RelativeToParent((Parent) =>
                {
                    return 270;
                }),
                Constraint.RelativeToParent((Parent) =>
                {
                    return 60;
                }));
            
            
            layout.Children.Add(imgEvaluacion,
                Constraint.Constant(0),
                Constraint.Constant(120),
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
                Text = "",
                TextColor = Color.White,
                Opacity = 0
                //BackgroundColor = Color.Blue
            };
            lbEvaluacion.Clicked += (sender, args) =>
            {
                Selected(3);
            };

            layout.Children.Add(lbEvaluacion,
                Constraint.Constant(0),
                Constraint.Constant(120),
                Constraint.RelativeToParent((Parent) =>
                {
                    return 270;
                }),
                Constraint.RelativeToParent((Parent) =>
                {
                    return 60;
                }));

            layout.Children.Add(imgprogreso,
                Constraint.Constant(0),
                Constraint.Constant(180),
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
                Text = "",
                TextColor = Color.White,
                Opacity = 0
                //BackgroundColor = Color.Blue
            };
            lbprogreso.Clicked += (sender, args) =>
            {
                Selected(4);
            };

            layout.Children.Add(lbprogreso,
                Constraint.Constant(0),
                Constraint.Constant(180),
                Constraint.RelativeToParent((Parent) =>
                {
                    return 270;
                }),
                Constraint.RelativeToParent((Parent) =>
                {
                    return 60;
                }));
            layout.Children.Add(imgacercade,
                Constraint.Constant(0),
                Constraint.Constant(240),
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
                Text = "",
                TextColor = Color.White,
                Opacity = 0
                //BackgroundColor = Color.Blue
            };
            lbacercade.Clicked += (sender, args) =>
            {
                Selected(5);
            };

            layout.Children.Add(lbacercade,
                Constraint.Constant(0),
                Constraint.Constant(240),
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


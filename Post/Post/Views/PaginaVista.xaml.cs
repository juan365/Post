using Post.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Post.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PaginaVista : ContentPage
	{
        public Coche Micoche { get; set; }
		public PaginaVista ()
		{
			InitializeComponent ();
            Micoche = new Coche();
            Micoche.Marca = "FERRARI";
            Micoche.ILogo = "https://ih0.redbubble.net/image.484249329.4310/flat,900x900,070,f.jpg";
            Micoche.IColeccion1 = "https://cdn.20m.es/img2/recortes/2018/05/23/707644-600-338.jpg";
            Micoche.IColeccion2 = "https://www.autonocion.com/wp-content/uploads/2017/05/Ferrari.jpg";
            Micoche.IColeccion3 = "http://z56474e2dnf3bw6yj3kt96yy.wpengine.netdna-cdn.com/wp-content/uploads/2015/01/Ferrari.jpg";
            Micoche.IColeccion4 = "http://www.maximmexico.com/wp-content/uploads/2017/10/ferrari-3.jpg";
            Micoche.IColeccion5 = "http://www.maximmexico.com/wp-content/uploads/2017/10/Ferrari.jpg";
            Micoche.Descripcion = "Ferrari es actualmente la mejor marca " +
            "de coches deportivos y gama alta del mundo";
            BindingContext = Micoche;
		}
	}
}
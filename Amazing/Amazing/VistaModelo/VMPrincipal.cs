using Amazing.Datos;
using Amazing.Modelo;
using Amazing.RepoDB;
using Amazing.VistaModelo;
using Amazing.Vistas.Detalle;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Plugin.SharedTransitions;
using Xamarin.Forms.Internals;

namespace Amazing.VistaModelo
{
    public class VMPrincipal : VMBase
    {
        #region VARIABLES
        public ObservableCollection<MProductos> _listaproductos;
        public ObservableCollection<MCategorias> _listarcategorias;
        #endregion
        #region CONSTRUCTOR
        public VMPrincipal(INavigation navigation)
        {
            Navigation = navigation;
            ListarProductos();
            ListarCategorias();
        }
        #endregion
        #region OBJETOS
        public ObservableCollection<MCategorias> Listacategorias
        {
            get { return _listarcategorias; }
            set { SetValue(ref _listarcategorias, value); }
        }
        public ObservableCollection<MProductos> Listaproductos
        {
            get { return _listaproductos; }
            set { SetValue(ref _listaproductos, value); }
        }
        #endregion
        #region PROCESOS
        public void ListarProductos()
        {
            var funcion = new DProductos();
            Listaproductos = funcion.ListarProductos();
        }
        public void ListarCategorias()
        {
            var funcion = new DCategorias();
            Listacategorias = funcion.MostrarCategorias();
        }
        private void Seleccionar(MCategorias parametros)
        {
            var index = Listacategorias
                .ToList()
                .FindIndex(p => p.Categoria== parametros.Categoria);
            if(index > -1)
            {
                DesSeleccionar();
                Listacategorias[index].SelectItem = true;
                Listacategorias[index].Color1 = "#8664FF";
                Listacategorias[index].Color2 = "#8BA8FF";
                Listacategorias[index].TextColor = "#FFFFFF";
            }
        }
        private void DesSeleccionar()
        {
            Listacategorias.ForEach((item) =>
            {
                item.SelectItem = false;
                item.Color1 = "#ffffff";
                item.Color2 = "#ffffff";
                item.TextColor = "#2F394B";
            });
        }
        private async void SeleccionarProducto(MProductos parametros)
        {           
            var page = (App.Current.MainPage as SharedTransitionNavigationPage).CurrentPage;
            SharedTransitionNavigationPage.SetTransitionDuration(page,500);
            SharedTransitionNavigationPage.SetBackgroundAnimation(page, BackgroundAnimation.SlideFromLeft);
          SharedTransitionNavigationPage.SetTransitionSelectedGroup(page, parametros.Id);
            await Navigation.PushAsync(new DetalleProducto(parametros));
        }
      
        #endregion
        #region COMANDOS
        public ICommand Seleccionarcommand => new Command<MCategorias>(Seleccionar);
        public ICommand SeleccionarProductoCommand => new Command<MProductos>(SeleccionarProducto);
        #endregion
    }
}

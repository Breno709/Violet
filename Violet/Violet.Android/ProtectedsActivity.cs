using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Violet;

namespace Violet.Droid
{
    [Activity(Label = "ProtectedsActivity", Icon = "@mipmap/icon", Theme = "@style/MainTheme")]
    public class ProtectedsActivity : ListActivity
    {
        static public ListingMode TipoListagem;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            switch (TipoListagem)
            {
                case ListingMode.Protegidos:
                    var nomes = from residente in DATABASE.Residentes
                            select $"{residente.Nome}: {residente.Telefone}";

                    ListAdapter = new ArrayAdapter<string>(this, Resource.Layout.ListItem, nomes.ToArray());
                    break;

                case ListingMode.Registros:
                    var registros = from rgstr in DATABASE.Registros
                                    select $"{rgstr.Nome}: {rgstr.Data} - {rgstr.Hora}";

                    ListAdapter = new ArrayAdapter<string>(this, Resource.Layout.ListItem, registros.ToArray());
                    break;
            }            
        }

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            ListDataActivity.operationMode = TipoListagem;
            ListDataActivity.registerNumber = position;
            StartActivity(typeof(ListDataActivity));
        }
    }

    public enum ListingMode
    {
        Protegidos,
        Registros
    }
}
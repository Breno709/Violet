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

namespace Violet.Droid
{
    [Activity(Label = "ListDataActivity", Icon = "@mipmap/icon", Theme = "@style/MainTheme")]
    public class ListDataActivity : ListActivity
    {
        static public ListingMode operationMode;
        static public int registerNumber = 0;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            switch(operationMode)
            {
                case ListingMode.Registros: GetRegisterData(); break;
                case ListingMode.Protegidos: GetRegisterUser(); break;
            }
            
        }

        private void GetRegisterData()
        {
            var dado = DATABASE.Registros[registerNumber];
            string[] dados = { $"{dado.Nome} - {dado.Data}:{dado.Hora}", $"Observação: {dado.Obs}" };
            ListAdapter = new ArrayAdapter<string>(this, Resource.Layout.ListItem, dados);
        }

        private void GetRegisterUser()
        {
            var dado = DATABASE.Residentes[registerNumber];
            string[] dados = {$"{dado.Nome}", $"Telefone: {dado.Telefone}", $"Email: {dado.Email}",
                            $"Endereço: {dado.Endereco} - CEP: {dado.CEP}" };

            ListAdapter = new ArrayAdapter<string>(this, Resource.Layout.ListItem, dados);
        }
    }
}
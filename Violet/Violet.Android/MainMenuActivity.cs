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
    [Activity(Label = "MainMenuActivity", Icon = "@mipmap/icon", Theme = "@style/MainTheme")]
    public class MainMenuActivity : Activity
    {
        Button usuario, telefone, protegidos, registros, sobre;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MainMenu);
            RetrieveControls();
            SetButtons();
        }

        private void RetrieveControls()
        {
            usuario = FindViewById<Button>(Resource.Id.MainMenu_UserBT);
            telefone = FindViewById<Button>(Resource.Id.MainMenu_TelephonesBT);
            protegidos = FindViewById<Button>(Resource.Id.MainMenu_ProtectedsBT);
            registros = FindViewById<Button>(Resource.Id.MainMenu_RegistersBT);
            sobre = FindViewById<Button>(Resource.Id.MainMenu_AboutBT);
        }

        private void SetButtons()
        {
            usuario.Click += Usuario_Click;
            telefone.Click += Telefone_Click;
            protegidos.Click += Protegidos_Click;
            registros.Click += Registros_Click;
            sobre.Click += Sobre_Click;
        }

        private void Protegidos_Click(object sender, EventArgs e)
        {
            ProtectedsActivity.TipoListagem = ListingMode.Protegidos;
            StartActivity(typeof(ProtectedsActivity));
        }

        private void Sobre_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(AboutActivity1));
        }

        private void Registros_Click(object sender, EventArgs e)
        {
            ProtectedsActivity.TipoListagem = ListingMode.Registros;
            StartActivity(typeof(ProtectedsActivity));
        }

        private void Telefone_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(TelephoneActivity));
        }

        private void Usuario_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(UserDataBoardActivity));
        }
    }
}
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
using Violet.Droid.Persist_Storage;

namespace Violet.Droid
{
    [Activity(Label = "UserDataBoardActivity", Icon = "@mipmap/icon", Theme = "@style/MainTheme")]
    public class UserDataBoardActivity : Activity
    {
        TextView nome, telefone, endereco, cep, email;
        Button editData;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.UserDataBoard);
            RetrieveControls();
            LoadData();
        }

        private void RetrieveControls()
        {
            nome = FindViewById<TextView>(Resource.Id.UserDB_NameTV);
            telefone = FindViewById<TextView>(Resource.Id.UserDB_TelephoneTV);
            email = FindViewById<TextView>(Resource.Id.UserDB_emailTV);
            endereco = FindViewById<TextView>(Resource.Id.UserDB_AdressTV);
            cep = FindViewById<TextView>(Resource.Id.UserDB_CEPTV);
            editData = FindViewById<Button>(Resource.Id.UserDB_EditDataTB);

            editData.Click += EditData_Click;
        }

        private void EditData_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(RegisterUserActivity));
        }

        private void LoadData()
        {
            var data = UserData.GetUserData();
            nome.Text = data.Nome;
            email.Text = data.Email;
            telefone.Text = data.Telefone;
            endereco.Text = data.Endereco;
            cep.Text = data.CEP;
        }

    }
}
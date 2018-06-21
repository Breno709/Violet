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
    [Activity(Label = "RegisterUserActivity", Icon = "@mipmap/icon", Theme = "@style/MainTheme")]
    public class RegisterUserActivity : Activity
    {
        private Button button1;
        private EditText nomeText;
        private EditText telefoneText;
        private EditText emailText;
        private EditText enderecoText;
        private EditText cepText;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.RegisterUserForm);
            RetrieveControls();

            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = nomeText.Text;
            pessoa.Telefone = telefoneText.Text;
            pessoa.Email = emailText.Text;
            pessoa.Endereco = enderecoText.Text;
            pessoa.CEP = cepText.Text;

            UserData.SetUserData(pessoa);
            GoToMainPage();
        }

        private void RetrieveControls()
        {
            button1 = FindViewById<Button>(Resource.Id.submitButton1);
            nomeText = FindViewById<EditText>(Resource.Id.nameText1);
            telefoneText = FindViewById<EditText>(Resource.Id.telephoneText1);
            emailText = FindViewById<EditText>(Resource.Id.emailText1);
            enderecoText = FindViewById<EditText>(Resource.Id.adressText1);
            cepText = FindViewById<EditText>(Resource.Id.CEPText1);
        }

        private void GoToMainPage()
        {
            StartActivity(typeof(MainActivity));
        }
    }
}
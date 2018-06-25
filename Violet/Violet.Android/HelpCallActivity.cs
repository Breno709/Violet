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
    [Activity(Label = "HelpCallActivity", Icon = "@mipmap/icon", Theme = "@style/MainTheme")]
    public class HelpCallActivity : Activity
    {
        TextView nome, telefone, endereco;
        EditText obsText;
        Button telefones, okay;
        Random seed = new Random();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ChamadaPage);
            RetrieveControls();
            AddButtonFunctions();
            GenerateRandomCall();

        }

        /// <summary>
        /// Cria uma chamada de ajuda para exemplo
        /// </summary>
        private void GenerateRandomCall()
        {
            var qnt = DATABASE.Residentes.Length;
            var pessoa = DATABASE.Residentes[seed.Next(0, qnt)];

            nome.Text = pessoa.Nome;
            telefone.Text = pessoa.Telefone;
            endereco.Text = pessoa.Endereco;

            DATABASE.Registros.Add(new Registro(pessoa.Nome, DateTime.Now, DateTime.Now.TimeOfDay, false));
        }

        private void RetrieveControls()
        {
            nome = FindViewById<TextView>(Resource.Id.HP_NameTV);
            telefone = FindViewById<TextView>(Resource.Id.HP_TelephoneTV);
            endereco = FindViewById<TextView>(Resource.Id.HP_AdressTV);
            obsText = FindViewById<EditText>(Resource.Id.HP_ObsMT);
            telefones = FindViewById<Button>(Resource.Id.HP_TelephoneBT);
            okay = FindViewById<Button>(Resource.Id.HP_OkayBT);
        }

        private void AddButtonFunctions()
        {
            okay.Click += Okay_Click;
            telefones.Click += Telefones_Click;
        }

        private void Telefones_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(TelephoneActivity));
        }

        private void Okay_Click(object sender, EventArgs e)
        {
            DATABASE.Registros.Last().Obs = obsText.Text;
            StartActivity(typeof(MainActivity));
        }
    }
}
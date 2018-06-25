using System;
using System.Timers;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Violet.Droid.Persist_Storage;

namespace Violet.Droid
{

    [Activity(Label = "Violet", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        Button gotoMenu, callHelp;
        Timer temporizador = null;
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            InitApp();
        }

        /// <summary>
        /// Recupera o melhor modo de inicializar o aplicativo
        /// </summary>
        void InitApp()
        {
            
            //Se há dados de usuário armanezado no dispositivo, o aplicativo inicaliza no modo padrão.Caso contrário, abre-se um formulário de dados.
            if (Persist_Storage.UserData.HasData)
            {
                SetContentView(Resource.Layout.MainPage);
                RetrieveControls();
                SetButtons();
                SetTimer();
            }
            else
            {
                StartActivity(typeof(RegisterUserActivity));
            }
        }

        private void RetrieveControls()
        {
            gotoMenu = FindViewById<Button>(Resource.Id.MP_MenuBT);
            callHelp = FindViewById<Button>(Resource.Id.MP_HelpBT);
        }

        private void SetButtons()
        {
            gotoMenu.Click += GotoMenu_Click;
            callHelp.Click += CallHelp_Click;
        }

        Random intervaloRandomico = new Random();
        private void SetTimer()
        {
            temporizador = new Timer();
            temporizador.Interval = intervaloRandomico.Next(15000, 180000);
            temporizador.Elapsed += Temporizador_Elapse;
            temporizador.Start();
        }

        private void Temporizador_Elapse(object sender, ElapsedEventArgs e)
        {
            temporizador.Interval = intervaloRandomico.Next(60000, 210000);
            StartActivity(typeof(HelpCallActivity));
        }

        private void CallHelp_Click(object sender, EventArgs e)
        {
            var localDataEditor = Application.Context.GetSharedPreferences(UDDEF.SPFILE, FileCreationMode.Private).Edit();

            localDataEditor.Clear();
            localDataEditor.Commit();
        }

        private void GotoMenu_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(MainMenuActivity));
        }
    }
}


using System;

using Android.App;
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
        ImageButton gotoMenu, callHelp;
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
            }
            else
            {
                StartActivity(typeof(RegisterUserActivity));
            }
        }

        private void RetrieveControls()
        {
            gotoMenu = FindViewById<ImageButton>(Resource.Id.imageButton1);
            callHelp = FindViewById<ImageButton>(Resource.Id.imageButton2);
        }

        private void SetButtons()
        {
            gotoMenu.Click += GotoMenu_Click;
            callHelp.Click += CallHelp_Click;
        }

        private void CallHelp_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void GotoMenu_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(MainMenuActivity));
        }
    }

    public class ListTest : ListActivity
    {

        string[] teste;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            teste = new string[] { "maca", "banana", "acabate", "beterrada"};
            ListAdapter = new ArrayAdapter<string>(this, Resource.Layout.Registros, teste);
        }

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            base.OnListItemClick(l, v, position, id);
        }
    }
}


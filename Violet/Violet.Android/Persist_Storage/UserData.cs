using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Violet;

namespace Violet.Droid.Persist_Storage
{
    internal class UserData
    {
        /// <summary>
        /// Obtém os dados do usuário armazenados no dispositivo
        /// </summary>
        static internal IPessoa GetUserData()
        {
            var localData = Application.Context.GetSharedPreferences(UDDEF.SPFILE, FileCreationMode.Private);
            if (localData.GetBoolean(UDDEF.HASDATA, false))
            {
                var id = localData.GetString(UDDEF.GLOBAL_ID, null);
                var nome = localData.GetString(UDDEF.NAME, null);
                var telefone = localData.GetString(UDDEF.TELEPHONE, null);
                var email = localData.GetString(UDDEF.EMAIL, null);
                var endereco = localData.GetString(UDDEF.ADDRESS, null);
                var cep = localData.GetString(UDDEF.CEP, null);

                Guid Uid = Guid.Parse(id);

                return new Pessoa(Uid, nome, telefone, email, endereco, cep);
            }

            else return null;
        }

        /// <summary>
        /// Grava as informações de usuário no dispositivo
        /// </summary>
        static internal void SetUserData(IPessoa pessoa)
        {
            var localDataEditor = Application.Context.GetSharedPreferences(UDDEF.SPFILE, FileCreationMode.Private).Edit();
            localDataEditor.PutString(UDDEF.GLOBAL_ID, pessoa.ID.ToString("D"));
            localDataEditor.PutString(UDDEF.NAME, pessoa.Nome);
            localDataEditor.PutString(UDDEF.TELEPHONE, pessoa.Telefone);
            localDataEditor.PutString(UDDEF.EMAIL, pessoa.Email);
            localDataEditor.PutString(UDDEF.ADDRESS, pessoa.Endereco);
            localDataEditor.PutString(UDDEF.CEP, pessoa.CEP);
            localDataEditor.PutBoolean(UDDEF.HASDATA, true);
            localDataEditor.Commit();
        }

        /// <summary>
        /// Indica se há dados de usuário no aparelho.
        /// </summary>
        static internal bool HasData
        {
            get
            {
                var localData = Application.Context.GetSharedPreferences(UDDEF.SPFILE, FileCreationMode.Private);
                return localData.GetBoolean(UDDEF.HASDATA, false);
            }
        }

        static internal void ClearUserData()
        {
            var localDataEditor = Application.Context.GetSharedPreferences(UDDEF.SPFILE, FileCreationMode.Private).Edit();
            localDataEditor.Clear();
            localDataEditor.Commit();
        }
    }
}

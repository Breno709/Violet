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

namespace Violet.Droid.Persist_Storage
{
    /// <summary>
    /// User Data Definition - Define todos os nomes de dados a serem consultados na base de dados
    /// </summary>
    static internal class UDDEF
    {
        /// <summary>
        /// Shared Preferences file name
        /// </summary>
        static internal string SPFILE { get => "A4825CB0-3DFB-4C9B-9969-6D3666224E19"; }
        /// <summary>
        /// Indica se há dados salvos
        /// </summary>
        static internal string HASDATA { get => "A6E8B7F9-34A7-4DC2-99BE-60DD1E832B1D"; }
        /// <summary>
        /// ID do usuário
        /// </summary>
        static internal string GLOBAL_ID { get => "055C594C-7A8D-4D77-B95F-643507CC6C2C"; }
        /// <summary>
        /// Nome do usuário
        /// </summary>
        static internal string NAME { get => "1028EC5A-8A44-4A0C-9EB7-E5374482CF97"; }
        /// <summary>
        /// Telefone Do usuário
        /// </summary>
        static internal string TELEPHONE { get => "112C0398-469C-48EE-BFE8-310136719AF7"; }
        /// <summary>
        /// Email do usuário
        /// </summary>
        static internal string EMAIL { get => "7C011AA7-B85C-4E30-9572-8A23959F40B0"; }
        /// <summary>
        /// Endereço do usuario
        /// </summary>
        static internal string ADDRESS { get => "D45BF734-C633-4CCA-9836-387A5DD43A9B"; }
        /// <summary>
        /// CEP do usuário
        /// </summary>
        static internal string CEP { get => "E42785B8-1E1B-4C30-9839-9C6F2C3DF952"; }
    }
}
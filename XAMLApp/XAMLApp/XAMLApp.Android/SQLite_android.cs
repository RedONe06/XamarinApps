using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using XAMLApp.Data;
using XAMLApp.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(SQLite_android))]
namespace XAMLApp.Droid
{
    public class SQLite_android : ISQLite
    {
        private const string NOMEARQUIVODB = "Agendamento.db3";

        public SQLiteConnection PegarConexao()
        {
            var caminhoDB = Path.Combine(Android.OS.Environment.ExternalStorageDirectory.Path, NOMEARQUIVODB);
            return new SQLite.SQLiteConnection(caminhoDB);
        }
    }
}
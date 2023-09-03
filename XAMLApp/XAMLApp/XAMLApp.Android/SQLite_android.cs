using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XAMLApp.Data;
using XAMLApp.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(SQLite_android))]
namespace XAMLApp.Droid
{
    public class SQLite_android : ISQLite
    {
        public SQLiteConnection PegarConexao()
        {
            return new SQLite.SQLiteConnection("Agendamento.db3");
        }
    }
}
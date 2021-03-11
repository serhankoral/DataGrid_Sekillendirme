using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace DataBase
{
    class DB_Ayarlari
    {
        //Veri Tabanı Bağlantı Cümlesi ve gerekli SQLite componentlarinin değişkenleri  
        public static string db_connecting_string = @"Data Source=" + Environment.CurrentDirectory + "\\kitap.db;Version=3;New=False;Compress=True;Read Only=False;";
        public static SQLiteConnection db_connection_cmp = new SQLiteConnection(db_connecting_string);
        public static SQLiteCommand db_command_cmp = new SQLiteCommand();
        public static SQLiteDataAdapter db_dataadapter_cmp = new SQLiteDataAdapter();
        public static DataTable db_datatable = new DataTable();
        public static string db_listeleme_sql = "select * from tbl_KitapListesi";

    }
}

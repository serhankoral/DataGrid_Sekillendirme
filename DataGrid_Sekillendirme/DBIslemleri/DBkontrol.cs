using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows;

namespace DBbaglanti
{
    class DBbaglantiKontrol
    {
        public static string db_connecting_string = @"Data Source=" + Environment.CurrentDirectory + "\\kitap.db;Version=3;New=False;Compress=True;Read Only=False;";
        static SQLiteConnection db_Connection=new SQLiteConnection(db_connecting_string);
        public static Boolean DB_Baglanti_Durumu()
        {
            MessageBox.Show(DBbaglantiKontrol.db_connecting_string);
            try
            {
                if (db_Connection.State==ConnectionState.Closed)
                {
                    db_Connection.Open();                    
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Veri Tabanı Bağlatı Hatası!");
                return false; 
            }
            
        }

    }

}

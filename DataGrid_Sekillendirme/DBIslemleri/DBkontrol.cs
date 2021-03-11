using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows;

namespace DataBase
{
    class DB_Kontrol
    {
         public static SQLiteConnection DB_Baglanti_Durumu()
        {
            try
            {
                if (DB_Ayarlari.db_connection_cmp.State==ConnectionState.Closed)
                {
                    DB_Ayarlari.db_connection_cmp.Open();                    
                }
                return DB_Ayarlari.db_connection_cmp;
            }
            catch (Exception)
            {
                MessageBox.Show("Veri Tabanı Bağlatı Hatası!");
                return null; 
            }
            
        }

    }

}

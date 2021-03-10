using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using DBbaglanti;
using System.Data.SQLite;
using System.Data;
using System.Windows;


namespace DBbaglanti
{
    class DBlisteleme
    {
        public static void DBGrid_Listelme(DataGrid temp_datagrid)
        {
            try
            {
                    SQLiteConnection con = new SQLiteConnection(DBbaglantiKontrol.db_connecting_string);
                    SQLiteCommand db_command = new SQLiteCommand("select * from tbl_KitapListesi", con);
                    SQLiteDataAdapter db_adaper = new SQLiteDataAdapter(db_command);
                    DataTable db_table = new DataTable();
                    db_adaper.Fill(db_table);
                    temp_datagrid.ItemsSource = null;
                    temp_datagrid.ItemsSource = db_table.DefaultView;
                
            }
            catch (Exception)
            {
                MessageBox.Show("Veri Tabanı Sorgu Hatası.");
            }

        }

    }
}


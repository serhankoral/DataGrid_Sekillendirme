using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Data.SQLite;
using System.Data;
using System.Windows;


namespace DataBase
{
    class DB_Listeleme
    {
        public static void DBGrid_Listelme(DataGrid temp_datagrid)
        {
            try
            {

                DB_Ayarlari.db_datatable.Clear();
                DB_Ayarlari.db_command_cmp.CommandText = DB_Ayarlari.db_listeleme_sql;
                DB_Ayarlari.db_command_cmp.Connection = DB_Kontrol.DB_Baglanti_Durumu();
                DB_Ayarlari.db_dataadapter_cmp.SelectCommand = DB_Ayarlari.db_command_cmp;
                DB_Ayarlari.db_dataadapter_cmp.Fill(DB_Ayarlari.db_datatable);
                temp_datagrid.ItemsSource = null;
                temp_datagrid.ItemsSource = DB_Ayarlari.db_datatable.DefaultView;
            }
            catch (Exception)
            {
                MessageBox.Show("Veri Tabanı Sorgu Hatası.");
            }

        }

    }
}


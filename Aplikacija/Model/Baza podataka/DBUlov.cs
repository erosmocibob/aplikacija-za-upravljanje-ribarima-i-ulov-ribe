using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Data;


namespace Aplikacija
{
    public static class DBUlov  
    {
        static DBUlov()
        {
            SQLiteCommand com = Bazapodataka.con.CreateCommand();

            com.CommandText = @"CREATE TABLE IF NOT EXISTS Ulov (
				id integer primary key autoincrement,
                datum DateTime NOT NULL,
				pocetak_vrijeme nvarchar(32) NOT NULL,
                kraj_vrijeme nvarchar(32) NOT NULL,
                id_brod integer NOT NULL,
                id_kapetan integer NOT NULL,
                FOREIGN KEY(id_kapetan) REFERENCES KapetanBroda(id),
                FOREIGN KEY(id_brod) REFERENCES Brod(id))";

            com.ExecuteNonQuery();
            com.Dispose();            
        }

        public static long DodajUlov(Ulov a)
        {
            String sql = String.Format(@"INSERT INTO Ulov (datum, pocetak_vrijeme, kraj_vrijeme, id_brod, id_kapetan)
                    VALUES ({0},'{1}','{2}', {3}, {4});", a.Datum.ToFileTime(), a.Pocetak_vrijeme, a.Kraj_vrijeme, a.IDBrod, a.IDKBroda);
            SQLiteCommand cmd = new SQLiteCommand(sql, Bazapodataka.con);
            cmd.ExecuteScalar();

            long rowID = Bazapodataka.con.LastInsertRowId;
            cmd.Dispose();
            return rowID;
        }

        public static List<Ulov> DohvatiSveUlov()
        {
            List<Ulov> listaUlov = new List<Ulov>();
            SQLiteCommand c = Bazapodataka.con.CreateCommand();
             c.CommandText = "SELECT  id, datum, pocetak_vrijeme, kraj_vrijeme, id_kapetan from Ulov";
            SQLiteDataReader reader = c.ExecuteReader();

            while (reader.Read())
            {
                Ulov k = new Ulov();
                k.id = (long)reader["id"];
                k.Datum = DateTime.FromFileTime(reader.GetInt64(1));
                k.Pocetak_vrijeme = (string)reader["pocetak_vrijeme"];
                k.Kraj_vrijeme = (string)reader["kraj_vrijeme"];
                k.IDKBroda = (long)reader["id_kapetan"];
                listaUlov.Add(k);
            }
            reader.Dispose();
            c.Dispose();

            return listaUlov;
        }



        public static List<Ulov> DohvatiUlovKapID(long idKapetan)
        {
            List<Ulov> listaUlov = new List<Ulov>();
            SQLiteCommand c = Bazapodataka.con.CreateCommand();
            c.CommandText = string.Format("SELECT  id, datum, pocetak_vrijeme, kraj_vrijeme from Ulov WHERE id_kapetan = {0}", idKapetan);      
      
            SQLiteDataReader reader = c.ExecuteReader();
            while (reader.Read())
            {
                Ulov k = new Ulov();
                k.id = (long)reader["id"];
                k.Datum = DateTime.FromFileTime(reader.GetInt64(1));
                k.Pocetak_vrijeme = (string)reader["pocetak_vrijeme"];
                k.Kraj_vrijeme = (string)reader["kraj_vrijeme"];
                listaUlov.Add(k);
            }
            reader.Dispose();
            c.Dispose();

            return listaUlov;
        }


        public static List<Ulov> DohvatiOdDo(DateTime pocetakdatum, DateTime krajdatum, long idKapBroda)
        {
            List<Ulov> listaUlov = new List<Ulov>();
            SQLiteCommand c = Bazapodataka.con.CreateCommand();

            c.CommandText = String.Format (@"SELECT id, datum, pocetak_vrijeme, kraj_vrijeme FROM Ulov WHERE datum BETWEEN '{0}' AND '{1}' AND 
                                            id_kapetan='{2}' ORDER by datum ASC", pocetakdatum.ToFileTime(),krajdatum.ToFileTime(), idKapBroda);

            SQLiteDataReader reader = c.ExecuteReader();

            while (reader.Read())
            {
                Ulov k = new Ulov();
                k.id = (long)reader["id"];
                k.Datum = DateTime.FromFileTime(reader.GetInt64(1));
                k.Pocetak_vrijeme = (string)reader["pocetak_vrijeme"];
                k.Kraj_vrijeme = (string)reader["kraj_vrijeme"];
                listaUlov.Add(k);
            }

            reader.Dispose();
            c.Dispose();

            return listaUlov;
        }

        public static List<Ulov> DohvatiOdDoSvi(DateTime pocetakdatum, DateTime krajdatum)
        {
            List<Ulov> listaUlov = new List<Ulov>();
            SQLiteCommand c = Bazapodataka.con.CreateCommand();

            c.CommandText = String.Format(@"SELECT id, datum, pocetak_vrijeme, kraj_vrijeme FROM Ulov WHERE datum BETWEEN 
                                           '{0}' AND '{1}' ORDER by datum ASC", pocetakdatum.ToFileTime(), krajdatum.ToFileTime());

            SQLiteDataReader reader = c.ExecuteReader();
            while (reader.Read())
            {
                Ulov k = new Ulov();
                k.id = (long)reader["id"];
                k.Datum = DateTime.FromFileTime(reader.GetInt64(1));
                k.Pocetak_vrijeme = (string)reader["pocetak_vrijeme"];
                k.Kraj_vrijeme = (string)reader["kraj_vrijeme"];
                listaUlov.Add(k);
            }
            reader.Dispose();
            c.Dispose();

            return listaUlov;
        }

        public static void IzbrisiUloviStavke(long id_ulov)
        {
            SQLiteCommand c = Bazapodataka.con.CreateCommand();
            c.CommandText = string.Format(@"DELETE from UlovStavka WHERE UlovStavka.id_ulov='{0}';
                                                DELETE from Ulov WHERE id='{0}';", id_ulov);
            c.ExecuteNonQuery();
            c.Dispose();
        }

    }
}

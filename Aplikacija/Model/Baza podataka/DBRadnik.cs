using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Aplikacija
{
    public static class DBRadnik
    {
        static DBRadnik()
        {
            SQLiteCommand com = Bazapodataka.con.CreateCommand();
            com.CommandText = @"CREATE TABLE IF NOT EXISTS Radnik (
				    id integer primary key autoincrement,
				    ime nvarchar(32) NOT NULL,
				    prezime nvarchar(32) NOT NULL,
				    oib nvarchar(32) NOT NULL,
                    id_brod integer,
                    id_kapetan integer NOT NULL,
                    FOREIGN KEY(id_brod) REFERENCES Brod(id),
                    FOREIGN KEY(id_kapetan) REFERENCES KapetanBroda(id),
                    CONSTRAINT oib_unique UNIQUE(oib))";

            com.ExecuteNonQuery();
            com.Dispose();
        }

        public static void DodajRadnik(Radnik a)
        {
            SQLiteCommand c =  Bazapodataka.con.CreateCommand();

            c.CommandText = String.Format(@"INSERT INTO Radnik (ime, prezime, oib, id_brod, id_kapetan)
                    VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", a.Ime, a.Prezime, a.Oib, a.Id_Broda, a.IDKBroda);

            c.ExecuteNonQuery();
            c.Dispose();
        }

        public static List<Radnik> DohvatiRadnike(long idKBroda)
        {
            List<Radnik> listRadnik = new List<Radnik>();
            SQLiteCommand c = Bazapodataka.con.CreateCommand();

            c.CommandText = String.Format(@"SELECT Radnik.ime, Radnik.prezime,Radnik.oib, Radnik.id, Brod.ime as brod_ime FROM Radnik 
                        LEFT JOIN Brod ON Brod.id = Radnik.id_brod WHERE Radnik.id_kapetan = '{0}' ORDER BY Radnik.id_brod", idKBroda);

            SQLiteDataReader reader = c.ExecuteReader();
            while (reader.Read())
            {
                Radnik k = new Radnik();
                k.id = (long)reader["id"];
                k.Ime = (string)reader["ime"];
                k.Prezime = (string)reader["prezime"];
                k.Ime_Broda = reader["brod_ime"].ToString();
                k.Oib = (string)reader["oib"];
                listRadnik.Add(k);
            }

            reader.Dispose();
            c.Dispose();

            return listRadnik;
        }


        public static void IzbrisiRadnik(int id)
        {
            SQLiteCommand c = Bazapodataka.con.CreateCommand();
            c.CommandText = string.Format(@"DELETE FROM Radnik WHERE id = '{0}'", id);
            c.ExecuteNonQuery();
            c.Dispose();
        }


        public static List<Radnik> DohvatiRadnikeID(long id_brod)
        {
            List<Radnik> listRadnik = new List<Radnik>();
            SQLiteCommand c = Bazapodataka.con.CreateCommand();

            c.CommandText = string.Format("SELECT id, ime, prezime FROM Radnik WHERE id_brod= '{0}'", id_brod);
            SQLiteDataReader reader = c.ExecuteReader();

            while (reader.Read())
            {
                Radnik k = new Radnik();
                k.id = (long)reader["id"];
                k.Ime = (string)reader["ime"];
                k.Prezime = (string)reader["prezime"];
                listRadnik.Add(k);
            }
            reader.Dispose();
            c.Dispose();

            return listRadnik;
        }



        public static List<Radnik> DohvatiRadnikeNull()
        {
            List<Radnik> listRadnik = new List<Radnik>();
            SQLiteCommand c = Bazapodataka.con.CreateCommand();

            c.CommandText = string.Format("SELECT id, ime, prezime FROM Radnik WHERE id_brod is NULL");

            SQLiteDataReader reader = c.ExecuteReader();
            while (reader.Read())
            {
                Radnik k = new Radnik();
                k.id = (long)reader["id"];
                k.Ime = (string)reader["ime"];
                k.Prezime = (string)reader["prezime"];
                listRadnik.Add(k);
            }
            reader.Dispose();
            c.Dispose();

            return listRadnik;
        }

        public static void UpdateRadnikBrod(long id_broda, long id_radnika)
        {
            SQLiteCommand c = Bazapodataka.con.CreateCommand();
            c.CommandText = string.Format(@"UPDATE Radnik SET id_brod = '{0}' WHERE id= '{1}'", id_broda, id_radnika);
            c.ExecuteNonQuery();
            c.Dispose();
        }

        public static void RandnikIsNull(long id_radnik)
        {
            SQLiteCommand c = Bazapodataka.con.CreateCommand();
            c.CommandText = string.Format(@"UPDATE Radnik SET id_brod = NULL WHERE id = '{0}'", id_radnik);
            c.ExecuteNonQuery();

            c.Dispose();
        }

    }
}

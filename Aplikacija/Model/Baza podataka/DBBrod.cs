using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Aplikacija
{
    public static class DBBrod
    {
        static DBBrod()
        {
            SQLiteCommand com = Bazapodataka.con.CreateCommand();

            com.CommandText = @"CREATE TABLE IF NOT EXISTS Brod (
				id integer primary key autoincrement,
				ime nvarchar(32) NOT NULL,
                reg_oznaka nvarchar(32) NOT NULL,
                vrsta nvarchar(32) NOT NULL,
                id_kapetan integer NOT NULL,
                FOREIGN KEY(id_kapetan) REFERENCES KapetanBroda(id),
                CONSTRAINT reg_oznaka_unique UNIQUE(reg_oznaka))";

            com.ExecuteNonQuery();
            com.Dispose();
        }

        public static void DodajBrod(Brod a)
        {
            SQLiteCommand c = Bazapodataka.con.CreateCommand();

            c.CommandText = String.Format(@"INSERT INTO Brod (ime, reg_oznaka, vrsta,id_kapetan)
                    VALUES ('{0}', '{1}', '{2}', '{3}')", a.Ime, a.Reg_Ozn, a.Vrsta, a.IDKBroda);

            c.ExecuteNonQuery();
            c.Dispose();
        }

        public static List<Brod> DohvatiBrodove(long idKBroda)
        {
            List<Brod> listBrod = new List<Brod>();
            SQLiteCommand c = Bazapodataka.con.CreateCommand();

            c.CommandText = string.Format("SELECT Brod.id, Brod.ime, Brod.reg_oznaka, vrsta FROM Brod WHERE Brod.id_kapetan= '{0}'", idKBroda);

            SQLiteDataReader reader = c.ExecuteReader();
            while (reader.Read())
            {
                Brod k = new Brod();
                k.id = (long)reader["id"];
                k.Ime = (string)reader["ime"];
                k.Reg_Ozn = (string)reader["reg_oznaka"];
                k.Vrsta = (string)reader["vrsta"];

                listBrod.Add(k);
            }

            reader.Dispose();
            c.Dispose();

            return listBrod; 
        }

        public static void IzbrisiBrod(long id_broda)
        {
            SQLiteCommand c = Bazapodataka.con.CreateCommand();
            c.CommandText = string.Format(@"DELETE FROM Brod WHERE id = '{0}'", id_broda);
            c.ExecuteNonQuery();

            c.Dispose();
        }

        public static bool provjeraBrodRadnik(long id)
        {
            SQLiteCommand countCommand = Bazapodataka.con.CreateCommand();

            countCommand.CommandText = string.Format("SELECT count(*) FROM Radnik where Radnik.id_brod = '{0}'", id);
            long count = (long)countCommand.ExecuteScalar();
            countCommand.Dispose();

            if (count == 0)
            {
                return true;
            }
            return false;
        }

        public static void IzbrisiBrodUpdateRadnik(long id_broda)
        {
            SQLiteCommand c = Bazapodataka.con.CreateCommand();
            c.CommandText = string.Format(@"UPDATE Radnik SET id_brod = NULL WHERE id_brod = '{0}';
                                            DELETE from Brod WHERE id = '{0}'", id_broda);
            c.ExecuteNonQuery();

            c.Dispose();
        }


        public static List<Brod> DohvatiBrodoveID(long id_brod)
        {
            List<Brod> listBrod = new List<Brod>();
            SQLiteCommand c = Bazapodataka.con.CreateCommand();

            c.CommandText = string.Format( "SELECT ime, reg_oznaka, vrsta FROM Brod WHERE id= '{0}'", id_brod);

            SQLiteDataReader reader = c.ExecuteReader();

            while (reader.Read())
            {
                Brod k = new Brod();               
                k.Ime = (string)reader["ime"];
                k.Reg_Ozn = (string)reader["reg_oznaka"];
                k.Vrsta = (string)reader["vrsta"];

                listBrod.Add(k);
            }
            reader.Dispose();
            c.Dispose();

            return listBrod;
        }
        

        public static List<Brod> DohvatiBrodSRadnicima(long idKBroda)
        {
            List<Brod> listBrod = new List<Brod>();
            SQLiteCommand c = Bazapodataka.con.CreateCommand();

            c.CommandText = string.Format(@" SELECT Brod.ime, Brod.id from Brod, Radnik WHERE Brod.id = Radnik.id_brod AND Radnik.id_kapetan = '{0}'
                                              AND Radnik.id_brod IS NOT NULL GROUP by Brod.id",  idKBroda);

            SQLiteDataReader reader = c.ExecuteReader();

            while (reader.Read())
            {
                Brod k = new Brod();
                k.id = (long)reader["id"];
                k.Ime = (string)reader["ime"];
                listBrod.Add(k);
            }
            reader.Dispose();
            c.Dispose();

            return listBrod;
        }

    }
}

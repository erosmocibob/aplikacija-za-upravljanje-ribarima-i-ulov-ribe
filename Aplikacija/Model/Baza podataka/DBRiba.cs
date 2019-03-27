using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Aplikacija
{
    public static class DBRiba
    {
        static DBRiba()
        {
            SQLiteCommand com = Bazapodataka.con.CreateCommand();
            com.CommandText = @"CREATE TABLE IF NOT EXISTS Riba (
				    id integer primary key autoincrement,
				    naziv nvarchar(32) NOT NULL,
				    CONSTRAINT naziv_unique UNIQUE(naziv))";

            com.ExecuteNonQuery();
            com.Dispose();
        }

        public static void DodajRibu(Riba a)
        {
            SQLiteCommand c = Bazapodataka.con.CreateCommand();

            c.CommandText = String.Format(@"INSERT INTO Riba (naziv)
                    VALUES ('{0}')", a.Naziv);

            c.ExecuteNonQuery();
            c.Dispose();
        }

        public static List<Riba> DohvatiSveRibe()
        {
            List<Riba> listaRiba = new List<Riba>();
            SQLiteCommand c = Bazapodataka.con.CreateCommand();

            c.CommandText = "SELECT id,naziv FROM Riba";
            SQLiteDataReader reader = c.ExecuteReader();

            while (reader.Read())
            {
                Riba k = new Riba();
                k.id = (long)reader["id"];
                k.Naziv = (string)reader["naziv"];
                listaRiba.Add(k);
            }

            reader.Dispose();
            c.Dispose();

            return listaRiba;
        }

    }
}

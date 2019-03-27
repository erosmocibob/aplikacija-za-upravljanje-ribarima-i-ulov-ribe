using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Aplikacija
{
    public static class DBKapetanBroda
    {
        static DBKapetanBroda()
        {

            SQLiteCommand com = Bazapodataka.con.CreateCommand();
            com.CommandText = @"CREATE TABLE IF NOT EXISTS KapetanBroda (
				    id integer primary key autoincrement,
				    ime nvarchar(32) NOT NULL,
				    prezime nvarchar(32) NOT NULL,
				    sifra nvarchar(32) NOT NULL,
                    oib nvarchar(32) NOT NULL,
                    CONSTRAINT sifra_unique UNIQUE(sifra)
                    CONSTRAINT oib_unique UNIQUE(oib))";

            com.ExecuteNonQuery();
            com.Dispose();

        }

        public static void Dodaj(KapetanBroda a)
        {
            SQLiteCommand c = Bazapodataka.con.CreateCommand();

            c.CommandText = String.Format(@"INSERT INTO KapetanBroda (ime, prezime, sifra, oib)
                    VALUES ('{0}', '{1}', '{2}', '{3}' )", a.Ime, a.Prezime, a.Sifra, a.Oib);

            c.ExecuteNonQuery();
            c.Dispose();
        }

        public static bool prijavaKBroda(string ime, string sifra)
        {
            SQLiteCommand countCommand = Bazapodataka.con.CreateCommand();

            countCommand.CommandText = string.Format(@"SELECT count(*) FROM KapetanBroda where 
                                        KapetanBroda.ime ='{0}' and KapetanBroda.sifra ='{1}'", ime, sifra);
            long count = (long)countCommand.ExecuteScalar();
            countCommand.Dispose();

            if (count == 1)
            {
                return true;
            }
            
            return false;            
        }


        public static long prijavaKBrodatest(string ime, string sifra)
        {
            SQLiteCommand cmd = Bazapodataka.con.CreateCommand();

            cmd.CommandText = string.Format(@"SELECT id FROM KapetanBroda where 
                                        KapetanBroda.ime ='{0}' and KapetanBroda.sifra ='{1}'", ime, sifra);
            long id = (long)cmd.ExecuteScalar();
            return id;
        }


        public static List<KapetanBroda> DohvatiSveKB()
        {
            List<KapetanBroda> listKB = new List<KapetanBroda>();
            SQLiteCommand c = Bazapodataka.con.CreateCommand();

            c.CommandText = "SELECT id, ime, oib FROM KapetanBroda";

            SQLiteDataReader reader = c.ExecuteReader();
            while (reader.Read())
            {
                KapetanBroda k = new KapetanBroda();
                k.id = (long)reader["id"];
                k.Ime = (string)reader["ime"];
                k.Oib = (string)reader["oib"];
                listKB.Add(k);
            }

            reader.Dispose();
            c.Dispose();

            return listKB;

        }

    }
}

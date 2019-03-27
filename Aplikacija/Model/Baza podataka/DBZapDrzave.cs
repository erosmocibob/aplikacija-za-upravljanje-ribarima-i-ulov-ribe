using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace Aplikacija
{
    public class DBZapDrzave
    {
        static DBZapDrzave()
        {
            SQLiteCommand com = Bazapodataka.con.CreateCommand();
            com.CommandText = @"CREATE TABLE IF NOT EXISTS ZapDrzave (
				    id integer primary key autoincrement,
				    ime nvarchar(32) NOT NULL,
				    prezime nvarchar(32) NOT NULL,
				    sifra nvarchar(32) NOT NULL,
                    CONSTRAINT oib_sifra UNIQUE(sifra))";

            com.ExecuteNonQuery();
            com.Dispose();
        }

        public static void DodajZapDrzave(ZapDrzave a)
        {
            SQLiteCommand c = Bazapodataka.con.CreateCommand();

            c.CommandText = String.Format(@"INSERT INTO ZapDrzave (ime, prezime, sifra)
                    VALUES ('{0}', '{1}', '{2}')", a.Ime, a.Prezime, a.Sifra);

            c.ExecuteNonQuery();
            c.Dispose();
        }


        public static bool prijavaDrzZaposlenik(string ime, string sifra)
        {
            SQLiteCommand countCommand = Bazapodataka.con.CreateCommand();

            countCommand.CommandText = string.Format(@"SELECT count(*) FROM ZapDrzave where 
                                        ZapDrzave.ime ='{0}' and ZapDrzave.sifra ='{1}'", ime, sifra);
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


    }
}

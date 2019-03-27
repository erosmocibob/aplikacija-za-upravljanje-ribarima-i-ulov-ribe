using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Globalization;

namespace Aplikacija
{
    public static class DBStavkaUlov
    {
        static DBStavkaUlov()
        {
            SQLiteCommand com = Bazapodataka.con.CreateCommand();
            com.CommandText = @"CREATE TABLE IF NOT EXISTS UlovStavka (
				    id integer primary key autoincrement,
                    kolicina decimal NOT NULL,
				    id_riba integer NOT NULL,
                    id_ulov integer NOT NULL,
                    FOREIGN KEY(id_ulov) REFERENCES Ulov(id),
                    FOREIGN KEY(id_riba) REFERENCES Riba(id))";

            com.ExecuteNonQuery();
            com.Dispose();
        }

        public static void DodajStavku(UlovStavka a, long b)
        {
            SQLiteCommand c = Bazapodataka.con.CreateCommand();

            string kolicina = a.Kolicina.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture);
            c.CommandText = String.Format(@"INSERT INTO UlovStavka (kolicina, id_riba, id_ulov)
                    VALUES ({0}, {1}, {2})", kolicina, a.Riba.Id_ribe, b);
            c.ExecuteNonQuery();
            c.Dispose();
        }

        public static List<UlovStavka> DohvatiSveUlovStavke()
        {
            List<UlovStavka> listaStavki = new List<UlovStavka>();
            SQLiteCommand c = Bazapodataka.con.CreateCommand();

            c.CommandText = "SELECT id_ulov FROM UlovStavka";
            SQLiteDataReader reader = c.ExecuteReader();

            while (reader.Read())
            {
                UlovStavka k = new UlovStavka();
                k.Id_ulova = (long)reader["id_ulov"];
                listaStavki.Add(k);
            }
            reader.Dispose();
            c.Dispose();

            return listaStavki;
        }

        public static List<UlovStavka> DohvatiSveUlovStavkeIRibe()
        {
            List<UlovStavka> listaStavki = new List<UlovStavka>();
            SQLiteCommand c = Bazapodataka.con.CreateCommand();

            c.CommandText = @"SELECT  UlovStavka.id_riba, Riba.naziv,
                                UlovStavka.kolicina, UlovStavka.id_ulov
                                FROM UlovStavka LEFT JOIN Riba 
                                ON UlovStavka.id_riba = Riba.id";

            SQLiteDataReader reader = c.ExecuteReader();

            while (reader.Read())
            {
                Riba r = new Riba();
                UlovStavka k = new UlovStavka();
                r.id= (long)reader["id_riba"];
                r.Naziv = (string)reader["naziv"];
                k.Kolicina = Convert.ToDouble( reader["kolicina"]);
                k.Id_ulova = (long)reader["id_ulov"];
                k.Riba = r;

                listaStavki.Add(k);
            }
            reader.Dispose();
            c.Dispose();

            return listaStavki;
        }

        public static List<UlovStavka> DohvatiSveUlovStavkeIRibeUkupno()
        {
            List<UlovStavka> listaStavki = new List<UlovStavka>();
            SQLiteCommand c = Bazapodataka.con.CreateCommand();

            c.CommandText = @"SELECT  UlovStavka.id_riba, Riba.naziv,
                                SUM(UlovStavka.kolicina) as kolicina
                                FROM UlovStavka LEFT JOIN Riba 
                                ON UlovStavka.id_riba = Riba.id GROUP BY UlovStavka.id_riba";

            SQLiteDataReader reader = c.ExecuteReader();

            while (reader.Read())
            {
                Riba r = new Riba();
                UlovStavka k = new UlovStavka();
                r.id = (long)reader["id_riba"];
                r.Naziv = (string)reader["naziv"];
                k.Kolicina = Convert.ToDouble(reader["kolicina"]);
                k.Riba = r;
                listaStavki.Add(k);
            }

            reader.Dispose();
            c.Dispose();

            return listaStavki;

        }



        public static List<UlovStavka> DohvatiOdDoKBrod(DateTime pocetakdatum, DateTime krajdatum, long idKBrod)
        {
            List<UlovStavka> listaStavki = new List<UlovStavka>();
            SQLiteCommand c = Bazapodataka.con.CreateCommand();

            c.CommandText = String.Format(@"SELECT  UlovStavka.id_riba, Riba.naziv,
                SUM(UlovStavka.kolicina) as kolicina,
                Ulov.id_kapetan
                FROM UlovStavka
                LEFT JOIN Riba ON UlovStavka.id_riba = Riba.id
                LEFT JOIN Ulov ON UlovStavka.id_ulov = Ulov.id
                WHERE Ulov.id_kapetan = '{0}' and Ulov.datum BETWEEN '{1}' and '{2}'
                GROUP BY UlovStavka.id_riba", idKBrod, pocetakdatum.ToFileTime(), krajdatum.ToFileTime());

            SQLiteDataReader reader = c.ExecuteReader();
            while (reader.Read())
            {
                Riba r = new Riba();
                UlovStavka k = new UlovStavka();
                r.id = (long)reader["id_riba"];
                r.Naziv = (string)reader["naziv"];
                k.Kolicina = Convert.ToDouble(reader["kolicina"]);
                k.Riba = r;
                listaStavki.Add(k);             
            }

            reader.Dispose();
            c.Dispose();

            return listaStavki;
        }



        public static List<UlovStavka> DohvatiOdDoSveUlovStave(DateTime pocetakdatum, DateTime krajdatum)
        {
            List<UlovStavka> listaStavki = new List<UlovStavka>();
            SQLiteCommand c = Bazapodataka.con.CreateCommand();

            c.CommandText = String.Format(@"SELECT  UlovStavka.id_riba, Riba.naziv,
                SUM(UlovStavka.kolicina) as kolicina,
                Ulov.id_kapetan
                FROM UlovStavka
                LEFT JOIN Riba ON UlovStavka.id_riba = Riba.id
                LEFT JOIN Ulov ON UlovStavka.id_ulov = Ulov.id
                WHERE Ulov.datum BETWEEN '{0}' and '{1}'
                GROUP BY UlovStavka.id_riba",  pocetakdatum.ToFileTime(), krajdatum.ToFileTime());

            SQLiteDataReader reader = c.ExecuteReader();
            while (reader.Read())
            {
                Riba r = new Riba();
                UlovStavka k = new UlovStavka();
                r.id = (long)reader["id_riba"];
                r.Naziv = (string)reader["naziv"];
                k.Kolicina = Convert.ToDouble(reader["kolicina"]);
                k.Riba = r;
                listaStavki.Add(k);
            }

            reader.Dispose();
            c.Dispose();

            return listaStavki;
        }

    }
}


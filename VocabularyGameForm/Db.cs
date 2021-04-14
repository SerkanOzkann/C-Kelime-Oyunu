using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace VocabularyGameForm
{
    class Db
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public Db()
        {
            //Test
            con.ConnectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            cmd.Connection = con;
            con.Open();
            con.Close();
        }
        private Etap etapGetir(int harfSayisi)
        {
            Etap etap = null;
            con.Open();
            cmd.CommandText = "SELECT * FROM Games WHERE LEN(Answers)=" + harfSayisi+" ORDER BY NEWID()";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                etap = new Etap(int.Parse(dr[0].ToString()), dr[1].ToString().Trim(), dr[2].ToString().Trim().ToUpper());
            }
            con.Close();
            return etap;
        }
        private bool etapVarmi(Etap etap,List<Etap> etaplar)
        {
            foreach (Etap item in etaplar)
            {
                if (item.Id==etap.Id)
                {
                    return true;
                }
            }
            return false;
        }
        public List<Etap> etapListesiAl()
        {
            List<Etap> etaplar = new List<Etap>();
            Etap temp;
            for (int i = 4; i <= 10; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    do
                    {
                        temp = etapGetir(i);
                    }
                    while (etapVarmi(temp, etaplar));
                    etaplar.Add(temp);
                }
            }
            return etaplar;
        }
        public void EtapEkle(Etap etap)
        {
            con.Open();
            cmd.CommandText=("INSERT INTO Games(Questions,Answers) VALUES('" + etap.Soru + "','" + etap.Cevap + "')");
            cmd.ExecuteNonQuery();
            con.Close();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hastane
{
     class SQLBaglantisi       //Sınıfımızın adı..
    {
        public SqlConnection baglanti()       //Metodumuzun adı..   //baglan iste sınıftan türettiğimiz nesnenin adı
        {
            SqlConnection baglan = new SqlConnection ("Data Source=alibunsuz;Initial Catalog=HastaneProje;Integrated Security=True");
            baglan.Open ();
            return baglan;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    class ProductDal
    {

        SqlConnection _connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB; initial catalog=ETrade;integrated security=true");//bağlantı nesnesi oluşturmuş olduk
        // "\" c# da bir anlam ifade ettiğinden dolayı başına @ koyarak verilen girdiyi komple string olarak almasını sağlıyoruz
        //initial catalog hangi veri tabanına bağlanacağımı soyler
        //integrated security uzaktakı veri tabanına bağlanmak istediğimizde false yapmamız gerekmektedir
        //metodun dışında tanımladığımız için isimlendirme kurallarına göre başına " _ " eklendi

        public List<Product> GetAll()
        {
            ConnectionControl();

            SqlCommand command = new SqlCommand("Select * from products", _connection);

            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>(); //readerdaki verileri Liste atıcaz

            while (reader.Read()) //datayı yani readeri tek tek oku
            {
                Product product = new Product //her kaydı bu product içine atıcaz
                {
                    Id = Convert.ToInt32(reader["Id"]), //reader da gelen data obje türünde olduğu için integera dönüşümü sağlandı
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"])
                };

                products.Add(product); //Aktarılan elemanlar listeye ekleniyor
            }


            reader.Close();
            _connection.Close();
            return products;


        }

        public DataTable GetAll2() //günümüzde pek tercih edilmeyen bir metoddur memory bakımından pahalıya malolduğundan ve serileştirilemediğinden dolayı
        {

            SqlCommand command = new SqlCommand("Select * from products", _connection); //veri tabanı ile iletişim kurmaya yarar.  connectiona göndermiş oluyoruz
            //Select * from products -> yazdığımız verileri getirmeye yaramaktadır. 

            SqlDataReader reader = command.ExecuteReader();
            //ExecuteReader metodu vasitasıyla komutu çalıştırıyoruz. ExecuteReader tablo ile sonuç döndürmede kullanılmaktadır.

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            _connection.Close();
            return dataTable;


        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed) //bağlantı kapalıysa aç
            {
                _connection.Open(); //bağlantı açılır
            }
        }

        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Insert into Products values(@name,@unitPrice,@stockAmount)", _connection);
            command.Parameters.AddWithValue("@name", product.Name); //Parametre ile gelen product un name ini @name koyuyor kısaca veriyi veri tabanına aktarma işlemi
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);

            command.ExecuteNonQuery();

            _connection.Close();
        }

        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Update Products set Name=@name, UnitPrice=@unitPrice, StockAmount=@stockAmount where Id=@id", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@id", product.Id);
            command.ExecuteNonQuery();

            _connection.Close();

        }

        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Delete from Products where Id=@id", _connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();

            _connection.Close();

        }

    }
}

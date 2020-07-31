using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
//Lop provider
namespace QL_TRASUA_MTPARADISE.Data_Access_Obj
{
    public class DataProvider
    {
        
        //Giải thích thuật toán: tạo một static Dataprovider để có thể dùng trong toàn bộ chương trình khi có nhiều bảng dữ liệu đổ vào các datagridview, phương pháp này là design patnern singleton
        //Chức năng: kết nối với cơ sở dữ liệu và phân tích các câu lệnh truy vấn
        //Ở đây có 3 dạng truy vấn:
        /*
         - Truy vấn ExecuteQuery trả về một datatable
         - Truy vấn ExecuteNonQuery trả về số dòng thành công khi ta thực hiện các câu lệnh insert, delete, update
         - Truy vấn ExecuteScalar trả về giá trị cột đầu tiên của hàng đầu tiên thực hiện các lệnh count, max, min
         */
        private static DataProvider instance; //instance là biến duy nhất và được sử dụng trong suốt vòng đời của chương trình
        public static DataProvider Instance //đóng gói
        {
            get {if (instance == null) instance = new DataProvider(); return DataProvider.instance; } // nếu thể hiện ban đầu là null thì sẽ tạo ra một instance mới
            private set { DataProvider.instance = value; } //chỉ dữ liệu nội trong classn này mới được phép set dữ liệu vào
        }
        //hàm dựng - đảm bảo bên ngoài không thể tác động vào
        private DataProvider(){} 

        //chuỗi kết nối với database
        private string connectionstring = "Data Source=LAPTOP-DJ9J9KHA\\SQLEXPRESS;Initial Catalog=QL_TRASUA;Integrated Security=True";

        //hàm trả về một bảng kết quả dùng cho các câu lệnh select
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable(); //Khởi tạo bảng
            using (SqlConnection connection = new SqlConnection(connectionstring)) //Tự giải phóng dữ liệu sau khi thực thi khối lệnh
            {
                connection.Open(); //Mở kết nối
                SqlCommand command = new SqlCommand(query, connection); //Thực thi câu query truyền vào
                if (parameter != null)
                {
                    string[] listpara = query.Split(' '); //Cắt chuổi theo khoản trắng để đọc được các biến giá trị truyền vào
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@')) //Với mỗi chuỗi được cắt ra mà có chứa kí tự @, thì sẽ đực thêm vào trong danh sách biến
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command); //thực thi việc chạy câu lệnh

                adapter.Fill(data); //Đổ dữ liệu từ sql vào datatable
                connection.Close(); //Đóng kết nối
            }
            return data;
        }

        //Hàm trả về số dòng thành công dùng cho các câu lệnh INSERT UPDATE DELETE  
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0; // Khởi tạo số dòng là 0
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }

    }
}

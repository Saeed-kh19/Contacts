using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Contacts
{
    internal class ContactsRepository : IContactsRepository
    {
        private string connectionString = "Data Source=.;Initial Catalog=Contacts;Integrated Security=true";
        public bool Delete(int id)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Delete From Contacts where ContactID=@ContactID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ContactID", id);
                connection.Open();
                command.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool Insert(string name, string number, string email, int age, string address)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Insert Into Contacts (Name,PhoneNumber,Email,Age,Address) values (@Name,@PhoneNumber,@Email,@Age,@Address)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@PhoneNumber", number);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Age", age);
                command.Parameters.AddWithValue("@Address", address);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

        }

        public bool InsertFood(string name,int contactId)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Insert Into Foods (cid,foodName) values (@cid,@foodName)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@foodName", name);
                command.Parameters.AddWithValue("@cid", contactId);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

        }

        public DataTable Search(string parameter)
        {
            string query = "Select * From Contacts left join Foods on Contacts.ContactID = Foods.cid where Name like @parameter";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@parameter", "%" + parameter + "%");
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable SearchPhone(string parameter)
        {
            string query = "Select * From Contacts left join Foods on Contacts.ContactID = Foods.cid where PhoneNumber like @parameter";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@parameter", "%" + parameter + "%");
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }
        
        public DataTable SelectRow(int Id)
        {
            string query = "Select * From Contacts right join Foods on Contacts.ContactID = Foods.cid where ContactId=" + Id;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable showAll()
        {
            string query = "Select * From Contacts left join Foods on Contacts.ContactID = Foods.cid";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }


        public bool Update(int id, string name, string number, string email, int age, string address)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Update Contacts Set Name=@Name,PhoneNumber=@PhoneNumber,Email=@Email,Age=@Age,Address=@Address where ContactID=@ContactID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ContactID", id);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@PhoneNumber", number);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Age", age);
                command.Parameters.AddWithValue("@Address", address);
                connection.Open();
                command.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool UpdateFood(string name, int id)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Update Foods Set foodName=@foodName where cid=@cid";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@foodName", name);
                command.Parameters.AddWithValue("@cid", id);
                connection.Open();
                command.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

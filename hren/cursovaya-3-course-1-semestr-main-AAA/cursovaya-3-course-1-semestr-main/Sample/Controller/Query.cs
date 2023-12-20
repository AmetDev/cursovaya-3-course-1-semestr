using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml.Linq;

namespace Sample.Controller
{
    class Query
    {
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataAdapter dataAdapter;
        DataTable bufferTable;

        public Query(string Conn)
        {
            connection = new OleDbConnection(Conn);
            bufferTable = new DataTable();
        }

        public DataTable UpdatePerson()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM владельцы", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }
        public DataTable UpdateCars()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM автомобили", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }
        public DataTable UpdateFacts()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM факты_нарушения", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }
        public DataTable UpdateVidNarush()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM виды_нарушения", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }
        public DataTable UpdateInspector()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Инспектор", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }
        
        public void DeleteAll(string column, string arg, int ID)
        {
            try
            {
                MessageBox.Show(arg);
                MessageBox.Show(Convert.ToString(ID));
                connection.Open();
                command = new OleDbCommand($"DELETE FROM {arg} WHERE {column} = {ID}", connection);
                command.ExecuteNonQuery();
                connection.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public DataTable UpdateUsers()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Users", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }
        public void AddUsers(string Log, string Pas)
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Users(Log, Pas) VALUES(@Log, @Pas)", connection);
            command.Parameters.AddWithValue("Log", Log);
            command.Parameters.AddWithValue("Pas", Pas);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void Add(string FirstName, string LastName, string Category, int Expirience, bool IsAdmin)
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Teachers(FirstName, LastName, Category, Expirience) VALUES(@FirstName, @LastName, @Category, @Expirience)", connection);
            command.Parameters.AddWithValue("FirstName", FirstName);
            command.Parameters.AddWithValue("LastName", LastName);
            command.Parameters.AddWithValue("Category", Category);
            command.Parameters.AddWithValue("Expirience", Expirience);


            command.ExecuteNonQuery();
            connection.Close();
        }
        public void AddOwner(string FirstName, string LastName, string FatherName, string Category)
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO владельцы(Имя, Фамилия, Отчество, Категория_прав) VALUES(@FirstName, @LastName, @FatherName, @Category)", connection);
            command.Parameters.AddWithValue("FirstName", FirstName);
            command.Parameters.AddWithValue("LastName", LastName);
            command.Parameters.AddWithValue("FatherName", FatherName);
            command.Parameters.AddWithValue("Category", Category);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void AddCars(int code_vladelech, string model, string gover_number, string data_proizvod)
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO автомобили(код_владельца, модель, гос_номер, дата_производства) VALUES (@code_vladelech, @model, @gover_number, @data_proizvod)", connection);
            command.Parameters.AddWithValue("code_vladelech", code_vladelech);
            command.Parameters.AddWithValue("model", model);
            command.Parameters.AddWithValue("gover_number", gover_number);
            command.Parameters.AddWithValue("data_proizvod", data_proizvod);
            command.ExecuteNonQuery();
            connection.Close();
        }
        /*public DataTable GetIDOwnder(string firstName, string LastName, string FatherName) {

            connection.Open();
            dataAdapter = new OleDbDataAdapter($"SELECT код_владельца From владельцы WHERE Имя = {firstName} AND Фамилия={LastName} AND Отчество={FatherName}", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }*/
        public void AddVid_Narush(string name, int price)
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO виды_нарушения (наименование_вида_нарушения, [размер штрафа]) VALUES (@name, @price)", connection);
            command.Parameters.AddWithValue("name", name);
            command.Parameters.AddWithValue("price", price);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void AddFactsInDB(int avto, int insector, int vlad, int vid, string data, string fio, bool right)
        {
            connection.Open();
            command = new OleDbCommand("INSERT INTO факты_нарушения (код_автомобиля, код_инспектора, код_владельца, код_вида_нарушения, дата_нарушения, фио_водителя, [право управления]) VALUES (@avto, @insector, @vlad, @vid, @data, @fio, @right)", connection);
            command.Parameters.AddWithValue("@avto", avto);
            command.Parameters.AddWithValue("@insector", insector);
            command.Parameters.AddWithValue("@vlad", vlad);
            command.Parameters.AddWithValue("@vid", vid);
            command.Parameters.AddWithValue("@data", data);
            command.Parameters.AddWithValue("@fio", fio);
            command.Parameters.AddWithValue("@right", right);
            command.ExecuteNonQuery();
            connection.Close();

        }
        public void AddFML(string FML)
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Инспектор (фио_инспектора) VALUES (@FML)", connection);
            command.Parameters.AddWithValue("FML", FML);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public DataTable GetIDOwnder(string firstName, string LastName, string FatherName)
        {
            connection.Open();

            // Enclose string values in single quotes
            dataAdapter = new OleDbDataAdapter($"SELECT код_владельца FROM владельцы WHERE Имя = '{firstName}' AND Фамилия = '{LastName}' AND Отчество = '{FatherName}'", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);

            connection.Close();
            return bufferTable;
        }

      /*  public void Delete(int ID)
        {
            connection.Open();
            command = new OleDbCommand($"DELETE FROM Teachers WHERE ID = {ID}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }*/
        public void DeleteUsers(int ID)
        {
            connection.Open();
            command = new OleDbCommand($"DELETE FROM Users WHERE ID = {ID}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public bool CheckAdminLogin(string FirstName)
        {
            bool isValid = false;
            connection.Open();
            command = new OleDbCommand($"SELECT FirstName FROM Teachers WHERE FirstName ={FirstName}", connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.ExecuteNonQuery();
            // Выполняем запрос
            OleDbDataReader reader = command.ExecuteReader();

            // Проверяем, есть ли записи с таким логином
            if (reader.HasRows)
            {
                isValid = true;
            }
            // Закрываем ридер и соединение
            reader.Close();
            connection.Close();
            return isValid;
        }  
        public bool CheckAdminPassword(string Expirience)
        {
            bool isValid = false;
            connection.Open();
            command = new OleDbCommand($"SELECT Expirience FROM Teachers WHERE Expirience ={Expirience}", connection);
            command.Parameters.AddWithValue("@Expirience", Expirience);
            command.ExecuteNonQuery();
            // Выполняем запрос
            OleDbDataReader reader = command.ExecuteReader();

            // Проверяем, есть ли записи с таким логином
            if (reader.HasRows)
            {
                isValid = true;
            }

            // Закрываем ридер и соединение
            reader.Close();
            connection.Close();
            return isValid;
        }
        public bool CheckAdminAdmin(string FirstName)
        {
            bool isValid = false;
            connection.Open();
            command = new OleDbCommand($"SELECT IsAdmin FROM Teachers WHERE FirstName = {FirstName}", connection);
            command.ExecuteNonQuery();
            // Выполняем запрос
            OleDbDataReader reader = command.ExecuteReader();

            // Проверяем, есть ли записи с таким логином
            if (reader.HasRows)
            {
                isValid = true;
            }
            // Закрываем ридер и соединение
            reader.Close();
            connection.Close();
            return isValid;
        }
    }
}

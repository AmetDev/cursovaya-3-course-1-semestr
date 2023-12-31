﻿using System;
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
        public DataTable UpdateUsers()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Users", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }


        public DataTable UpdateClients()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Клиенты", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }
        public DataTable UpdateProduct()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Продукция", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }
        public DataTable UpdateComp()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Характеристики", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }
        public DataTable UpdateOffer()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Сделки", connection);
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
        public void AddClients(string FirstName, string LastName, string FatherName, string Category, string Adres)
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Клиенты(Фамилия, Имя, Отчество, Телефон, Адрес) VALUES(@FirstName, @LastName, @FatherName, @Category, @Adres)", connection);
            command.Parameters.AddWithValue("FirstName", FirstName);
            command.Parameters.AddWithValue("LastName", LastName);
            command.Parameters.AddWithValue("FatherName", FatherName);
            command.Parameters.AddWithValue("Category", Category);
            command.Parameters.AddWithValue("Adres", Adres);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void   AddProduct(string FirstName, int LastName, string FatherName)
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Продукция(Наименование, Цена, [Вид продукции]) VALUES(@FirstName, @LastName, @FatherName)", connection);
            command.Parameters.AddWithValue("FirstName", FirstName);
            command.Parameters.AddWithValue("LastName", LastName);
            command.Parameters.AddWithValue("FatherName", FatherName);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Haracteristiki(int code, string name, string proc, string gz, string core, string RAM, string countRAM, string typehard, string obem, string videocard, string data)
        {
            connection.Open();
            command = new OleDbCommand("INSERT INTO Характеристики([Код продукции], [Наименование], [Процессор], [Частота процессора], [Кол-во ядер], [Объем ОЗУ], [Кол-во плат ОЗУ], [Тип накопителя], [Объем накопителя], [Видеокарта], [Дата сборки]) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", connection);
            command.Parameters.AddWithValue("@code", code);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@proc", proc);
            command.Parameters.AddWithValue("@gz", gz);
            command.Parameters.AddWithValue("@core", core);
            command.Parameters.AddWithValue("@RAM", RAM);
            command.Parameters.AddWithValue("@countRAM", countRAM);
            command.Parameters.AddWithValue("@typehard", typehard);
            command.Parameters.AddWithValue("@obem", obem);
            command.Parameters.AddWithValue("@videocard", videocard);
            command.Parameters.AddWithValue("@data", data);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void AddOffer(int code0, int code1, string offerdata, int priceoffer)
        {
            connection.Open();
            command = new OleDbCommand("INSERT INTO Сделки([Код клиента], [Код продукции], [Дата сделки], Сумма) VALUES (?, ?, ?, ?) ", connection);
            command.Parameters.AddWithValue("@code0", code0);
            command.Parameters.AddWithValue("@code1", code1);
            command.Parameters.AddWithValue("@offerdata", offerdata);
            command.Parameters.AddWithValue("@priceoffer", priceoffer);
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

        public void Delete(int ID)
        {
            connection.Open();
            command = new OleDbCommand($"DELETE FROM Teachers WHERE ID = {ID}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
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

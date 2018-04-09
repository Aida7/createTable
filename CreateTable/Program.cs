﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CreateTable
{
    public class Program
    {
        private SqlConnection CreateConection()
        {
                SqlConnection connection = new SqlConnection();
                string connectionString =
                 "Data Source=sql;" +
                 "Initial Catalog=DB_171;" +
                 "Integrated Security=SSPI;" +
                 "MultipleActiveResultSets=True";
                connection.ConnectionString = connectionString;
            return connection;
         }
        public void CreateTable()
        {
            using (SqlConnection connection = CreateConection())
            {
              SqlCommand command =
              new SqlCommand("CREATE TABLE gruppa(" +
                            "Id int not null identity primary key, " +
                            "name varchar(50) not null,",
                             connection);
                        connection.Open();
                        command.ExecuteNonQuery();
            }
        }
        static void Main(string[] args)
        {
              
        }
    }
}

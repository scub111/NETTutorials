using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace SQLite
{
    public static class SQLiteDataReaderExtention
    {
        public static byte[] GetSQLiteBytes(this SQLiteDataReader reader, int index, long fieldOffset = 0)
        {
            const int CHUNK_SIZE = 2 * 1024;
            var buffer = new byte[CHUNK_SIZE];
            long bytesRead;
            using (var stream = new MemoryStream())
            {
                while ((bytesRead = reader.GetBytes(index, fieldOffset, buffer, 0, buffer.Length)) > 0)
                {
                    stream.Write(buffer, 0, (int)bytesRead);
                    fieldOffset += bytesRead;
                }
                return stream.ToArray();
            }
        }
    }

    class Program
    {
        class LiteRow
        {
            public LiteRow(int id, DateTime date, byte[] data)
            {
                Id = id;
                Date = date;
                Data = data;
            }

            public int Id { get; set; }
            public DateTime Date { get; set; }
            public byte[] Data { get; set; }
        }

        public static byte[] GenerateBytes(int count)
        {
            var result = new byte[count];
            for (var i = 0; i < count; i++)
                result[i] = 15;

            return result;
        }

        static void Main(string[] args)
        {
            var dbFileName = "buffer.sqlite";
            var sqlConnection = new SQLiteConnection(string.Format("Data source={0}; Version=3;", dbFileName));
            sqlConnection.Open();

            using (var sqlCommand2 =
                new SQLiteCommand(
                    $"VACUUM",
                    sqlConnection))
            {
                sqlCommand2.ExecuteNonQuery();
            }

            var sqlCommand = new SQLiteCommand(sqlConnection);
            sqlCommand.CommandText = "CREATE TABLE IF NOT EXISTS tblTest (Id INTEGER PRIMARY KEY AUTOINCREMENT, Date REAL, Data BLOB)";
            sqlCommand.ExecuteNonQuery();

            var dtTest = new DateTime(2017, 1, 1, 12, 12, 12);
            var date = dtTest.ToOADate();
            var data = GenerateBytes(1 * 1024 * 1024);

            var t0 = DateTime.Now;
            for (var i = 0; i < 10; i++)
            {
                sqlCommand.CommandText = "INSERT INTO tblTest (Date, Data) VALUES (@Date, @Data)";
                sqlCommand.Parameters.Add("@Date", DbType.Double).Value = date;
                sqlCommand.Parameters.Add("@Data", DbType.Binary, 20).Value = data;
                sqlCommand.ExecuteNonQuery();
            }

            var diff = DateTime.Now - t0;

            var dTable = new DataTable();

            t0 = DateTime.Now;

            sqlCommand.CommandText = "SELECT Id, Date, Data FROM tblTest";
            var liteRows = new List<LiteRow>();   

            using (var reader = sqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    var idR = reader.GetInt32(0);

                    var dateR = reader.GetDouble(1);
                    var dtR = DateTime.FromOADate(dateR);

                    var dataR = reader.GetSQLiteBytes(2);

                    liteRows.Add(new LiteRow(idR, dtR, dataR));
                }
            }
            var diff2 = DateTime.Now - t0;

            sqlCommand.CommandText = "DROP TABLE tblTest";
            sqlCommand.ExecuteNonQuery();

            sqlCommand.CommandText = "VACUUM";
            sqlCommand.ExecuteNonQuery();
        }
    }
}

using System;
using System.IO;

namespace Marvel.DataSource
{
    public class DataSource_JSON : IDataSource
    {
        readonly string path = @"C:\Users\kippe\source\repos\Marvel\Marvel.DataSource\file.json";
        public string Load()
        {
            return File.ReadAllText(path);
        }

        public void Save(string data)
        {
            throw new NotImplementedException();
        }
    }
}

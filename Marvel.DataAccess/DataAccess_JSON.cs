using Marvel.DataSource;
using Marvel.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;

namespace Marvel.DataAccess
{
    public class DataAccess_JSON : IDataAccess
    {
        readonly string path = @"C:\Users\kippe\source\repos\Marvel\Marvel.DataSource\file.json";
        readonly IDataSource  _datasource;

        public DataAccess_JSON(IDataSource DataSource)
        {
            _datasource = DataSource;
        }

        public IEnumerable<ComplainDTO> LoadAll()
        {
            throw new NotImplementedException();
        }

        public ComplainDTO LoadByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Save(ComplainDTO complain)
        {

            string json = File.ReadAllText(path);
            List<ComplainDTO> complains = JsonConvert.DeserializeObject<List<ComplainDTO>>(json);
            complains.Add(complain);
            json = JsonConvert.SerializeObject(complains);
            File.WriteAllText(path,json);

        }

    }
}

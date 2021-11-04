namespace Marvel.DataSource
{
    public interface IDataSource
    {
        public string Load();
        public void Save(string data);
    }
}
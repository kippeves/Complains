using Marvel.DTO;
using System.Collections.Generic;

namespace Marvel.DataAccess
{
    public interface IDataAccess
    {
        public IEnumerable<ComplainDTO> LoadAll();
        public void Save(ComplainDTO d);
        public ComplainDTO LoadByID(int id);
    }
}
using CSharpExample.Contracts;
using CSharpExample.Entities;
using System.Collections.Generic;
using System.Linq;

namespace CSharpExample.Repositories
{
    public class PositionTypeRepository : IRepository<PositionType>
    {
        private static List<PositionType> _positions = new List<PositionType>()
        {
            new PositionType() { Id = 1, Name = "Programmer" },
            new PositionType() { Id = 2, Name = "Manager" }
        };

        public List<PositionType> GetAll()
        {
            return _positions;
        }

        public PositionType Update(PositionType pos)
        {
            var toUpdate = _positions.FirstOrDefault(e => e.Id == pos.Id);
            if (toUpdate != null)
            {
                toUpdate.Name = pos.Name;
            }
            return toUpdate;
        }

        public PositionType Insert(PositionType pos)
        {
            pos.Id = _positions.Count;
            _positions.Add(pos);
            return pos;
        }

        public void Delete(PositionType employee)
        {
            _positions.Remove(employee);
        }
    }
}
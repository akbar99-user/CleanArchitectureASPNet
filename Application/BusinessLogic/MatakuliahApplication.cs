using Domain.Entities;
using Domain.Interface.Persistence;
using Domain.Interfaces.Application;
using Domain.Interfaces.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BusinessLogic
{
    public class MatakuliahApplication : IMatakuliahApplication
    {
        private readonly IMatakuliahPersistence _persistence;
        public MatakuliahApplication(IMatakuliahPersistence persistence)
        {
            _persistence = persistence;
        }
        public async Task<List<Matakuliah>> GetRecords()
        {
            return await _persistence.GetRecords();
        }
        public async Task<Matakuliah> GetRecord(int id)
        {
            return await _persistence.GetRecord(id);
        }
        public async Task<int> Insert(Matakuliah entity)
        {
            return await _persistence.Insert(entity);
        }

        public async Task<int> Update(Matakuliah entity)
        {
            return await _persistence.Update(entity);
        }
        public async Task<int> Delete(int id)
        {
            return await _persistence.Delete(id);
        }
    }
}

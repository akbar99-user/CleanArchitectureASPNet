using Domain.Entities;
using Domain.Interfaces.Application;
using Domain.Interfaces.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BusinessLogic
{
    public class MahasiswaApplication : IMahasiswaApplication
    {
        private readonly IMahasiswaPersistence _persistence;
        public MahasiswaApplication(IMahasiswaPersistence persistence)
        {
            _persistence = persistence;
        }
        public async Task<List<Mahasiswa>> GetRecords()
        {
            return await _persistence.GetRecords();
        }
        public async Task<Mahasiswa> GetRecord(int id)
        {
            return await _persistence.GetRecord(id);
        }
        public async Task<int> Insert(Mahasiswa entity)
        {
            return await _persistence.Insert(entity);
        }

        public async Task<int> Update(Mahasiswa entity)
        {
            return await _persistence.Update(entity);
        }
        public async Task<int> Delete(int id)
        {
            return await _persistence.Delete(id);
        }
    }
}

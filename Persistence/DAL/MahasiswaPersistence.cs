using Domain.Entities;
using Domain.Interfaces.Persistence;
using Persistence.Database;
using Persistence.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.DAL
{
    public class MahasiswaPersistence : BasePersistence, IMahasiswaPersistence
    {
        private readonly DatabaseContext _context;
        public MahasiswaPersistence(DatabaseContext context)
        {
            _context = context;
        }
        public async Task<List<Mahasiswa>> GetRecords()
        {
            var result = await GetRecordsToDB<Mahasiswa>(_context);
            return result;
        }
        public async Task<Mahasiswa> GetRecord(int id)
        {
            var result = await GetRecordToDB<Mahasiswa>(_context, id);
            return result;
        }
        public async Task<int> Insert(Mahasiswa entity)
        {
            var result = await InsertToDB(_context, entity);
            return result;
        }
        public async Task<int> Update(Mahasiswa entity)
        {
            var result = await UpdateToDB(_context, entity.MahasiswaID, entity);
            return result;
        }
        public async Task<int> Delete(int id)
        {
            var result = await DeleteToDB<Mahasiswa>(_context, id);
            return result;
        }
    }
}

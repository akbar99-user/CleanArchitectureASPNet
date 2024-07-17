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
    public class MatakuliahPersistence : BasePersistence, IMatakuliahPersistence
    {
        private readonly DatabaseContext _context;
        public MatakuliahPersistence(DatabaseContext context)
        {
            _context = context;
        }
        public async Task<List<Matakuliah>> GetRecords()
        {
            var result = await GetRecordsToDB<Matakuliah>(_context);
            return result;
        }
        public async Task<Matakuliah> GetRecord(int id)
        {
            var result = await GetRecordToDB<Matakuliah>(_context, id);
            return result;
        }
        public async Task<int> Insert(Matakuliah entity)
        {
            var result = await InsertToDB(_context, entity);
            return result;
        }
        public async Task<int> Update(Matakuliah entity)
        {
            var result = await UpdateToDB(_context, entity.MatakuliahID, entity);
            return result;
        }
        public async Task<int> Delete(int id)
        {
            var result = await DeleteToDB<Matakuliah>(_context, id);
            return result;
        }
    }
}

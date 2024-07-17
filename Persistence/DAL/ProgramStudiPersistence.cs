using Domain.Entities;
using Domain.Interface.Persistence;
using Microsoft.EntityFrameworkCore;
using Persistence.Database;
using Persistence.Utilities;

namespace Persistence.DAL
{
    public class ProgramStudiPersistence : BasePersistence, IProgramStudiPersistence
    {
        private readonly DatabaseContext _context;
        public ProgramStudiPersistence(DatabaseContext context)
        {
            _context = context;
        }
        public async Task<List<ProgramStudi>> GetRecords()
        {
            var result = await GetRecordsToDB<ProgramStudi>(_context);
            return result;
        }
        public async Task<ProgramStudi> GetRecord(int id)
        {
            var result = await GetRecordToDB<ProgramStudi>(_context, id);
            return result;
        }
        public async Task<int> Insert(ProgramStudi entity)
        {
            var result = await InsertToDB(_context, entity);
            return result;
        }
        public async Task<int> Update(ProgramStudi entity)
        {
            var result = await UpdateToDB(_context, entity.ProgramStudiID, entity);
            return result;
        }
        public async Task<int> Delete(int id)
        {
            var result = await DeleteToDB<ProgramStudi>(_context, id);
            return result;
        }
    }
}

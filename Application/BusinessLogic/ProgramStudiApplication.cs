using Domain.Entities;
using Domain.Interface.Application;
using Domain.Interface.Persistence;

namespace Application.BusinessLogic
{
    public class ProgramStudiApplication : IProgramStudiApplication
    {
        private readonly IProgramStudiPersistence _persistence;
        public ProgramStudiApplication (IProgramStudiPersistence persistence)
        {
            _persistence = persistence;
        }
        public async Task<List<ProgramStudi>> GetRecords()
        {
            return await _persistence.GetRecords();
        }
        public async Task<ProgramStudi> GetRecord(int id)
        {
            return await _persistence.GetRecord(id);
        }
        public async Task<int> Insert(ProgramStudi entity)
        {
            return await _persistence.Insert(entity);
        }

        public async Task<int> Update(ProgramStudi entity)
        {
            return await _persistence.Update(entity);
        }
        public async Task<int> Delete(int id)
        {
            return await _persistence.Delete(id);
        }

    }
}

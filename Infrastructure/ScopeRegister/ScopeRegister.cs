using Application.BusinessLogic;
using Domain.Interface.Application;
using Domain.Interface.Persistence;
using Domain.Interfaces.Application;
using Domain.Interfaces.Persistence;
using Persistence.DAL;

namespace Infrastructure.ScopeRegister
{
    public class ScopeRegister
    {
        public static void AddScopes(IServiceCollection services)
        {
            services.AddScoped<IProgramStudiPersistence, ProgramStudiPersistence>();
            services.AddScoped<IProgramStudiApplication, ProgramStudiApplication>();
            services.AddScoped<IMatakuliahPersistence, MatakuliahPersistence>();
            services.AddScoped<IMatakuliahApplication, MatakuliahApplication>();
            services.AddScoped<IMahasiswaPersistence, MahasiswaPersistence>();
            services.AddScoped<IMahasiswaApplication, MahasiswaApplication>();
        }
    }
}

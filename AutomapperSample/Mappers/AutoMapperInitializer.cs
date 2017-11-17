using AutoMapper;

namespace AutomapperSample.Mappers
{
    public static class AutoMapperInitializer
    {
        public static void InitMappers()
        {
            Mapper.Initialize(cfg => cfg.AddProfiles(typeof(AutoMapperInitializer).Assembly));
            Mapper.Configuration.AssertConfigurationIsValid();
        }
    }
}
using OnlineCourseApp.Domain.Courses;

namespace OnlineCourseApp.Infrastructure.Database.Courses
{
    public class EfCoreModuleRepo : IModuleRepo
    {
        public static int _nextId = 1;
        private static List<Module> _modules = new List<Module>();
        public static int Add(Module module)
        {
            module.Id = _nextId++;
            _modules.Add(module);
            return module.Id;
        }
        public static void Delete(int id)
        {
            var module = _modules.FirstOrDefault(m => m.Id == id);
            if (module != null)
            {
                _modules.Remove(module);
            }
        }
        public static List<Module> GetAllModules()
        {
            return _modules;
        }
        public static void Update(Module updatedModule)
        {
            var module = _modules.FirstOrDefault(m => m.Id == updatedModule.Id);
            if (module != null)
            {
                module.Title = updatedModule.Title;
                module.CourseId = updatedModule.CourseId;
            }
        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyPolyglotWeb.Constants;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Repositories.IRepository;
using System;

namespace MyPolyglotWeb.Models
{
    public static class HostSeed
    {
        public static IHost Seed(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var serviceProvider = scope.ServiceProvider;
                CreateLessons(serviceProvider);
            }
            return host;
        }

        private static void CreateLessons(IServiceProvider serviceProvider)
        {
            var lessonRepository = serviceProvider.GetService<ILessonRepository>();
            foreach (var lessonName in CustomConst.LessonsNames)
            {
                if (!lessonRepository.IsExistByLessonName(lessonName))
                {
                    lessonRepository.Save(new LessonDB() { LessonName = lessonName });
                }
            }
        }
    }
}

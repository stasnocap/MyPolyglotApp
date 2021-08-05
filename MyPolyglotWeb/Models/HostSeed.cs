using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyPolyglotWeb.Models.DomainModels;
using MyPolyglotWeb.Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPolyglotWeb.Models
{
    public static class HostSeed
    {
        public static IEnumerable<string> LessonNames = Enumerable.Empty<string>().Concat(new[]
        {
            "Базовая форма глагола",
            "Местоимения. Вопросительные слова",
            "Глагол to be. Предлоги места. Like/Want",
            "Притяжательные местоимения",
            "Профессии. Этикет",
            "Степени сравнения прилагательных. Указательные местоимения",
            "Слова-параметры. Употребление muck и many, little и few",
            "Предлоги и параметры времени",
            "There is / There are",
            "Предлоги направления и движения",
            "Модальные глаголы can, must, should",
            "Continuous",
            "Описание людей. Погода",
            "Повелительное наклонение",
            "Фразовые глаголы",
            "Present Perfect",
            "Past Perfect",
            "Future Perfect",
            "Perfect Tenses",
            "Present Perfect Continuous",
            "Past Perfect Continuous",
            "Future Perfect Continuous",
            "Perfect Continuous Tenses",
            "Present Participle Simple",
            "Past Participle",
            "Present Participle Perfect",
            "The Participle",
            "Simple Passive",
            "Continuous Passive",
            "Perfect Passive",
            "Passive Voice"
        });

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
            foreach (var lessonName in LessonNames)
            {
                if (!lessonRepository.IsExistByLessonName(lessonName))
                {
                    lessonRepository.Save(new LessonDB() { LessonName = lessonName });
                }
            }
        }
    }
}

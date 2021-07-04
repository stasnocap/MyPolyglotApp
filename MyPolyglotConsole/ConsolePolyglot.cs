using System;
using MyPolyglotCore;

namespace MyPolyglotConsole
{
    public class ConsolePolyglot
    {
        public void Run()
        {
            Home();
            Exercises();
            while (!int.TryParse(Console.ReadKey().KeyChar.ToString(), out int n))
            {
                Exercises();
            }

            var generator = new LessonGenerator();
            var lesson = generator.GenerateFirstLesson();

            foreach (var exercise in lesson.Exercises)
            {
                Console.Clear();
                Console.WriteLine(exercise.RusPhrase);
                Console.WriteLine("Options:");
                foreach (var option in exercise.GetOptions())
                {
                    Console.Write($" {option}");
                }
                Console.ReadKey();
            }

        }

        private void Home()
        {
            Console.WriteLine("Hi! It is new MyPolyglot app, which you can use to improve your English lvl! Enjoy!");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        private void Exercises()
        {
            Console.Clear();
            Console.WriteLine("Please, type number of exercise to start training.");
            Console.WriteLine("1. Exercise 1. Basic verb form.");
            Console.WriteLine("E.g.: 1; 5; etc.");
        }
    }
}
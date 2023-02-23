using Autofac;
using Backend.Models;
using Newtonsoft.Json;
using System;
using System.IO;

namespace Backend.Services
{
    public class ApplicationService
    {
        IWriter _writer;
        IReader _reader;
        IValidator _validator;
        ITaxCalculator _taxCalculator;
        public ApplicationService(IWriter writer, IReader reader, IValidator validator, ITaxCalculator taxCalculator)
        {
            _writer = writer;
            _reader = reader;
            _validator = validator;
            _taxCalculator = taxCalculator;
        }

        public void Run()
        {
            var userChoice = DisplayMenu();
            if (userChoice == 1)
            {
                RunMovieStarsList();
            }
            else if (userChoice == 2)
            {
                RunCalculateNetSalary();
            }
        }

        private int DisplayMenu()
        {
            _writer.WriteLine("Main Menu");
            _writer.WriteLine("------");
            _writer.WriteLine("");
            _writer.WriteLine("1. View Movie Stars List");
            _writer.WriteLine("2. Calculate Net Salary");
            _writer.WriteLine("3. Exit");
            var choice = _reader.ReadText();
            try
            {
                _validator.IsValidNumber(choice);
                _validator.IsValidMenuNumber(int.Parse(choice));
            }
            catch (Exception)
            {
                _writer.WriteLine("The application does not support this option");
                Run();
                return 3;
            }
            return int.Parse(choice);
        }

        private void RunMovieStarsList()
        {
            var json = File.ReadAllText("input.txt");
            var movieStars = JsonConvert.DeserializeObject<MovieStar[]>(json);

            foreach (var movieStar in movieStars)
            {
                Console.WriteLine("Name: " + movieStar.Name);
                Console.WriteLine("Surname: " + movieStar.Surname);
                Console.WriteLine("Email: " + movieStar.Email);
                Console.WriteLine("Sex: " + movieStar.Sex);
                Console.WriteLine("Nationality: " + movieStar.Nationality);
                Console.WriteLine("Age: " + movieStar.CalculateAge(movieStar.dateOfBirth));
                Console.WriteLine();
            }
        }

        private void RunCalculateNetSalary()
        {
            _writer.WriteLine("Enter Salary");
            var salaryToValidate = _reader.ReadText();
            try
            {
                _validator.IsValidNumber(salaryToValidate);
                _validator.IsValidIncome(double.Parse(salaryToValidate));
            }
            catch (Exception)
            {
                _writer.WriteLine("Invalid Salary");
                return;
            }
            var salary = double.Parse(salaryToValidate);
            _writer.WriteLine(_taxCalculator.CalculateIncome(salary));
        }
    }
}

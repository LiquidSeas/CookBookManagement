using CookBook.UI;
using DataAccessLayer.CONTRACTS;
using System.Configuration;
using System;
using Microsoft.Extensions.DependencyInjection;
using DataAccessLayer.REPOSITORIES;

namespace CookBook
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            ServiceCollection services = ConfigureServices();
            ServiceProvider serviceProvider = services.BuildServiceProvider();

            //Creating the form and preparing the form with its require
            //d services and dependancies
            var startForm = serviceProvider.GetRequiredService<RecipesForm>();
            Application.Run(startForm);
        }

        static ServiceCollection ConfigureServices()
        {
            ServiceCollection services = new ServiceCollection();

            //REGISTER THE REPOSITORY using the interface  IIngredientsRepository and create new instance of the interface
            services.AddTransient<IIngredientsRepository>(_ => new IngredientsRepository());
            //REGISTER THE FORM THAT'S GOING TO USE THE ABOVE REPOSITORY
            services.AddTransient<IngredientsForm>();

            services.AddTransient<IRecipeTypesRepository>(_=> new RecipeTypesRepository());
            services.AddTransient<RecipesForm>();

            services.AddTransient<RecipesTypesForm>();
            services.AddTransient<IRecipeRepository>(_ => new RecipesRepository());
            return services;

        }
    }
}
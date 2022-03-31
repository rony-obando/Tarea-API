using AppClimate.Forms;
using AppCore.IServices;
using AppCore.Services;
using Autofac;
using Domain.Interfaces;
using Infraesctructure.Models;

namespace AppClimate
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            var builder = new ContainerBuilder();
            builder.RegisterType<WeatherModel>().As<IWeather>();
            builder.RegisterType<WeatherServices>().As<IWeatherServices>();
            var container=builder.Build();
            ApplicationConfiguration.Initialize();
            Application.Run(new ClimateForm(container.Resolve<IWeatherServices>()));
        }
    }
}
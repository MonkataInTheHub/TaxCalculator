using Autofac;
using Backend.Interfaces;
using Backend.Models;
using Backend.Services;

namespace Backend
{
    class Program
    {
        //This is your app entry point
        static void Main(string[] args)
        {
            var container = Container.ConfigureContainer();

            //Get your application menu class
            
            using (var scope = container.BeginLifetimeScope())
            {
                var application = container.Resolve<ApplicationService>();
                application.Run();

            }
        }
    }
}

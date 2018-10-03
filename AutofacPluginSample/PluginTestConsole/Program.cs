using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Linq;
using Autofac;
using PluginTemplate;
using System.Runtime.Loader;
using System.Composition.Hosting;

namespace PluginTestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var pluginAssemblies = LoadAssemblies();
            var container = BuildContainer(pluginAssemblies);
            Console.WriteLine(RunIntMathOperation(container));
            Console.WriteLine(RunDefaultDoubleMathOperation(container));
            RunAllDoubleMathOperation(container);
            RunMEFMathOperation();
            Console.ReadKey();
        }
        static IEnumerable<Assembly> LoadAssemblies()
        {
            var dir = $@"{Directory.GetParent(AppContext.BaseDirectory.Substring(0, AppContext.BaseDirectory.IndexOf("bin"))).Parent.FullName}\PluginsBin";
            return Directory.GetFiles(dir, "*.dll").Select(x => Assembly.LoadFrom(x));
        }
        
        static IContainer BuildContainer(IEnumerable<Assembly> assemblies)
        {
            var builder = new ContainerBuilder(); ;
            builder.RegisterAssemblyModules(assemblies.ToArray());
            return builder.Build();
        }
        static int RunIntMathOperation(IContainer container)
        {
            var mathOperatoion = container.Resolve<IMathOperation<int>>();
            return mathOperatoion.Operation(5, 7);
        }
        static double RunDefaultDoubleMathOperation(IContainer container)
        {
            var mathOperatoion = container.Resolve<IMathOperation<double>>();
            return mathOperatoion.Operation(2.2, 4);
        }
        static void RunAllDoubleMathOperation(IContainer container)
        {
            var services = container.Resolve<IEnumerable<IMathOperation<double>>>();
            foreach(var service in services)
            {
                Console.WriteLine($"{service.GetType().Name} {service.Operation(2.2, 4)}");
            }
        }
        static void RunMEFMathOperation()
        {
            var dir = $@"{Directory.GetParent(AppContext.BaseDirectory.Substring(0, AppContext.BaseDirectory.IndexOf("bin"))).Parent.FullName}\PluginsBin";
            var assemblies = Directory.GetFiles(dir, "*.dll").Select(AssemblyLoadContext.Default.LoadFromAssemblyPath);
            var configuration = new ContainerConfiguration();
            configuration.WithAssemblies(assemblies);
            var container = configuration.CreateContainer();
            Console.WriteLine(container.GetExport<IMathOperation<decimal>>().Operation(5.2m,2.1m));       
        }
    }
}

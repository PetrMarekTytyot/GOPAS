using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace MEFDemo
{
    public class App
    {
        private CompositionContainer _container;

        [Import(typeof(ICalculator))]
        public ICalculator calculator;

        public App()
        {
            try
            {
                // An aggregate catalog that combines multiple catalogs.
                var catalog = new AggregateCatalog();
                // Adds all the parts found in the same assembly as the Program class.
                catalog.Catalogs.Add(new AssemblyCatalog(typeof(App).Assembly));
                catalog.Catalogs.Add(new DirectoryCatalog("Plugins"));
                // Create the CompositionContainer with the parts in the catalog.
                _container = new CompositionContainer(catalog);
                _container.ComposeParts(this);
            }
            catch (CompositionException compositionException)
            {
                Console.WriteLine(compositionException.ToString());
            }
        }
    }
}

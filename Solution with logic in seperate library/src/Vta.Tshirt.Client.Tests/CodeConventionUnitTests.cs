using System.Reflection;
using Vta.Tshirt.Client.Logic;

namespace Vta.Tshirt.Client.Tests;

public class CodeConventionUnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CodeConventionTest1()
    {
        foreach (Type vm in GetViewModelMarkers<IViewModelMarker>())
        {
            EnsureModelInheritance(vm);
        }
    }

    private void EnsureModelInheritance(Type type)
    {
        var properties = type.GetProperties();
        var model = properties?
            .Where(x => x.Name == "Model")
            .SingleOrDefault();

        if(model == null ||
            model.GetType().IsAssignableFrom(typeof(BaseModel)))
        {
            Assert.Fail("Model property must inherit from BaseModel class.");
        }
    }

    private IEnumerable<Type> GetViewModelMarkers<T>()
    {
        var hostAssembly = Assembly
            .GetExecutingAssembly().GetName().Name.Replace(".Tests", "");

        var assembly = Assembly
            .GetExecutingAssembly()
            .GetReferencedAssemblies()
            .Select(Assembly.Load)
            .Single(x => x.GetName().Name == hostAssembly);

        var typeName = typeof(T).Name;

        var types = assembly
            .GetExportedTypes()
            .Where(x => x.IsAssignableTo(typeof(T)) && x.Name != typeName)
            .ToList();

        return types;
    }
}

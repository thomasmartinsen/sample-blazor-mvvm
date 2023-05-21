using CommunityToolkit.Mvvm.ComponentModel;
using Vta.Tshirt.Client.Logic;
using Vta.Tshirt.Client.Logic.Features.Start;
using Vta.Tshirt.Services;

namespace Vta.Tshirt.Client.Tests;

public class CodeConventionUnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test2()
    {
        foreach (Type vm in GetViewModelMarkers())
        {
            EnsureOnlyOneObservableModel(vm);
        }
    }

    private void EnsureOnlyOneObservableModel(Type type)
    {
        var model = (type.GetProperties()
            .Where(x => x.Name == "Model" && x.DeclaringType.IsAssignableFrom(typeof(ObservableObject)))
            .SingleOrDefault());

        if(model is null)
        {
            Assert.Fail("Du har ikke en Model property som nedarver fra ObservableObject");
        }
    }

    private IEnumerable<Type> GetViewModelMarkers()
    {
        return GetType().Assembly.GetExportedTypes().Where(x => x.IsAssignableTo(typeof(IViewModelMarker)));
    }
}

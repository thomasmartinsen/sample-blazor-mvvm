using Vta.Tshirt.Client.Logic.Features.Start;
using Vta.Tshirt.Services;

namespace Vta.Tshirt.Client.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task Test1()
    {
        StartViewModel vm = new StartViewModel(new TshirtService());
        await vm.LoadDataAsync();
        await vm.SelectTshirt();

        Assert.AreEqual(vm.Model.TshirtColor, "blue");
    }
}

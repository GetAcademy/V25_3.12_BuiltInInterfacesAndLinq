namespace V25_3._12_BuiltInInterfacesAndLinq.Extension;

public class ExtensionExample : IExample
{
    public void Run()
    {
        var text = "Dag";
        var name = "dag";

        Console.WriteLine(text.Repeat(100));
        Console.WriteLine(name.Capitalize());
    }

    public ExampleName ExampleName => ExampleName.Extension;
}
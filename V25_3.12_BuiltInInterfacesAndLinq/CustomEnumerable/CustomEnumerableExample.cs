namespace V25_3._12_BuiltInInterfacesAndLinq.CustomEnumerable;

public class CustomEnumerableExample : IExample
{
    public void Run()
    {
        var doublingNumberSequence = new DoublingNumberSequence(1, 10000);
        foreach (var current in doublingNumberSequence)
        {
            Console.WriteLine(current);
        }
    }

    public ExampleName ExampleName => ExampleName.CustomEnumerable;
}
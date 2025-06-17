namespace V25_3._12_BuiltInInterfacesAndLinq.Foreach;

public class ForeachExample : IExample
{
    public void Run()
    {
        int[] numbers = { 1, 2, 3 };
        foreach (var n in numbers)
        {
            Console.WriteLine(n);
        }

        List<string> names = new() { "Dag", "Dagmar", "Dagros" };
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
        
        List<string> moreNames = new() { "Per", "Pål", "Espen" };
        IEnumerator<string> enumerator = moreNames.GetEnumerator();

        while (enumerator.MoveNext())
        {
            var current = enumerator.Current;
            Console.WriteLine(current);
        }
    }

    public ExampleName ExampleName => ExampleName.Foreach;
}
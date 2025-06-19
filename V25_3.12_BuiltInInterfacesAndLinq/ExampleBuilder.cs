using V25_3._12_BuiltInInterfacesAndLinq.CustomEnumerable;
using V25_3._12_BuiltInInterfacesAndLinq.Extension;
using V25_3._12_BuiltInInterfacesAndLinq.Foreach;
using V25_3._12_BuiltInInterfacesAndLinq.LINQ;

namespace V25_3._12_BuiltInInterfacesAndLinq;

public class ExampleBuilder
{
    private readonly Dictionary<ExampleName, IExample> _examples = new();
    public ExampleBuilder Add<T>() where T : IExample, new()
    {
        var example = new T();
        _examples.TryAdd(example.ExampleName, example);

        return this;
    }
    
    
    
    
    
    
    
    
    
    
    

    public ExampleBuilder AddExample(ExampleName exampleName)
    {
        IExample? example = null;
        switch (exampleName)
        {
            case ExampleName.Foreach:
                example = new ForeachExample();
                break;
            case ExampleName.CustomEnumerable:
                example = new CustomEnumerableExample();
                break;
            case ExampleName.Extension:
                example = new ExtensionExample();
                break;
            case ExampleName.Linq:
                example = new LinqExample();
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(exampleName), exampleName, null);
        }

        _examples.Add(exampleName, example);

        return this;
    }


    public ExampleBuilder AddLinqExample()
    {
        _examples.Add(ExampleName.Linq, new LinqExample());

        return this;
    }


    public ExampleBuilder AddForeachExample()
    {
        _examples.Add(ExampleName.Foreach, new ForeachExample());

        return this;
    }

    public Dictionary<ExampleName, IExample> Build()
    {
        return _examples;
    }
}
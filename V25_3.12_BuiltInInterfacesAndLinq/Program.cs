using V25_3._12_BuiltInInterfacesAndLinq;
using V25_3._12_BuiltInInterfacesAndLinq.CustomEnumerable;
using V25_3._12_BuiltInInterfacesAndLinq.Extension;
using V25_3._12_BuiltInInterfacesAndLinq.Foreach;
using V25_3._12_BuiltInInterfacesAndLinq.LINQ;

// var examples = 
//     new ExampleBuilder()
//         .AddExample(ExampleName.Linq)
//         .AddExample(ExampleName.Extension)
//         .AddExample(ExampleName.CustomEnumerable)
//         .Build();

var exampleToRun = ExampleName.Linq;
var examples = new ExampleBuilder()
    .Add<ForeachExample>()
    .Add<LinqExample>()
    .Add<CustomEnumerableExample>()
    .Add<ExtensionExample>()
    .Build();


examples[exampleToRun].Run();
foreach (var example in examples)
{
    example.Value.Run();
}



// IExample exampleToRun;

// exampleToRun = new ForeachExample();
// exampleToRun = new CustomEnumerableExample();
// exampleToRun = new ExtensionExample();
// exampleToRun = new LinqExample();
//
// exampleToRun.Run();
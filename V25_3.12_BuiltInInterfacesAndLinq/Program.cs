
using V25_3._12_BuiltInInterfacesAndLinq;
using V25_3._12_BuiltInInterfacesAndLinq.CustomEnumerable;
using V25_3._12_BuiltInInterfacesAndLinq.Extension;
using V25_3._12_BuiltInInterfacesAndLinq.Foreach;
using V25_3._12_BuiltInInterfacesAndLinq.LINQ;

IExample exampleToRun = null;

// exampleToRun = new ForeachExample();
// exampleToRun = new CustomEnumerableExample();
// exampleToRun = new ExtensionExample();
exampleToRun = new LinqExample();

exampleToRun.Run();
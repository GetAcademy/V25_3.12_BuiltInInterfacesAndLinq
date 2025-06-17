namespace V25_3._12_BuiltInInterfacesAndLinq.LINQ;

public class LinqExample : IExample
{
    public void Run()
    {
        var students = StudentGenerator.GenerateStudents();
        
        // Hente alle studenter som er yngre eller 20 år?  
        var studentsAge20OrBelow = students.Where(x => x.Age <= 20);

        // Finne alle studenter som bor i Trondheim?
        var studentsInTrondheim = students.Where(x => x.City == "Trondheim");

        // Finne eleven som ble tatt opp først?  
        var firstEnrolledStudent = students.OrderBy(x => x.EnrolledDate).First();

        // Finne en spesifikk elev basert på id?
        var studentById = students.FirstOrDefault(x => x.Id == 1);

        // Finne gjennomsnittsalderen?
        var averageAge = students.Average(x => x.Age);

        // Hvilken by har mest studenter?  
        var cityWithMostStudents = students
            .GroupBy(x => x.City)
            .OrderByDescending(x => x.Count())
            .Select(x => new { City = x.Key, Count = x.Count() })
            .FirstOrDefault();

        var citiesWithStudentCount = students
            .GroupBy(x => x.City)
            .OrderByDescending(x => x.Count())
            .Select(x => new { City = x.Key, Count = x.Count() });

        // Er det noen studenter fra Sandefjord?
        var anyoneFromSandefjord = students.Any(x => x.City == "Sandefjord");

        // Er alle studentene i Oslo?  
        var everyoneFromOslo = students.All(x => x.City == "Oslo");

        // Kan vi få de i en tilfeldig rekkefølge?
        var randomizedStudents = students.OrderBy(x => Guid.NewGuid());
    }

    public ExampleName ExampleName => ExampleName.Linq;
}
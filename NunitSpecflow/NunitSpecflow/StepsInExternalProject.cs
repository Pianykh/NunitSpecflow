using TechTalk.SpecFlow;

namespace NunitSpecflow;

[Binding]
public class StepsInExternalProject
{
   [Given(@"Given in external project")]
    public void GivenGivenInExternalProject()
    {
        Console.WriteLine("Given in external project");
    }

    [StepDefinition("When in external project")]
    public void WhenWhenInExternalProject()
    {
        Console.WriteLine("When in external project");
    }

    
    [Then(@"Then in external project")]
    public void ThenThenInExternalProject()
    {
        Console.WriteLine("Then in external project");
    }
}
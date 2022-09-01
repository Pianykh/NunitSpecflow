using TechTalk.SpecFlow;

namespace Features.StepsInSameProject;

[Binding]
public class Steps
{
    [Given(@"Given in same project")]
    public void GivenGivenInSameProject()
    {
        Console.WriteLine("Given in same project");
    }

    [When(@"When in same project")]
    public void WhenWhenInSameProject()
    {
        Console.WriteLine("When in same project");
    }

    [Then(@"Then in same project")]
    public void ThenThenInSameProject()
    {
        Console.WriteLine("Then in same project");
    }
}
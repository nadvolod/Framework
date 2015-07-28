namespace Framework.Pages
{
    public class AutomationTestingPracticePage
    {
        public void Goto()
        {
            Browser.Goto("/automation-practice");
        }

        public bool IsAt()
        {
            return Browser.Title.Contains("Automation Testing Practice");
        }
    }
}
namespace ProcessJsonConsoleApp.Models
{
    public class Solar : PowerSupply
    {
        public override float GetPower()
        {
            throw new NotImplementedException();
        }

        public override void Show()
        {
            Console.WriteLine("[*]");
        }
    }
}

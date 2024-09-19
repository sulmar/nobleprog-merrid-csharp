namespace ProcessJsonConsoleApp.Models
{
    public class Inverter : PowerSupply
    {
        public override float GetPower()
        {
            throw new NotImplementedException();
        }

        public override void Show()
        {
            Console.WriteLine("[i]");
        }
    }
}

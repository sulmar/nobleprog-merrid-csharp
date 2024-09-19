namespace ProcessJsonConsoleApp.Models
{
    public class SoftStart : PowerSupply
    {
        public bool Bit1 { get; set; }
        public bool Bit2 { get; set; }

        public override float GetPower()
        {
            throw new NotImplementedException();
        }

        public override bool IsReady()
        {
            return base.IsReady() && Bit1 && Bit2;
        }

        public override void Show()
        {
            Console.WriteLine("[-]");
        }
    }
}

namespace ProcessJsonConsoleApp.Models
{
    public abstract class PowerSupply
    {
        public double Voltage { get; set; } = 12.01f;

        public virtual bool IsReady()
        {
            return this.Voltage > 0;
        }

        public abstract void Show();

        public abstract float GetPower();

        public void DoWork()
        {

        }
    }
}

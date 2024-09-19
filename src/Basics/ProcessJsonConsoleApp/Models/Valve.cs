namespace ProcessJsonConsoleApp.Models
{
    public class Valve : Device
    {
        public bool IsOpened { get; set; }
        public int Mode { get; set; }

        public Valve(string name)
            : base(name)
        {

        }
    }
}

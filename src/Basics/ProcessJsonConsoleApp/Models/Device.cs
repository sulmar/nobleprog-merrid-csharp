namespace ProcessJsonConsoleApp.Models
{
    public abstract class Device
    {
        public string Name { get; set; }

        private string _label;
        public string Label
        {
            get
            {
                return _label;
            }

            set
            {
                if (value.Length > 3)
                    _label = value;
                else
                    throw new ArgumentException();
            }
        }
    }
}

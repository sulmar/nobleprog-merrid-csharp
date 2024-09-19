namespace ProcessJsonConsoleApp.Infrastructures
{
    class InlineRequestService : RequestService
    {
        public override void SendRailLoadRequest(string name)
        {
            Console.WriteLine($"Send rail load request to {name} via winccoa");
        }

        public override void SendRailUnloadRequest(string name)
        {
            Console.WriteLine($"Send rail unload request to {name} via winccoa");
        }

        public override void SendTruckLoadRequest(string name)
        {
            Console.WriteLine($"Send truck load request to {name} via winccoa");
        }

        public override void SendTruckUnloadRequest(string name)
        {
            Console.WriteLine($"Send truck unload request to {name} via winccoa");
        }
    }
}

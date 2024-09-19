namespace ProcessJsonConsoleApp.Infrastructures
{
    class RabbitMQRequestService : RequestService
    {
        public override void SendRailLoadRequest(string name)
        {
            Console.WriteLine($"Send rail load request to {name} via RabbitMQ");
        }

        public override void SendRailUnloadRequest(string name)
        {
            Console.WriteLine($"Send rail unload request to {name} via RabbitMQ");
        }

        public override void SendTruckLoadRequest(string name)
        {
            Console.WriteLine($"Send truck load request to {name} via RabbitMQ");
        }

        public override void SendTruckUnloadRequest(string name)
        {
            Console.WriteLine($"Send truck unload request to {name} via RabbitMQ");
        }
    }
}

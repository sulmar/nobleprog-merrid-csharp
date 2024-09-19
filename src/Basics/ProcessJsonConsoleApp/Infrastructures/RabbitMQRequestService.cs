namespace ProcessJsonConsoleApp.Infrastructures
{

    class RabbitMQRequestService : IRequestTruckService, IRequestRailService
    {
        public void SendRailLoadRequest(string name)
        {
            Console.WriteLine($"Send rail load request to {name} via RabbitMQ");
        }

        public void SendRailUnloadRequest(string name)
        {
            Console.WriteLine($"Send rail unload request to {name} via RabbitMQ");
        }

        public void SendTruckLoadRequest(string name)
        {
            Console.WriteLine($"Send truck load request to {name} via RabbitMQ");
        }

        public void SendTruckUnloadRequest(string name)
        {
            Console.WriteLine($"Send truck unload request to {name} via RabbitMQ");
        }
    }
}

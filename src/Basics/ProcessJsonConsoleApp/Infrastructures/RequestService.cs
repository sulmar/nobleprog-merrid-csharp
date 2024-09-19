namespace ProcessJsonConsoleApp.Infrastructures
{
    interface IRequestTruckService
    {
        void SendTruckUnloadRequest(string name);
        void SendTruckLoadRequest(string name);
       
    }
}

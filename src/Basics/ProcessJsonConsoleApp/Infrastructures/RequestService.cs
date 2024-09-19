namespace ProcessJsonConsoleApp.Infrastructures
{
    abstract class RequestService
    {
        public abstract void SendTruckUnloadRequest(string name);
        public abstract void SendTruckLoadRequest(string name);
        public abstract void SendRailUnloadRequest(string name);
        public abstract void SendRailLoadRequest(string name);
    }
}

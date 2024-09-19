namespace ProcessJsonConsoleApp.Infrastructures
{
    interface IRequestRailService
    {
        void SendRailUnloadRequest(string name);
        void SendRailLoadRequest(string name);
    }
}

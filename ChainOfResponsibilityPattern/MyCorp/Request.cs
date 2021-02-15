namespace MyCorp
{
    class Request
    {
        public RequestType RequestType { get; set; }
        public string RequestContent { get; set; }
        public int Number { get; set; }
    }

    enum RequestType
    {
        Leave,
        Raise
    }
}
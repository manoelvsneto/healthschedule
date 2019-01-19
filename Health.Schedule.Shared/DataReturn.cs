using System;

namespace Health.Schedule.Shared
{
    [Serializable]
    public class DataReturn
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public Exception ExceptionError { get; set; }
        public dynamic Data { get; set; }
    }
}

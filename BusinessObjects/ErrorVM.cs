using System.Net;

public class ErrorVM
    {
        public int? index { get; set; }
        public string field { get; set; }
        public string description { get; set; }
        public string customDescription { get; set; }
        public HttpStatusCode ErrorStatusCode { get; set; }
        public string InnerException { get; set; }
    }
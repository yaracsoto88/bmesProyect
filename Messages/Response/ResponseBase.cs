using System.Net;


namespace bmesProyect.Messages.Response.Product
{
    public class ResponseBase
    {
        public ResponseBase()
        {
            Messages = [];
        }
        public HttpStatusCode StatusCode { get; set; }
        public List<string> Messages { get; set; }

    }
}
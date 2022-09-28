using System.Net;

namespace WhiteVilla_VillaAPI.Models
{
    public class APIResponse
    {
        public APIResponse()
        {
            ErrorMesages = new List<string>();
        }
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccess { get; set; }
        public List<string> ErrorMesages { get; set; }
        public object Result { get; set; }
    }
}

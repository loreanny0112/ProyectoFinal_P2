namespace WebApplication1.Web.BL.Core
{
    public class ServiceResult
    {
        public ServiceResult()
        {
            Success = true;
        }
        public bool Success { get; set; }
        public string Message { get; set; }

        public dynamic? Data { get; set; }
    }
}
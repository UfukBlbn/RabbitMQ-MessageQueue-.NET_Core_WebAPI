using System.Net;

namespace RabbitMq_NetCoreWebAPI.Models.ApıRequest
{
    public class BaseResponse<T> where T : class
    {
        public T Data { get; set; }
        public string Message { get; set; }
        public HttpStatusCode StatusCode { get; set; }

        public static BaseResponse<T> returnSuccess(T data)
        {
            return new BaseResponse<T>
            {
                Data = data,
                StatusCode = HttpStatusCode.OK,
                Message = "Success"
            };
        }
        public static BaseResponse<T> returnError(T data, string message)
        {
            return new BaseResponse<T>
            {
                Data = data,
                StatusCode = HttpStatusCode.BadRequest,
                Message = message
            };
        }

    }
}

using TridentTech.Const;

namespace UserManagement.Models.General
{
    /// <summary>
    /// 回傳狀態
    /// </summary>
    public class ResultResponse
    {
        /// <summary>
        /// HttpCode
        /// </summary>
        public int HttpCode { get; set; } = StatusCodes.Status200OK;
        /// <summary>
        /// 狀態碼
        /// </summary>
        public string Code { get; set; } = ResponseMessage.SuccessCode;
        /// <summary>
        /// 訊息
        /// </summary>
        public string Message { get; set; } = ResponseMessage.Success;
    }

    /// <summary>
    /// 泛型回傳值
    /// </summary>
    /// <typeparam name="T">泛型物件</typeparam>
    public class ResultResponse<T> : ResultResponse
    {
        /// <summary>
        /// 回傳 data
        /// </summary>
        public T? Data { get; set; }
    }
}

using System;
namespace Common.Core.Protocol
{
    public class Result<T> where T : class, new()
    {
        /// <summary>
        /// 服务器的时间戳
        /// </summary>
        public string timestamp { get; set; }

        /// <summary>
        /// 客户端请求发给服务器端的X-Request-Id
        /// </summary>
        public string requestId { get; set; } = string.Empty;

        /// <summary>
        /// 业务数据
        /// </summary>
        private T data;

        /// <summary>
        /// 成功返回消息
        /// </summary>
        public string message;

        /// <summary>
        /// 错误码
        /// </summary>
        public string errorCode { get; set; } = string.Empty;

        /// <summary>
        /// 错误信息
        /// </summary>
        public string errorMessage { get; set; } = string.Empty;

        /// <summary>
        /// 错误码返回的来源业务域的名称
        /// </summary>
        public string errorFrom { get; set; } = string.Empty;
    }
}

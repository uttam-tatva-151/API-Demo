namespace Core.Beans.Enums
{
    /// <summary>
    /// Represents the result of an operation, including its status, message, and optional data.
    /// </summary>
    /// <typeparam name="T">The type of the data returned by the operation.</typeparam>
    public class ResponseResult<T>
    {
        /// <summary>
        /// Gets or sets the status of the operation (e.g., Success, Failure).
        /// </summary>
        public ResponseStatus Status { get; set; }

        /// <summary>
        /// Gets or sets a message describing the result of the operation.
        /// </summary>
        public string Message { get; set; } = null!;

        /// <summary>
        /// Gets or sets the data returned by the operation, if applicable.
        /// </summary>
        public T? Data { get; set; }

        /// <summary>
        /// Gets or sets a list of error messages, if any.
        /// </summary>
        public List<string>? Errors { get; set; }

        /// <summary>
        /// Creates a standard failed result.
        /// </summary>
        /// <param name="msg">The failure message.</param>
        /// <param name="errs">List of errors, optional.</param>
        /// <returns>A ResponseResult indicating failure.</returns>
        public static ResponseResult<T> Fail(string msg,T? data = default, List<string>? errs = null)
            => new() { Status = ResponseStatus.Error, Message = msg, Data = default, Errors = errs };

        /// <summary>
        /// Creates a standard success result.
        /// </summary>
        /// <param name="msg">The success message.</param>
        /// <param name="data">Optional data to return.</param>
        /// <returns>A ResponseResult indicating success.</returns>
        public static ResponseResult<T> Success(string msg, T? data = default)
            => new() { Status = ResponseStatus.Success, Message = msg, Data = data, Errors = null };
    }
}

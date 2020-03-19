namespace XML
{
    public class BaseResponse<T>
    {
        public bool Success { get; private set; }

        public string ErrorMessage { get; private set; }

        public T Response { get; private set; }


        public void SetError(string errorMessage)
        {
            this.ErrorMessage = errorMessage;
        }

        public void SetSuccess(T vl)
        {
            this.Success = true;
            this.Response = vl;
        }

    }
}

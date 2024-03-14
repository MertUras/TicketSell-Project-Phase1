using System;
namespace DataAccess.Results.Bases
{
	public abstract class Result
	{
        protected Result(bool isSuccessful, string message)
        {
            IsSuccessful = isSuccessful;
            Message = message;
        }

        public bool IsSuccessful { get; }
		public string Message { get; }

	}
}


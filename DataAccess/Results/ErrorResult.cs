﻿using System;
using DataAccess.Results.Bases;

namespace DataAccess.Results
{
	public class ErrorResult : Result
	{
        public ErrorResult(string message) : base(false, message)
        {
        }
        public ErrorResult() : base(false, string.Empty)
        {

        }
    }
}


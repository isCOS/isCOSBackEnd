﻿using ApiCos.ExceptionApi;

namespace ApiCos.ExceptionApi.User
{
    public class EmailEmptyException : BaseException
    {
        private const int ErrorId = 104;
        private const string ErrorDescription = "Email is empty";
        public EmailEmptyException() : base(ErrorId, ErrorDescription)
        {
        }
    }
}

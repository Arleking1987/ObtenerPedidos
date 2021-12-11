using System;
using System.Collections.Generic;
using System.Text;

namespace SocialMedia.Core.DTOs
{
    public class ResponseContract<TContract>
    {
        public HeaderContract Header { get; set; }
        public TContract Data { get; set; }

        public ResponseContract()
        {
            Header = new HeaderContract();
            Header.Code = HttpCodes.Ok;
        }
    }

    public class ResponseContract
    {
        public HeaderContract Header { get; set; }
    }

    public enum HttpCodes
    {
        Ok = 200,
        OkExist = 201,
        BadRequest = 400,
        NotFound = 404,
        ValidationError = 421,
        InternalServerError = 500,
        Unautorized = 401
    }

    public class HeaderContract
    {
        public HttpCodes Code { get; set; }
        public string Message { get; set; }
    }
}


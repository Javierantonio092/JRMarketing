﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JRMarketing.Api.Responses
{
    public class ApiResponse<T>
    {
        public T Data { get; private set; }

        public ApiResponse(T data)
        {
            Data = data;
        }
    }
}
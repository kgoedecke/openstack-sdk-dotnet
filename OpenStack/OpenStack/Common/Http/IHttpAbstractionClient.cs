﻿// /* ============================================================================
// Copyright 2014 Hewlett Packard
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ============================================================================ */

using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace OpenStack.Common.Http
{
    public interface IHttpAbstractionClient : IDisposable
    {
        HttpMethod Method { get; set; }

        Uri Uri { get; set; }

        Stream Content { get; set; }

        IDictionary<string, string> Headers { get; }

        string ContentType { get; set; }

        TimeSpan Timeout { get; set; }


        //event EventHandler<HttpProgressEventArgs> HttpReceiveProgress;
        //event EventHandler<HttpProgressEventArgs> HttpSendProgress;

        Task<IHttpResponseAbstraction> SendAsync();
    }
}
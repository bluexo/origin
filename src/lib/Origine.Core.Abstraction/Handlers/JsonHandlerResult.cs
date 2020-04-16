﻿using Orleans.Concurrency;

namespace Origine
{
    [Immutable]
    public struct JsonHandlerResult : IHandlerResult
    {
        public string Content { get; set; }

        public StatusDescriptor Status { get; set; }

        public T GetData<T>() where T : class => Content as T;
    }
}

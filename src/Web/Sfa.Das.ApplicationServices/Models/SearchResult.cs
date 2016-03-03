﻿using System.Collections.Generic;

namespace Sfa.Das.ApplicationServices.Models
{
    public sealed class SearchResult<T>
        where T : class
    {
        public long Total { get; set; }

        public IEnumerable<T> Hits { get; set; }
    }
}

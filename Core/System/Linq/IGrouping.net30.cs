﻿#if NET20 || NET30

using System.Collections.Generic;

namespace System.Linq
{
    public interface IGrouping<out TKey, TElement> : IEnumerable<TElement>
    {
        TKey Key
        {
            get;
        }
    }
}

#endif
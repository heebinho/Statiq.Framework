﻿using System;
using System.Collections;
using System.Collections.Generic;
using Wyam.Common.Modules;

namespace Wyam.Common.Execution
{
    public interface IPipelineCollection : IReadOnlyDictionary<string, IPipeline>, IReadOnlyList<IPipeline>
    {
        IPipeline Add(string name, ModuleList modules);
        IPipeline Insert(int index, string name, ModuleList modules);
        bool Remove(string name);
        void RemoveAt(int index);
        int IndexOf(string name);
        new int Count { get; }
        new IEnumerator<IPipeline> GetEnumerator();
    }
}

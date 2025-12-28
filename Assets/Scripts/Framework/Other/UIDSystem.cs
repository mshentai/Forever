using System.Collections.Generic;
using Lunar.Core;
using Lunar.Utilities;
using UnityEngine;

namespace Lunar.Core
{
    public class UIDSystem : Singleton<UIDSystem>
    {
        private readonly Dictionary<UIDType, UIDGenerator> generators = new();

        public UIDGenerator GetGenerator(UIDType type)
        {
            if (!this.generators.TryGetValue(type, out var generator))
            {
                generator = new UIDGenerator();
                this.generators.Add(type, generator);
            }
            return generator;
        }

        public long Next(UIDType type)
        {
            return GetGenerator(type).Next();
        }

        public int NextInt(UIDType type)
        {
            return GetGenerator(type).NextInt();
        }
    }

    public class UIDGenerator
    {
        private long currentId;

        public UIDGenerator()
        {
            this.currentId = 0;
        }

        public long Next()
        {
            return System.Threading.Interlocked.Increment(ref this.currentId);
        }

        public int NextInt()
        {
            return (int)(Next() & 0xFFFFFFFF);
        }
    }

    public enum UIDType
    {
        Global,
        Timer,
    }
}
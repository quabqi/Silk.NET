// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPURequestAdapterOptions")]
    public unsafe partial struct RequestAdapterOptions
    {
        public RequestAdapterOptions
        (
            ChainedStruct* nextInChain = null,
            SurfaceImpl* compatibleSurface = null,
            PowerPreference? powerPreference = null,
            bool? forceFallbackAdapter = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (compatibleSurface is not null)
            {
                CompatibleSurface = compatibleSurface;
            }

            if (powerPreference is not null)
            {
                PowerPreference = powerPreference.Value;
            }

            if (forceFallbackAdapter is not null)
            {
                ForceFallbackAdapter = forceFallbackAdapter.Value;
            }
        }


        [NativeName("Type", "const WGPUChainedStruct *")]
        [NativeName("Type.Name", "const WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "WGPUSurface")]
        [NativeName("Type.Name", "WGPUSurface")]
        [NativeName("Name", "compatibleSurface")]
        public SurfaceImpl* CompatibleSurface;

        [NativeName("Type", "WGPUPowerPreference")]
        [NativeName("Type.Name", "WGPUPowerPreference")]
        [NativeName("Name", "powerPreference")]
        public PowerPreference PowerPreference;

        [NativeName("Type", "bool")]
        [NativeName("Type.Name", "bool")]
        [NativeName("Name", "forceFallbackAdapter")]
        public bool ForceFallbackAdapter;
    }
}
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WebGPU
{
    [Flags]
    [NativeName("Name", "WGPUQueryType")]
    public enum QueryType : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Occlusion\"")]
        [NativeName("Name", "WGPUQueryType_Occlusion")]
        QueryTypeOcclusion = 0x0,
        [Obsolete("Deprecated in favour of \"PipelineStatistics\"")]
        [NativeName("Name", "WGPUQueryType_PipelineStatistics")]
        QueryTypePipelineStatistics = 0x1,
        [Obsolete("Deprecated in favour of \"Timestamp\"")]
        [NativeName("Name", "WGPUQueryType_Timestamp")]
        QueryTypeTimestamp = 0x2,
        [Obsolete("Deprecated in favour of \"Force32\"")]
        [NativeName("Name", "WGPUQueryType_Force32")]
        QueryTypeForce32 = 0x7FFFFFFF,
        [NativeName("Name", "WGPUQueryType_Occlusion")]
        Occlusion = 0x0,
        [NativeName("Name", "WGPUQueryType_PipelineStatistics")]
        PipelineStatistics = 0x1,
        [NativeName("Name", "WGPUQueryType_Timestamp")]
        Timestamp = 0x2,
        [NativeName("Name", "WGPUQueryType_Force32")]
        Force32 = 0x7FFFFFFF,
    }
}
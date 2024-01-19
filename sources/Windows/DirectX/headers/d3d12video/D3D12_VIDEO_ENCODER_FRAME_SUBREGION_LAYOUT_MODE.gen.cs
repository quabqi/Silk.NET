// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE"]/*'/>
public enum D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE
{
    /// <include file='D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE.D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_FULL_FRAME"]/*'/>

    D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_FULL_FRAME = 0,

    /// <include file='D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE.D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_BYTES_PER_SUBREGION"]/*'/>

    D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_BYTES_PER_SUBREGION = 1,

    /// <include file='D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE.D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_SQUARE_UNITS_PER_SUBREGION_ROW_UNALIGNED"]/*'/>

    D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_SQUARE_UNITS_PER_SUBREGION_ROW_UNALIGNED = 2,

    /// <include file='D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE.D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_UNIFORM_PARTITIONING_ROWS_PER_SUBREGION"]/*'/>

    D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_UNIFORM_PARTITIONING_ROWS_PER_SUBREGION = 3,

    /// <include file='D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE.D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_UNIFORM_PARTITIONING_SUBREGIONS_PER_FRAME"]/*'/>

    D3D12_VIDEO_ENCODER_FRAME_SUBREGION_LAYOUT_MODE_UNIFORM_PARTITIONING_SUBREGIONS_PER_FRAME = 4,
}
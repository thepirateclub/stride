﻿// Copyright (c) Stride contributors (https://stride3d.net) and Sean Boettger <sean@whypenguins.com>
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.

using Stride.Shaders;

namespace Stride.Rendering.Voxels.Debug
{
    public partial class VoxelVisualizationRawShaderKeys
    {
        public static readonly PermutationParameterKey<ShaderSource> Attribute = ParameterKeys.NewPermutation<ShaderSource>();
    }
}

// <copyright file="SavableLinks.cs" company="BovineLabs">
//     Copyright (c) BovineLabs. All rights reserved.
// </copyright>

namespace BovineLabs.Saving.Data
{
    using Unity.Entities;

    [InternalBufferCapacity(0)]
    public struct SavableLinks : IBufferElementData
    {
        public Entity Entity;
        public ulong LinkID;
    }
    
    [Save]
    public struct SavableLinks_Instantiated : IComponentData, IEnableableComponent
    {
    }
}

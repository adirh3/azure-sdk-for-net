// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> VmMemory Data. </summary>
    public partial class VmMemory
    {
        /// <summary> Initializes a new instance of VmMemory. </summary>
        public VmMemory()
        {
        }

        /// <summary> Initializes a new instance of VmMemory. </summary>
        /// <param name="startupMemoryMB"> The total amount of RAM in the virtual machine, as seen by the guest  operating system. For a virtual machine with dynamic memory enabled, this represents the initial memory available at startup. </param>
        /// <param name="currentMemoryUsageMB"> The current memory used by the virtual machine. </param>
        internal VmMemory(long? startupMemoryMB, long? currentMemoryUsageMB)
        {
            StartupMemoryMB = startupMemoryMB;
            CurrentMemoryUsageMB = currentMemoryUsageMB;
        }

        /// <summary> The total amount of RAM in the virtual machine, as seen by the guest  operating system. For a virtual machine with dynamic memory enabled, this represents the initial memory available at startup. </summary>
        public long? StartupMemoryMB { get; set; }
        /// <summary> The current memory used by the virtual machine. </summary>
        public long? CurrentMemoryUsageMB { get; set; }
    }
}

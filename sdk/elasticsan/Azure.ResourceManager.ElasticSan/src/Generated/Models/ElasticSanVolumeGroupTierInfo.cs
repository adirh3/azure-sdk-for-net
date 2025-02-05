// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ElasticSan.Models
{
    /// <summary> Volume Group scalability target. </summary>
    internal partial class ElasticSanVolumeGroupTierInfo
    {
        /// <summary> Initializes a new instance of ElasticSanVolumeGroupTierInfo. </summary>
        internal ElasticSanVolumeGroupTierInfo()
        {
        }

        /// <summary> Initializes a new instance of ElasticSanVolumeGroupTierInfo. </summary>
        /// <param name="maxElasticSanVolumeCount"> Maximum number of Volumes per Volume Groups per San account. </param>
        internal ElasticSanVolumeGroupTierInfo(long? maxElasticSanVolumeCount)
        {
            MaxElasticSanVolumeCount = maxElasticSanVolumeCount;
        }

        /// <summary> Maximum number of Volumes per Volume Groups per San account. </summary>
        public long? MaxElasticSanVolumeCount { get; }
    }
}

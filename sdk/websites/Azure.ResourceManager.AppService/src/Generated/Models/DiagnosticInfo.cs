// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Set of data with rendering instructions. </summary>
    public partial class DiagnosticInfo
    {
        /// <summary> Initializes a new instance of DiagnosticInfo. </summary>
        public DiagnosticInfo()
        {
        }

        /// <summary> Initializes a new instance of DiagnosticInfo. </summary>
        /// <param name="table"> Data in table form. </param>
        /// <param name="renderingProperties"> Properties that describe how the table should be rendered. </param>
        internal DiagnosticInfo(DataTableResponseObject table, Rendering renderingProperties)
        {
            Table = table;
            RenderingProperties = renderingProperties;
        }

        /// <summary> Data in table form. </summary>
        public DataTableResponseObject Table { get; set; }
        /// <summary> Properties that describe how the table should be rendered. </summary>
        public Rendering RenderingProperties { get; set; }
    }
}

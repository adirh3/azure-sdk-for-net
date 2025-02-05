// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    /// <summary> The properties indicating the operation result of an operation on a service. </summary>
    public partial class OperationResultsDescription
    {
        /// <summary> Initializes a new instance of OperationResultsDescription. </summary>
        internal OperationResultsDescription()
        {
        }

        /// <summary> Initializes a new instance of OperationResultsDescription. </summary>
        /// <param name="id"> The ID of the operation returned. </param>
        /// <param name="name"> The name of the operation result. </param>
        /// <param name="status"> The status of the operation being performed. </param>
        /// <param name="startTime"> The time that the operation was started. </param>
        /// <param name="endTime"> The time that the operation finished. </param>
        /// <param name="properties"> Additional properties of the operation result. </param>
        internal OperationResultsDescription(string id, string name, OperationResultStatus? status, string startTime, string endTime, BinaryData properties)
        {
            Id = id;
            Name = name;
            Status = status;
            StartTime = startTime;
            EndTime = endTime;
            Properties = properties;
        }

        /// <summary> The ID of the operation returned. </summary>
        public string Id { get; }
        /// <summary> The name of the operation result. </summary>
        public string Name { get; }
        /// <summary> The status of the operation being performed. </summary>
        public OperationResultStatus? Status { get; }
        /// <summary> The time that the operation was started. </summary>
        public string StartTime { get; }
        /// <summary> The time that the operation finished. </summary>
        public string EndTime { get; }
        /// <summary>
        /// Additional properties of the operation result..
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData Properties { get; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The UnknownRunRequest. </summary>
    internal partial class UnknownRunRequest : ContainerRegistryRunContent
    {
        /// <summary> Initializes a new instance of <see cref="UnknownRunRequest"/>. </summary>
        /// <param name="runRequestType"> The type of the run request. </param>
        /// <param name="isArchiveEnabled"> The value that indicates whether archiving is enabled for the run or not. </param>
        /// <param name="agentPoolName"> The dedicated agent pool for the run. </param>
        /// <param name="logTemplate"> The template that describes the repository and tag information for run log artifact. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownRunRequest(string runRequestType, bool? isArchiveEnabled, string agentPoolName, string logTemplate, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(runRequestType, isArchiveEnabled, agentPoolName, logTemplate, serializedAdditionalRawData)
        {
            RunRequestType = runRequestType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownRunRequest"/> for deserialization. </summary>
        internal UnknownRunRequest()
        {
        }
    }
}

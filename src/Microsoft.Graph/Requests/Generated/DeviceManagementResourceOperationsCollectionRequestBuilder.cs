// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type DeviceManagementResourceOperationsCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceManagementResourceOperationsCollectionRequestBuilder : BaseRequestBuilder, IDeviceManagementResourceOperationsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceManagementResourceOperationsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementResourceOperationsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceManagementResourceOperationsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceManagementResourceOperationsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementResourceOperationsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IResourceOperationRequestBuilder"/> for the specified DeviceManagementResourceOperation.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementResourceOperation.</param>
        /// <returns>The <see cref="IResourceOperationRequestBuilder"/>.</returns>
        public IResourceOperationRequestBuilder this[string id]
        {
            get
            {
                return new ResourceOperationRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}

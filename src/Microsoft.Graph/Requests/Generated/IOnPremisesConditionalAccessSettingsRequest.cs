// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IOnPremisesConditionalAccessSettingsRequest.
    /// </summary>
    public partial interface IOnPremisesConditionalAccessSettingsRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified OnPremisesConditionalAccessSettings using PUT.
        /// </summary>
        /// <param name="onPremisesConditionalAccessSettingsToCreate">The OnPremisesConditionalAccessSettings to create.</param>
        /// <returns>The created OnPremisesConditionalAccessSettings.</returns>
        System.Threading.Tasks.Task<OnPremisesConditionalAccessSettings> CreateAsync(OnPremisesConditionalAccessSettings onPremisesConditionalAccessSettingsToCreate);        /// <summary>
        /// Creates the specified OnPremisesConditionalAccessSettings using PUT.
        /// </summary>
        /// <param name="onPremisesConditionalAccessSettingsToCreate">The OnPremisesConditionalAccessSettings to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OnPremisesConditionalAccessSettings.</returns>
        System.Threading.Tasks.Task<OnPremisesConditionalAccessSettings> CreateAsync(OnPremisesConditionalAccessSettings onPremisesConditionalAccessSettingsToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified OnPremisesConditionalAccessSettings.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified OnPremisesConditionalAccessSettings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified OnPremisesConditionalAccessSettings.
        /// </summary>
        /// <returns>The OnPremisesConditionalAccessSettings.</returns>
        System.Threading.Tasks.Task<OnPremisesConditionalAccessSettings> GetAsync();

        /// <summary>
        /// Gets the specified OnPremisesConditionalAccessSettings.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OnPremisesConditionalAccessSettings.</returns>
        System.Threading.Tasks.Task<OnPremisesConditionalAccessSettings> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified OnPremisesConditionalAccessSettings using PATCH.
        /// </summary>
        /// <param name="onPremisesConditionalAccessSettingsToUpdate">The OnPremisesConditionalAccessSettings to update.</param>
        /// <returns>The updated OnPremisesConditionalAccessSettings.</returns>
        System.Threading.Tasks.Task<OnPremisesConditionalAccessSettings> UpdateAsync(OnPremisesConditionalAccessSettings onPremisesConditionalAccessSettingsToUpdate);

        /// <summary>
        /// Updates the specified OnPremisesConditionalAccessSettings using PATCH.
        /// </summary>
        /// <param name="onPremisesConditionalAccessSettingsToUpdate">The OnPremisesConditionalAccessSettings to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated OnPremisesConditionalAccessSettings.</returns>
        System.Threading.Tasks.Task<OnPremisesConditionalAccessSettings> UpdateAsync(OnPremisesConditionalAccessSettings onPremisesConditionalAccessSettingsToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IOnPremisesConditionalAccessSettingsRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IOnPremisesConditionalAccessSettingsRequest Expand(Expression<Func<OnPremisesConditionalAccessSettings, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IOnPremisesConditionalAccessSettingsRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IOnPremisesConditionalAccessSettingsRequest Select(Expression<Func<OnPremisesConditionalAccessSettings, object>> selectExpression);

    }
}

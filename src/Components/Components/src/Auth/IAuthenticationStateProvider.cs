// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components
{
    /// <summary>
    /// Provides information about the authentication state of the current user.
    /// </summary>
    public interface IAuthenticationStateProvider
    {
        /// <summary>
        /// Gets an <see cref="IAuthenticationState"/> instance that describes
        /// the current user.
        /// </summary>
        /// <param name="forceRefresh">If true, instructs the provider to re-determine the user's authentication state, which can be an expensive operation. If false, the provider may reuse data cached for the current user.</param>
        /// <returns>An <see cref="IAuthenticationState"/> instance that describes the current user.</returns>
        Task<IAuthenticationState> GetAuthenticationStateAsync(bool forceRefresh);
    }
}

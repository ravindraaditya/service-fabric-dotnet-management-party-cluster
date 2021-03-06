﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace PartyCluster.Domain
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.ServiceFabric.Services.Remoting;

    public interface IClusterService : IService
    {
        Task<IEnumerable<ClusterView>> GetClusterListAsync();
        Task JoinClusterAsync(int clusterId, string userEmail);
    }
}
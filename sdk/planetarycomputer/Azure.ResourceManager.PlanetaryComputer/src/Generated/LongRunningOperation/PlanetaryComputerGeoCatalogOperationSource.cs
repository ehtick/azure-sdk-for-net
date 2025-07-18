// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.PlanetaryComputer
{
    internal class PlanetaryComputerGeoCatalogOperationSource : IOperationSource<PlanetaryComputerGeoCatalogResource>
    {
        private readonly ArmClient _client;

        internal PlanetaryComputerGeoCatalogOperationSource(ArmClient client)
        {
            _client = client;
        }

        PlanetaryComputerGeoCatalogResource IOperationSource<PlanetaryComputerGeoCatalogResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<PlanetaryComputerGeoCatalogData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerPlanetaryComputerContext.Default);
            return new PlanetaryComputerGeoCatalogResource(_client, data);
        }

        async ValueTask<PlanetaryComputerGeoCatalogResource> IOperationSource<PlanetaryComputerGeoCatalogResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<PlanetaryComputerGeoCatalogData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerPlanetaryComputerContext.Default);
            return await Task.FromResult(new PlanetaryComputerGeoCatalogResource(_client, data)).ConfigureAwait(false);
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Routes._PathParameters.LabelExpansion;
using Routes._PathParameters.MatrixExpansion;
using Routes._PathParameters.PathExpansion;
using Routes._PathParameters.ReservedExpansion;
using Routes._PathParameters.SimpleExpansion;

namespace Routes._PathParameters
{
    public partial class PathParameters
    {
        protected PathParameters() => throw null;

        public virtual HttpPipeline Pipeline => throw null;

        public virtual Response TemplateOnly(string @param, RequestContext context) => throw null;

        public virtual Task<Response> TemplateOnlyAsync(string @param, RequestContext context) => throw null;

        public virtual Response TemplateOnly(string @param, CancellationToken cancellationToken = default) => throw null;

        public virtual Task<Response> TemplateOnlyAsync(string @param, CancellationToken cancellationToken = default) => throw null;

        public virtual Response Explicit(string @param, RequestContext context) => throw null;

        public virtual Task<Response> ExplicitAsync(string @param, RequestContext context) => throw null;

        public virtual Response Explicit(string @param, CancellationToken cancellationToken = default) => throw null;

        public virtual Task<Response> ExplicitAsync(string @param, CancellationToken cancellationToken = default) => throw null;

        public virtual Response AnnotationOnly(string @param, RequestContext context) => throw null;

        public virtual Task<Response> AnnotationOnlyAsync(string @param, RequestContext context) => throw null;

        public virtual Response AnnotationOnly(string @param, CancellationToken cancellationToken = default) => throw null;

        public virtual Task<Response> AnnotationOnlyAsync(string @param, CancellationToken cancellationToken = default) => throw null;

        public virtual PathParametersReservedExpansion GetPathParametersReservedExpansionClient() => throw null;

        public virtual PathParametersSimpleExpansion GetPathParametersSimpleExpansionClient() => throw null;

        public virtual PathParametersPathExpansion GetPathParametersPathExpansionClient() => throw null;

        public virtual PathParametersLabelExpansion GetPathParametersLabelExpansionClient() => throw null;

        public virtual PathParametersMatrixExpansion GetPathParametersMatrixExpansionClient() => throw null;
    }
}

using Microsoft.TeamFoundation.Build.WebApi;
using Microsoft.VisualStudio.Services.Agent;
using System;

namespace Microsoft.VisualStudio.Services.Agent.Worker.Build
{
    public sealed class TfsVCSourceProvider : SourceProvider, ISourceProvider
    {
        public override string RepositoryType => WellKnownRepositoryTypes.TfsVersionControl;
    }
}
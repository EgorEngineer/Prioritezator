using Prioritezator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prioritezator.Interfaces
{
    public interface IVotingService
    {
        Task<List<Feature>> GetFeaturesAsync();
        Task<Feature> VoteAsync(int featureId);
    }

}

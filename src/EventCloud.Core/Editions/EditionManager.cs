using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Editions;
using Abp.Domain.Repositories;
using Abp.Application.Features;

namespace EventCloud.Editions
{
    public class EditionManager : AbpEditionManager
    {
        public EditionManager(IRepository<Edition> editionRepository, IRepository<EditionFeatureSetting, long> editionFeatureRepository)
            : base(editionRepository, editionFeatureRepository)
        { 
        
        }
    }
}

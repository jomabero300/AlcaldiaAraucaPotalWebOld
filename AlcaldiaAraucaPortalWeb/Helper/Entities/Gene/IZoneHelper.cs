﻿using AlcaldiaAraucaPortalWeb.Data.Entities.Gene;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AlcaldiaAraucaPortalWeb.Helper.Entities.Gene
{
    public interface IZoneHelper
    {
        Task<List<Zone>> ComboAsync();
    }
}

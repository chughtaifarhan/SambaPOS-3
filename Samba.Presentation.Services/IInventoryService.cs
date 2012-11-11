﻿using System.Collections.Generic;
using Samba.Domain.Models.Inventories;
using Samba.Domain.Models.Settings;
using Samba.Infrastructure.Data;
using Samba.Presentation.Services.Common;

namespace Samba.Presentation.Services
{
    public interface IInventoryService : IPresentationService
    {
        PeriodicConsumption GetPreviousPeriodicConsumption(IWorkspace workspace);
        PeriodicConsumption GetCurrentPeriodicConsumption(IWorkspace workspace);
        void CalculateCost(PeriodicConsumption pc, WorkPeriod workPeriod);
        IEnumerable<string> GetInventoryItemNames();
        IEnumerable<string> GetGroupCodes();
    }
}
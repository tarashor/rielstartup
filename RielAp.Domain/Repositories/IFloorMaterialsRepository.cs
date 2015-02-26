﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RielAp.Domain.Models;

namespace RielAp.Domain.Repositories
{
    public interface IFloorMaterialsRepository:IRepository<FloorMaterial>
    {
        FloorMaterial GetFloorMaterialByName(string floorMaterialName);
    }
}

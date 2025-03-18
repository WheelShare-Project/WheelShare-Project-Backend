﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Entities;
using Service.NewFolder;

namespace Service.Interfaces
{
    public interface IGoogleMapsAlgorithm
    {
        public Task<Coordinates> GetCoordinates(string address);

        public Task<double> TravelTimeCalculation(string origin, string destination);

        public Task OptimalPlaceMent(Ride ride);

    }
}

﻿using DeltaDriveBE.DTO.AuthDTO;
using DeltaDriveBE.Models;

namespace DeltaDriveBE.Interfaces.Repository
{
    public interface IPassengerRepository
    {
        Passenger? AddPassanger(Passenger passangers);
        Passenger? FindPassenger(LoginPassengerRequestDTO passenger);
        List<Driver>? GetDrivers(int amount, float latitude, float longitude);
    }
}

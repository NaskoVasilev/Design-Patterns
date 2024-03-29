﻿namespace VehicleShop
{
    using VehicleShop.Builders;

    /// <summary>
    ///  The 'Director' class
    /// </summary>
    public class Shop
    {
        public void Construct(VehicleBuilder builder)
        {
            builder
                .BuildFrame()
                .BuildEngine()
                .BuildWheels()
                .BuildDoors();
        }
    }
}

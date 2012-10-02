﻿using System;

namespace ShootR
{
    public class GameTime
    {
        public GameTime()
        {
            LastUpdated = DateTime.UtcNow;
            PercentOfSecond = 0;
        }

        public static DateTime LastUpdated { get; set; }
        /// <summary>
        /// This is updated on Update to show what percent of a second has passed since the last Update loop.
        /// </summary>
        public double PercentOfSecond { get; set; }

        public static double CalculatePercentOfSecond(DateTime from)
        {
            return (DateTime.UtcNow.Subtract(from.ToUniversalTime()).Milliseconds / 1000.0);
        }

        public void Update()
        {
            PercentOfSecond = CalculatePercentOfSecond(LastUpdated);
            LastUpdated = DateTime.UtcNow;
        }
    }
}
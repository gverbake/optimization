﻿// OsmSharp - OpenStreetMap (OSM) SDK
// Copyright (C) 2015 Abelshausen Ben
// 
// This file is part of OsmSharp.
// 
// OsmSharp is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 2 of the License, or
// (at your option) any later version.
// 
// OsmSharp is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with OsmSharp. If not, see <http://www.gnu.org/licenses/>.

using OsmSharp.Routing;
using System;
using System.Collections.Generic;

namespace OsmSharp.Logistics.Routing.TSPTW
{
    /// <summary>
    /// Abstract representation of a router that calculates and solves the TSPTW-route along a set of given points.
    /// </summary>
    public interface ITSPTWRouter : IAlgorithm
    {
        /// <summary>
        /// Builds the resulting route.
        /// </summary>
        /// <returns></returns>
        Route BuildRoute();

        /// <summary>
        /// Builds the result route in segments divided by routes between customers.
        /// </summary>
        /// <returns></returns>
        List<Route> BuildRoutes();

        /// <summary>
        /// Returns the errors indexed per location idx.
        /// </summary>
        Dictionary<int, OsmSharp.Logistics.Routing.LocationError> Errors { get; }

        /// <summary>
        /// Gets the raw route representing the order of the locations.
        /// </summary>
        OsmSharp.Logistics.Routes.IRoute RawRoute { get; }
    }
}
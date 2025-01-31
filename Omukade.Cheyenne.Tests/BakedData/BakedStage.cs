﻿/*************************************************************************
* Tests for Omukade Cheyenne - A PTCGL "Rainier" Standalone Server
* (c) 2022 Hastwell/Electrosheep Networks 
* 
* This program is free software: you can redistribute it and/or modify
* it under the terms of the GNU Affero General Public License as published
* by the Free Software Foundation, either version 3 of the License, or
* (at your option) any later version.
* 
* This program is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
* GNU Affero General Public License for more details.
* 
* You should have received a copy of the GNU Affero General Public License
* along with this program.  If not, see <http://www.gnu.org/licenses/>.
**************************************************************************/

using Microsoft.AspNetCore.Routing;
using Platform.Sdk;
using Platform.Sdk.Models.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Route = Platform.Sdk.Route;

namespace Omukade.Cheyenne.Tests.BakedData
{
    internal class BakedStage : Stage
    {
        public bool BypassValidation { get; set; }

        public bool SupportsRouting { get; set; }

        public Route GlobalRoute { get; set; }

        public string name { get; set; }

        public Route RouteForRegion(string region, string primeRegion)
        {
            return new DomainRoute(region, primeRegion);
        }

        public Route RouteForRegion(string region)
        {
            return new DomainRoute(region, region);
        }

        public Route RouteForResponse(QueryRouteResponse route)
        {
            return new DomainRoute(route.route, route.primeRoute, route.serviceGroup);
        }
    }
}

﻿/*************************************************************************
* Omukade Cheyenne - A PTCGL "Rainier" Standalone Server
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

using RainierClientSDK.source.Game;
using SharedSDKUtils;

namespace Omukade.Cheyenne.Shell.Model
{
    class GetCurrentGamesResponse
    {
        internal List<GameSummary>? ongoingGames {  get; set; }

        internal struct GameSummary
        {
            public string GameId;
            public string Player1, Player2;
            public int PrizeCountPlayer1, PrizeCountPlayer2;
        }
    }
}

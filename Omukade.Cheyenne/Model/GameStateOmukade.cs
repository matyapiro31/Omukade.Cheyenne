﻿using Newtonsoft.Json;
using SharedSDKUtils;

namespace Omukade.Cheyenne.Model
{
    [Serializable]
    public class GameStateOmukade : GameState
    {
        [NonSerialized]
        internal GameServerCore parentServerInstance;

        [NonSerialized]
        internal PlayerMetadata? player1metadata;

        [NonSerialized]
        internal PlayerMetadata? player2metadata;

        /// <summary>
        /// JSON Constructor; please don't use this.
        /// </summary>
        /// <param name="parentServerInstance"></param>
        [JsonConstructor]
        [Obsolete("JSON Constructor; please don't use this directly.")]
        public GameStateOmukade() : base()
        {
            
        }

        public GameStateOmukade(GameServerCore parentServerInstance) : base()
        {
            this.parentServerInstance = parentServerInstance;
        }

        public new GameState CopyState()
        {
            GameStateOmukade cloneGso = JsonConvert.DeserializeObject<GameStateOmukade>(JsonConvert.SerializeObject(this, settings), settings)!;
            cloneGso.parentServerInstance = this.parentServerInstance;
            cloneGso.player1metadata = this.player1metadata;
            cloneGso.player2metadata = this.player2metadata;

            return cloneGso;
        }
    }
}

using HarmonyLib;
using Newtonsoft.Json;
using Omukade.Cheyenne.Encoding;
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

        [NonSerialized]
        public JsonSerializerSettings? settingsOmukade;

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
            settingsOmukade = AccessTools.Field(typeof(GameState), "settings").GetValue(this) as JsonSerializerSettings;
            if (settingsOmukade == null)
            {
                settingsOmukade = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.Auto, ContractResolver = new WhitelistedContractResolver() };
            }
            GameStateOmukade cloneGso = FasterJson.JsonClone<GameStateOmukade>(this, settingsOmukade);
            cloneGso.parentServerInstance = this.parentServerInstance;
            cloneGso.player1metadata = this.player1metadata;
            cloneGso.player2metadata = this.player2metadata;

            return cloneGso;
        }
    }
}

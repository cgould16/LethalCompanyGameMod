using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LethalIdiots
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class LethalIdiotsBase : BaseUnityPlugin
    {
        private const String modGUID = "Thor.LethalIdiots";
        private const String modName = "Lethal Idiots Mod";
        private const String modVersion = "1.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);
        private static LethalIdiotsBase Instance;

        internal ManualLogSource mls;

        void Awake()
        {
            if(Instance == null)
            {
                Instance = this;
            }

            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);

            mls.LogInfo("Lethal Idiots are binge drinking....");

            harmony.PatchAll(typeof(LethalIdiotsBase));
        }
    }
}

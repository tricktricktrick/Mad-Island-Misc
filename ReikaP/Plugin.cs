using HarmonyLib;
using MelonLoader;
using ReikaP.Patches;

[assembly: MelonInfo(typeof(ReikaP.ReikaBase), "Ex Reika Pregnancy Enabler", "1.0.0", "ReikaP")]
[assembly: MelonGame("Emade Plus", "Mad Island")]

namespace ReikaP
{
    public class ReikaBase : MelonMod
    {
        private const string modGUID = "Ex.ReikaP";
        private const string modName = "Ex Reika Pregnancy Enabler";
        private const string modVersion = "1.0.0";

        private readonly HarmonyLib.Harmony harmony = new HarmonyLib.Harmony(modGUID);
        private static ReikaBase Instance;

        public override void OnInitializeMelon()
        {

            if (Instance == null)
            {
                Instance = this;
            }

            MelonLogger.Msg($"Initializing {modName}");

            harmony.PatchAll(typeof(ReikaBase));
            harmony.PatchAll(typeof(SexManagerPatch));
            harmony.PatchAll(typeof(AltPatch));

            MelonLogger.Msg("Fill them up.");
        }
    }
}

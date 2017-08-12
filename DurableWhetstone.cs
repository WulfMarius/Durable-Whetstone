using Harmony;

namespace DurableWhetstone
{
    [HarmonyPatch(typeof(GearItem))]
    [HarmonyPatch("Degrade")]
    public class DurableWhetstone
    {
        static bool Prefix(GearItem __instance, ref float hp)
        {
            if (__instance && __instance.name == "GEAR_SharpeningStone")
            {
                hp = 1;
            }

            return true;
        }
    }
}

using Harmony;
using UnityEngine;

namespace DurableWhetstone
{
    [HarmonyPatch(typeof(Inventory), "AddGear")]
    internal class Inventory_AddGear
    {
        private static void Prefix(GameObject go)
        {
            if (go == null)
            {
                return;
            }

            if (go.name == "GEAR_SharpeningStone")
            {
                Implementation.AdjustDegradeOnUse(go, 1);
            }
        }
    }
}
using UnityEngine;
using Harmony;

namespace DurableWhetstone
{
    public class Implementation
    {
        public static void OnLoad()
        {
            Debug.Log("[Durable-Whetstone]: Version " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version);
        }

        internal static void AdjustDegradeOnUse(GameObject gameObject, float value)
        {
            DegradeOnUse degradeOnUse = gameObject.GetComponent<DegradeOnUse>();
            if (degradeOnUse == null)
            {
                return;
            }

            degradeOnUse.m_DegradeHP = value;
        }
    }
}
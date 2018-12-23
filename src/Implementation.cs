using UnityEngine;

namespace DurableWhetstone
{
    public class Implementation
    {
        private const string NAME = "Durable-Whetstone";

        public static void OnLoad()
        {
            Log("Version " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version);
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

        internal static void Log(string message)
        {
            Debug.LogFormat("[" + NAME + "] {0}", message);
        }

        internal static void Log(string message, params object[] parameters)
        {
            string preformattedMessage = string.Format("[" + NAME + "] {0}", message);
            Debug.LogFormat(preformattedMessage, parameters);
        }
    }
}
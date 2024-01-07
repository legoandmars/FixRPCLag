using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;
using Unity.Netcode;

namespace FixRPCLag.Patches
{
    [HarmonyPatch(typeof(NetworkManager))]
    internal class NetworkManagerPatches
    {
        [HarmonyPatch("Awake")]
        [HarmonyPostfix]
        private static void Patch(NetworkManager __instance)
        {
            __instance.LogLevel = Plugin.ConfigLogLevel.Value;
        }
    }
}

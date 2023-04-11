using MelonLoader;
using UnityEngine;
using Il2CppInterop;
using Il2CppInterop.Runtime.Injection; 
using System.Collections;
using Harmony;
using Il2Cpp;

namespace InfiniteFiresDLC
{
    [HarmonyPatch(typeof(Fire), "Awake")]
    internal static class Fire_Awake
    {
        private static void Postfix(Fire __instance)
        {
            var _ = __instance.GetComponent<AlternativeFireAction>() ?? __instance.gameObject.AddComponent<AlternativeFireAction>();
        }
    }

    [HarmonyPatch(typeof(WoodStove), "Awake")]
    internal static class WoodStove_Awake
    {
        private static void Postfix(Fire __instance)
        {
            var _ = __instance.GetComponent<AlternativeFireAction>() ?? __instance.gameObject.AddComponent<AlternativeFireAction>();
        }
    }
}
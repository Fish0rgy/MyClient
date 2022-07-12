using ExitGames.Client.Photon;
using HarmonyLib;
using Photon.Realtime;
using System.Collections.Generic;
using System.Reflection;
using VRC.SDKBase;

namespace MyClient.SDK.PatchAPI.Patches
{
    public static class _OnEvent
    {
        public static void InitOnEvent()
        {
            try
            {
                // this is how you would make new patching just follow the format
                // Example Format: MyClientPatch.Instance.Patch(typeof(ClassName).GetMethod("Method Name"), new HarmonyMethod(AccessTools.Method(typeof(Your Method Name), nameof(OnEvent))));

                //MyClientPatch.Instance.Patch(typeof(VRC.UI.Elements.QuickMenu).GetMethod("Awake"), null, new HarmonyMethod(AccessTools.Method(typeof(Main), "OnUIInit")));
                //MyClientPatch.Instance.Patch(typeof(LoadBalancingClient).GetMethod("OnEvent"), new HarmonyMethod(AccessTools.Method(typeof(_OnEvent), nameof(OnEvent))));
                //MyClientPatch.Instance.Patch(AccessTools.Method(typeof(LoadBalancingClient), "Method_Public_Virtual_New_Void_EventData_0", null, null), new HarmonyMethod(AccessTools.Method(typeof(_OnEvent), nameof(OnEvent))));

                SDK.LogHandler.Log(SDK.LogHandler.Colors.Green, "[Patch] Basic Patches", false, false);
            }
            catch
            {
                SDK.LogHandler.Log(SDK.LogHandler.Colors.Red, "[Patch] [Error] Basic Patches", false, false);
            }
        }
        // method we are calling to hook into the Assembly-CSharp.dll and put our own code 
        [Obfuscation(Exclude = true)]
        private static bool OnEvent(EventData __0)
        {
            if (__0 == null) { return false; }
            // you always want to put this in every patch (you may need to tweak it a bit but generally the same for every patch) so you can call this in any mod file to create the mods them self
            for (int i = 0; i < Main.Instance.OnUpdateEvents.ToArray().Length; i++) { if (!Main.Instance.OnEventEvents.ToArray()[i].OnEvent(__0)) return false; }
            return true;
        }
    }
}

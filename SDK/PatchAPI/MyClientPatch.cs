using HarmonyLib;
using MyClient.SDK.PatchAPI.Patches;
using System;
using System.Reflection;

namespace MyClient.SDK.PatchAPI
{
    class MyClientPatch
    {
        //automated patching system to let you know which patch is working or not without shitty try and catch statements in one cs
        public static HarmonyLib.Harmony Instance = new HarmonyLib.Harmony("My Client");

        //patch method
        public static HarmonyMethod GetLocalPatch(Type type, string methodName)
        {
            //patching the type aka the class name from Assembly-CSharp.dll, method name from that class, and how your patching that hook""
            return new HarmonyMethod(type.GetMethod(methodName, BindingFlags.Static | BindingFlags.NonPublic));
        }

        //this is what we call to start the patching system in main.cs
        public static void InitPatches()
        {
            try
            {
                LogHandler.Log(LogHandler.Colors.Green, "[Patch] Starting Patches....", false, false);
                _OnEvent.InitOnEvent();
            }
            catch (Exception ERR) { LogHandler.Log(LogHandler.Colors.Green, ERR.Message, false, false); }
        }
    }
} 

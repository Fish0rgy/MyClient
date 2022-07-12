using MelonLoader;
using MyClient.Events;
using MyClient.Modules;
using MyClient.SDK;
using MyClient.SDK.ButtonAPI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Threading.Tasks;
using UnityEngine;

namespace MyClient
{
    public class Main : MelonMod
    {
        //CREDITS: Base Made By Fish.#0001


        //This is where you put your menu ref and shit to create them
        public static Main Instance { get; set; }

        internal ButtonIcons QuickMenuStuff { get; set; }
        internal QMNestedButton ExampleButton { get; set; }
        internal QMNestedButton Targetbutton { get; set; }
        internal QMNestedButton Examplesettings { get; set; }
        internal QMNestedButton ExampleNestedSettings { get; set; }


        //this is used for your buttons to add a list of modules for litterly anythin pertaining to them
        internal List<BaseModule> Modules { get; set; } = new List<BaseModule>();

        //this is your apart of your patching system to automate mod creating and help you call to the patching hook without a shitty config
        public List<OnUpdateEvent> OnUpdateEvents { get; set; } = new List<OnUpdateEvent>();
        public List<OnEventEvent> OnEventEvents { get; set; } = new List<OnEventEvent>();

         
        //on application start just executes what ever we want when application is running
        public override void OnApplicationStart()
        {
            Instance = new Main();
            Task.Run(() =>
            {
                //MyClient.SDK.PatchAPI.MyClientPatch.InitPatches();
            }); 
             
        }
        // constant check of what ever the fuck you put in here/constant loop
        public override void OnUpdate()
        {
            for (int i = 0; i < Instance.OnUpdateEvents.ToArray().Length; i++) { Instance.OnUpdateEvents.ToArray()[i].OnUpdate(); }
            if (Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.LeftAlt))
            {
                if (Input.GetKeyDown(KeyCode.Backspace))
                {
                    Process.Start("VRChat.exe", Environment.CommandLine);
                    Process.GetCurrentProcess().Kill(); 
                }
            }
        }
        [Obfuscation(Exclude = true)]
        public static void InitMenu()
        {
            try { MelonCoroutines.Start(MainUI.StartUI()); LogHandler.Log(LogHandler.Colors.Green, "Client UI Created!", true, false); } catch (Exception ERROR) { LogHandler.Log(LogHandler.Colors.Red, ERROR.Message, true, false); }
        }
        public override void OnGUI() {
             
        } 
    }
}

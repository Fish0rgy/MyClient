using UnityEngine; 
using System.Collections;
using System;
using MyClient.SDK;
using MyClient.SDK.ButtonAPI;
using MyClient.Modules.Example;
using MyClient.Modules;
using System.Collections.Generic;
using System.Reflection;

namespace MyClient
{
    class MainUI
    {
        public static IEnumerator StartUI()
        {
            Console.Title = $"My Client | Developed By Fish.#0001";
            Main.Instance.QuickMenuStuff = new ButtonIcons();
            QMTab mainTab = new QMTab("My Client", "", "Big Nigga Shit", QMButtonIcons.LoadSpriteFromFile(ButtonIcons.rocket));
            //example for your own icon
            //QMTab mainTab = new QMTab("MyClient", "", "Big Nigga Shit", QMButtonIcons.CreateSpriteFromBase64(ButtonIcons.clientLogo));


            //Creating buttons for tab menu example
            Main.Instance.ExampleButton = new QMNestedButton(mainTab.menuTransform, "Nested Button", null);

            //targetmenu
            //Main.Instance.Targetbutton = new QMNestedButton(Main.Instance.QuickMenuStuff.selectedUserMenuQM.transform.Find("ScrollRect/Viewport/VerticalLayoutGroup/Buttons_UserActions/").transform, "Target Button\n Example", QMButtonIcons.CreateSpriteFromBase64(ButtonIcons.rocket));
            //Main.Instance.Examplesettings = new QMNestedButton(Main.Instance.Targetbutton.menuTransform, "Nested Button\n Example", QMButtonIcons.CreateSpriteFromBase64(ButtonIcons.rocket));
            //Main.Instance.ExampleNestedSettings = new QMNestedButton(Main.Instance.Examplesettings.menuTransform, "Nested Button\n Example", QMButtonIcons.CreateSpriteFromBase64(ButtonIcons.rocket));

            //creating mod buttons

            //method one
            new QMToggleButton(mainTab.menuTransform, "Toggle Button 1", "Toggles loud mic", (state) =>
            {
                if (state)
                {
                    LogHandler.Log(LogHandler.Colors.Green, "on",false,false);
                }
                else
                {
                    LogHandler.Log(LogHandler.Colors.Green, "off", false, false);
                }
            });
            new QMSingleButton(mainTab.menuTransform, "Single Button 1", "Changes the bots orbit speed", null, () =>
            {

                LogHandler.Log(LogHandler.Colors.Green, "Single Button clicked", false, false);
            });

            //method two
            Assembly assm = Assembly.GetExecutingAssembly();

            foreach (Type t in assm.GetTypes())
            {
                if (!moduleArray.Contains(t.Name)) continue;

                object newInst = Activator.CreateInstance(t, new object[0]);
                object newObj = Convert.ChangeType(newInst, t);
                Main.Instance.Modules.Add((BaseModule)newObj);
                yield return null;
            }

            //Loads "Modules" and Creates UI/Buttions
            foreach (BaseModule module in Main.Instance.Modules)
            {
                module.OnUIInit();
                yield return null;
            }

            //Loads Modules and creates the UI/Buttons
            foreach (BaseModule module in Main.Instance.Modules) module.OnUIInit();


            yield return new WaitForSecondsRealtime(0.1f);
        }
        private static List<string> moduleArray = new()
        {
            "SingleButtonExample2",
            "ToggleButtonExample2"
        };
    }
}

using UnityEngine; 
using System.Collections;
using System;
using MyClient.SDK;
using MyClient.SDK.ButtonAPI;
using MyClient.Modules.Example;
using MyClient.Modules;

namespace MyClient
{
    class MainUI
    {
        public static IEnumerator StartUI()
        {
            Console.Title = $"My Client | Developed By Fish.#0001";
            Main.Instance.QuickMenuStuff = new ButtonIcons();
            QMTab mainTab = new QMTab("My Client", "", "Big Nigga Shit", QMButtonIcons.CreateSpriteFromBase64(ButtonIcons.rocket));
            //example for your own icon
            //QMTab mainTab = new QMTab("MyClient", "", "Big Nigga Shit", QMButtonIcons.CreateSpriteFromBase64(ButtonIcons.clientLogo));


            //Creating buttons for tab menu example
            Main.Instance.ExampleButton = new QMNestedButton(mainTab.menuTransform, "Nested Button", QMButtonIcons.CreateSpriteFromBase64(ButtonIcons.rocket));

            //targetmenu
            //Main.Instance.Targetbutton = new QMNestedButton(Main.Instance.QuickMenuStuff.selectedUserMenuQM.transform.Find("ScrollRect/Viewport/VerticalLayoutGroup/Buttons_UserActions/").transform, "Target Button\n Example", QMButtonIcons.CreateSpriteFromBase64(ButtonIcons.rocket));
            //Main.Instance.Examplesettings = new QMNestedButton(Main.Instance.Targetbutton.menuTransform, "Nested Button\n Example", QMButtonIcons.CreateSpriteFromBase64(ButtonIcons.rocket));
            //Main.Instance.ExampleNestedSettings = new QMNestedButton(Main.Instance.Examplesettings.menuTransform, "Nested Button\n Example", QMButtonIcons.CreateSpriteFromBase64(ButtonIcons.rocket));
             
            //creating mod buttons
            Main.Instance.Modules.Add(new SingleButtonExample());
            Main.Instance.Modules.Add(new ToggleButtonExample());


            //Loads Modules and creates the UI/Buttons
            foreach (BaseModule module in Main.Instance.Modules) module.OnUIInit();


            yield return new WaitForSecondsRealtime(0.1f);
        }
    }
}

using MyClient.SDK.ButtonAPI;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using VRC.UI.Elements;
using VRC.UI.Elements.Menus;

namespace MyClient.SDK
{
    class ButtonIcons
    { 
        //Button Icon Locations
        public Image Button_WorldsIcon;
        public Image Button_AvatarsIcon;
        public Image Button_SocialIcon;
        public Image Button_SafetyIcon;
        public Image Panel_NoNotifications_MessageIcon;
        public Image Button_NameplateVisibleIcon;
        public Image Button_GoHomeIcon;
        public Image Button_RespawnIcon;
        public Image StandIcon;

        //Menu Transform Locations
        public Transform tabMenuTemplat;
        public Transform Menu_DevTools;
        public Transform Menu_Dashboard;
        public Transform QMParent;
        public Transform page_Buttons_QM;
        public VRC.UI.Elements.QuickMenu quickMenu;
        public static VRC.UI.Elements.QuickMenu Qmenu;
        public SelectedUserMenuQM selectedUserMenuQM;
        public MenuStateController menuStateController;

        public static bool UIUpdated = false;

        public static object Instance { get; internal set; }



        //Custom Icon Example
        public const string example = "google base 64 guru then put the base64 string here";
        public const string rocket = "MyClient\\Icons\\rocket.png";
        public const string ToggleOn = "MyClient\\Icons\\ToggleOn.png";
        public const string ToggleOff = "MyClient\\Icons\\ToggleOff.png";

        public ButtonIcons()
        {
            quickMenu = Resources.FindObjectsOfTypeAll<VRC.UI.Elements.QuickMenu>().First();
            menuStateController = quickMenu.gameObject.GetComponent<MenuStateController>();

            //This is where you find and put the icons already used in vrc to use as your button icons you can find all the icons here: Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/
            //example
            Button_WorldsIcon = quickMenu.transform.Find("Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Worlds/Icon").GetComponent<Image>();
            Button_AvatarsIcon = quickMenu.transform.Find("Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Avatars/Icon").GetComponent<Image>();
            Button_SocialIcon = quickMenu.transform.Find("Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Social/Icon").GetComponent<Image>();
            Button_SafetyIcon = quickMenu.transform.Find("Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Safety/Icon").GetComponent<Image>();

            Button_GoHomeIcon = quickMenu.transform.Find("Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_GoHome/Icon").GetComponent<Image>();
            Button_RespawnIcon = quickMenu.transform.Find("Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_Respawn/Icon").GetComponent<Image>();
            StandIcon = quickMenu.transform.Find("Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/SitStandCalibrateButton/Button_SitStand/Icon_Off").GetComponent<Image>();
            Panel_NoNotifications_MessageIcon = quickMenu.transform.Find("Container/Window/QMParent/Menu_Notifications/Panel_NoNotifications_Message/Icon").gameObject.GetComponent<Image>();

            Button_NameplateVisibleIcon = quickMenu.transform.Find("Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_UI_Elements_Row_1/Button_NameplateControls/Buttons/Button A/Icon").GetComponent<Image>();

             

            //ui menu location for shit you need to make button api
            selectedUserMenuQM = quickMenu.transform.Find("Container/Window/QMParent/Menu_SelectedUser_Local").GetComponent<SelectedUserMenuQM>();
            tabMenuTemplat = quickMenu.transform.Find("Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_DevTools");
            Menu_DevTools = quickMenu.transform.Find("Container/Window/QMParent/Menu_DevTools");
            QMParent = quickMenu.transform.Find("Container/Window/QMParent");
            page_Buttons_QM = quickMenu.transform.Find("Container/Window/Page_Buttons_QM/HorizontalLayoutGroup");
            Menu_Dashboard = quickMenu.transform.Find("Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Settings");
        }
    }
}

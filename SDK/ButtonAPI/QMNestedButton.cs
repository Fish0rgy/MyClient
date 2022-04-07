using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MyClient.SDK.ButtonAPI
{
    class QMNestedButton
    {
        public QMMenu menu;
        public Transform menuTransform;

        public QMNestedButton(Transform perant, string name, Sprite icon = null)
        {
            menu = new QMMenu(name, name, false, true);
            menuTransform = menu.menuContents;

            new QMSingleButton(perant, name, name, icon, delegate
            {
                menu.OpenMenu();
            });
        }
    }
}

using System;
using System.IO;
using UnityEngine;

namespace MyClient.SDK.ButtonAPI
{
    class QMButtonIcons
    {
        public static Sprite LoadSpriteFromFile(string path)
        {
            byte[] data = File.ReadAllBytes(path);
            Texture2D tex = new(256, 256);
            ImageConversion.LoadImage(tex, data);

            Rect rect = new Rect(0.0f, 0.0f, tex.width, tex.height);
            Vector2 pivot = new Vector2(0.5f, 0.5f);
            Vector4 border = Vector4.zero;

            Sprite sprite = Sprite.CreateSprite_Injected(tex, ref rect, ref pivot, 100, 0, SpriteMeshType.Tight, ref border, false);
            return sprite;
        }
    }
}

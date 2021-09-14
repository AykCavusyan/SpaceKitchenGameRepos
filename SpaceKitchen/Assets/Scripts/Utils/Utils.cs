using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Utils
{
    public class Utils
    {
        public static TextMesh CreateWorldText(string text, Transform parent =null, Vector3 localPos = default(Vector3), int fontSize = 40, Color fontColor = default(Color), TextAnchor textAnchor = TextAnchor.UpperLeft)
        {
            if (fontColor == default(Color)) fontColor = Color.white;
            return CreateWorldText(parent, text, localPos, fontSize, fontColor, textAnchor);
        }

        public static TextMesh CreateWorldText (Transform parent, string text, Vector3 localPos, int fontSize, Color fontColor, TextAnchor textAnchor)
        {
            GameObject gameObject = new GameObject("World_Text", typeof(TextMesh));
            Transform transform = gameObject.transform;
            transform.SetParent(parent, false);
            transform.localPosition = localPos;
            TextMesh textMesh = gameObject.GetComponent<TextMesh>();
            textMesh.text = text;
            textMesh.fontSize = fontSize;
            textMesh.color = fontColor;
            textMesh.anchor = textAnchor;

            return textMesh;
        }
    }
}


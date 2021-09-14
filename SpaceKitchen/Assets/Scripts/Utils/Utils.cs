using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Utils
{
    public class Utils
    {
        public static TextMesh CreateWorldText(string text, Transform parent =null, Vector3 localPos = default(Vector3), int fontSize = 20, Color fontColor = default(Color), TextAnchor textAnchor = TextAnchor.UpperLeft)
        {
            if (fontColor == default (Color))
            {
                fontColor = Color.white;
            }
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

        // Get mouse Position in World with Z = 0f
        public static Vector3 GetMouseWorldPosition ()
        {
            Vector3 vector3 = GetMouseWorldPositionWithZ (Input.mousePosition, Camera.main);
            vector3.z = 0f;
            return vector3;
        }

        public static Vector3 GetMouseWorldPositionWithZ ()
        {
            return GetMouseWorldPositionWithZ (Input.mousePosition, Camera.main);
        }

        public static Vector3 GetMouseWorldPositionWithZ (Camera worldCamera)
        {
            return GetMouseWorldPositionWithZ (Input.mousePosition, worldCamera);
        }

        public static Vector3 GetMouseWorldPositionWithZ (Vector3 screenPosition, Camera worldCamera)
        {
            Vector3 worldPosition = worldCamera.ScreenToWorldPoint (screenPosition);
            return worldPosition;
        }

    }  
}


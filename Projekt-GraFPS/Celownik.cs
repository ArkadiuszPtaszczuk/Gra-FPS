using UnityEngine;
using System.Collections;

public class Celownik : MonoBehaviour
{


    public bool rysujCelownik = true;
    public Color crosshairColor = Color.white;
    public float width = 2;
    public float rozmiarCel = 2;
    private Texture2D tex;
    private float newHeight;
    private GUIStyle lineStyle;

    void Awake()
    {
        tex = new Texture2D(1, 1);
        lineStyle = new GUIStyle();
        lineStyle.normal.background = tex;
    }


    void OnGUI()
    {
        Vector2 punktCentralny = new Vector2(Screen.width / 2, Screen.height / 2);
        float screenRatio = Screen.height / 150;
        newHeight = rozmiarCel * screenRatio;

        if (rysujCelownik)
        {
            GUI.Box(new Rect(punktCentralny.x - (width / 2), punktCentralny.y - (newHeight), width, newHeight), GUIContent.none, lineStyle);
            GUI.Box(new Rect(punktCentralny.x - (width / 2), (punktCentralny.y), width, newHeight), GUIContent.none, lineStyle);
            GUI.Box(new Rect((punktCentralny.x), (punktCentralny.y - (width / 2)), newHeight, width), GUIContent.none, lineStyle);
            GUI.Box(new Rect(punktCentralny.x - (newHeight), (punktCentralny.y - (width / 2)), newHeight, width), GUIContent.none, lineStyle);
        }

        kolorCelownika(tex, crosshairColor);
    }

    void kolorCelownika(Texture2D myTexture, Color myColor)
    {
        for (int y = 0; y < myTexture.height; y++)
        {
            for (int x = 0; x < myTexture.width; x++)
            {
                myTexture.SetPixel(x, y, myColor);
            }
            myTexture.Apply();
        }
    }

}

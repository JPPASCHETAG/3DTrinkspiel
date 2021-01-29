using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class startgame : MonoBehaviour
{
    public TextMeshPro textMeshPro;
    public TextMeshPro DrinkMode;
    public TextMeshPro MapName;
   

    void OnMouseDown(){
        
        string text = textMeshPro.text;
        int playerNumber = Int32.Parse(text);
        GameSettings.setNumOfPlayer(playerNumber);

        int mode = 0;
        switch (DrinkMode.text)
        {
            case "Standard":
                mode = 0;
                break;
            case "Pussy":
                mode = 1;
                break;
            case "Krass":
                mode = 2;
                break;
            default:
                mode = 0;
                break;
        }
        GameSettings.setdrinkMode(mode);

        int Map = 0;
        switch (MapName.text)
        {
            case "Strand":
                Map = 3;
                GameSettings.setMapID(Map);
                Loader.Load(Loader.Scene.Map3);
                break;
            case "Insel":
                Map = 2;
                GameSettings.setMapID(Map);
                Loader.Load(Loader.Scene.Map2);
                break;
            default:
                Map = 0;
                break;
        }

    }
    
}

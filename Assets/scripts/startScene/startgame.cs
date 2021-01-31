using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;


public class startgame : MonoBehaviour
{
    public TextMeshPro textMeshPro;
    public TextMeshPro DrinkMode;
    public TextMeshPro MapName;

    public InputField PlayerName1;
    public InputField PlayerName2;
    public InputField PlayerName3;
    public InputField PlayerName4;

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

        GameSettings.setPlayer1name(PlayerName1.text);
        GameSettings.setPlayer2name(PlayerName2.text);
        GameSettings.setPlayer3name(PlayerName3.text);
        GameSettings.setPlayer4name(PlayerName4.text);
        
    }
    
}

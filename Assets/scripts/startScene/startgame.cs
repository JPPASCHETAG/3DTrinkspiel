using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class startgame : MonoBehaviour
{
public TextMeshPro textMeshPro;

    void OnMouseDown(){
        
        string text = textMeshPro.text;
        int playerNumber = Int32.Parse(text);
        GameSettings.setNumOfPlayer(playerNumber);

        Loader.Load(Loader.Scene.GameScene);

    }
    
}

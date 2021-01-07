
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasAufgabe : MonoBehaviour
{
    public CanvasGroup aufgabe;
    public CanvasGroup finish;

    public void closeAufgabe(){

        aufgabe.alpha = 0;
        diceRoll.roll = true;
    
        int playerID = diceRoll.currentPlayer;
        //Die Kamera beim nächsten Spieler positionieren
        
        switch(playerID){
            case 1:
                moveToPlayer(diceRoll.objPlayer1);
                break;
            case 2:
                moveToPlayer(diceRoll.objPlayer2);
                break;
            case 3:
                moveToPlayer(diceRoll.objPlayer3);
                break;
            case 4:
                moveToPlayer(diceRoll.objPlayer4);
                break;

        }


    }

    public void moveToPlayer(GameObject playerObject){
        if(playerObject.transform.position == new Vector3(-465,104,-2)){
            playerObject.transform.position = new Vector3(-465,1,0);
            Camera.main.transform.position = new Vector3(-517,47,2);
        }else{
            Vector3 newCamPos = playerObject.transform.position;
            newCamPos += new Vector3(-52,46,2);
            Camera.main.transform.position = newCamPos;

            Vector3 newRollPos = playerObject.transform.position;
            newRollPos += new Vector3(-5,0,-8);
            diceRoll.objTextMesh.transform.position = newRollPos;
        }
    }


    public void startNewRound(){

        finish.alpha = 0;
        Loader.Load(Loader.Scene.StartScene);

    }

    
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasAufgabe : MonoBehaviour
{
    public CanvasGroup aufgabe;
    public CanvasGroup finish;
    public GameObject diceSpawn;

    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;

    private GameObject player;

    public void closeAufgabe(){

        aufgabe.alpha = 0;
        ThrowDice.value = 0;
        ThrowDice.roll = true;

        // Destroy(GameObject.Find("d6(Clone)"));

        // newDiceRoll.isRolled = true;
        // newDiceRoll.canRoll = true;
        // newDiceRoll.rolledNum = 0;
        
        int playerID = ThrowDice.currentPlayer;
        //Die Kamera beim nächsten Spieler positionieren
        Debug.Log(playerID);
        
        switch(playerID){
            case 1:
                player = player1;
                break;
            case 2:
                player = player2;
                break;
            case 3:
                player = player3;
                break;
            case 4:
                player = player4;
                break;
        }

        // Vector3 newdiceSpawnPos = player.transform.position;
        // newdiceSpawnPos += new Vector3(3.5f,8.5f,-3.5f);
        // diceSpawn.transform.position = newdiceSpawnPos;

        moveToPlayer(player);

    }

    public void moveToPlayer(GameObject playerObject){

        if (playerObject.transform.position.y < 0)
        {
            playerObject.transform.position = getStartPos();

        }

        if (playerObject.transform.position == new Vector3(-465,104,-2)){
            playerObject.transform.position = new Vector3(-465,1,0);
            Camera.main.transform.position = new Vector3(-517,47,2);
        }else{
            Vector3 newCamPos = playerObject.transform.position;
            newCamPos += new Vector3(5, 14.5f, -8.5f);
            Camera.main.transform.position = newCamPos;

        }
    }


    public void startNewRound(){

        finish.alpha = 0;
        Loader.Load(Loader.Scene.StartScene);

    }

    public Vector3 getStartPos()
    {
        map Map = new map();
        List<Movement> map = Map.getMap(GameSettings.getMapID());
        return map[0].getVector();

    }

        public void setRollable(){

        //Debug.Log(switchRollBool);

        // if(switchRollBool){
        //     switchRollBool = false;
        //     newDiceRoll.isRolled = false;
        //     newDiceRoll.canRoll = false;
        // }else{
        //     newDiceRoll.rolledNum = 0;
        //     switchRollBool = true;
        //     newDiceRoll.isRolled = true;
        //     newDiceRoll.canRoll = true;
        // }

        
    }

}

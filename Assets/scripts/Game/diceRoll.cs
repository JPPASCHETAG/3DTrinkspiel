using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class diceRoll : MonoBehaviour
{

    public TextMeshPro textMeshPro;
    public static TextMeshPro objTextMesh;

    public CanvasGroup aufgabe;
    public CanvasGroup finishCanvas;

    public static int Player1Pos = 0;
    public GameObject player1;
    public static GameObject objPlayer1;

    public static int Player2Pos = 0;
    public GameObject player2;
    public static GameObject objPlayer2;

    public static int Player3Pos = 0;
    public GameObject player3;
    public static GameObject objPlayer3;

    public static int Player4Pos = 0;
    public GameObject player4;
    public static GameObject objPlayer4;

    public Text objTitel;
    public Text objMessage;

    public static bool roll = true;
    
    private Vector3 startPos = new Vector3(-465,1,0);
    private int TotalPlayers;
    public static int currentPlayer;

   

    // Start is called before the first frame update
    void Start()
    {
        roll=true;

        TotalPlayers = GameSettings.getNumOfPlayer();
        currentPlayer = 1;

        objTextMesh = textMeshPro;

        objPlayer1 = player1;
        objPlayer2 = player2;
        objPlayer3 = player3;
        objPlayer4 = player4;

        Player1Pos = 0;
        Player2Pos = 0;
        Player3Pos = 0;
        Player4Pos = 0;

    }

    // Update is called once per frame
    void Update()
    {
        
        if(roll){
            int rnd = UnityEngine.Random.Range(1, 6);
            textMeshPro.text = rnd.ToString();
        }

    }

    void OnMouseDown() {
        
        if(roll){
            roll=false;
            
            int intRolled = Int32.Parse(textMeshPro.text);

            GameObject player = null;
            int PlayerPos = 0;
            int oldPos = 0;
            switch(currentPlayer){
                case 1:
                    player = player1;
                    oldPos = Player1Pos;
                    Player1Pos += intRolled;
                    PlayerPos = Player1Pos;
                    break;
                case 2:
                    player = player2;
                    oldPos = Player2Pos;
                    Player2Pos += intRolled;
                    PlayerPos = Player2Pos;
                    break;
                case 3:
                    player = player3;
                    oldPos = Player3Pos;
                    Player3Pos += intRolled;
                    PlayerPos = Player3Pos;
                    break;
                case 4:
                    player = player4;
                    oldPos = Player4Pos;
                    Player4Pos += intRolled;
                    PlayerPos = Player4Pos;
                    break;

            }

            map Map = new map();
            if (PlayerPos >= Map.getMap(GameSettings.getMapID()).Count)
            {
                //StartCoroutine (MoveOverSeconds (oldPos,PlayerPos,player));
                aufgabe.alpha = 0;
                aufgabe.blocksRaycasts = false;
                finishCanvas.alpha = 1;
            }else{
                StartCoroutine (MoveOverSeconds (oldPos,PlayerPos,player));
                StartCoroutine (MoveCameraOverSeconds (oldPos,PlayerPos));
            }

        }

    }

    IEnumerator MoveOverSeconds (int curPos,int nxtPos, GameObject player){


        if(curPos < nxtPos){

            Movement move = getPlayerMovement(curPos);

            curPos++; 
            float seconds = 0.5f;
            float elapsedTime = 0;
            Vector3 startingPos = player.transform.position;       

            while (elapsedTime < seconds)
            {
                player.transform.position = Vector3.Lerp(startingPos, move.getVector(), (elapsedTime / seconds));
                elapsedTime += Time.deltaTime;
                yield return new WaitForEndOfFrame();
            }
            player.transform.position = move.getVector();  

            if(move.getTurn()){
                //hier dann noch turnen wenn nötig
                player.transform.Rotate(0, move.getRotation(), 0);
            }
        
            StartCoroutine (MoveOverSeconds (curPos,nxtPos,player));
            if(curPos == nxtPos){
                yield return new WaitForSeconds(0.7f);
                nextPlayer();    
                showAufgabe();
            }   
        }

    }

    IEnumerator MoveCameraOverSeconds (int curPos,int nxtPos){

        if(curPos < nxtPos){
            Movement move = getPlayerMovement(curPos);
            curPos++;

            Vector3 end = move.getVector();
            //Vector3 offset = new Vector3(-52,47,0); test Map

            //MAp 2
            Vector3 offset = new Vector3(5,14.5f ,-8.5f);
            end = end+offset;
            float seconds = 0.5f;
            float elapsedTime = 0;
            Vector3 startingPos = Camera.main.transform.position;
            while (elapsedTime < seconds)
            {
                Camera.main.transform.position = Vector3.Lerp(startingPos, end, (elapsedTime / seconds));
                elapsedTime += Time.deltaTime;
                yield return new WaitForEndOfFrame();
            }
            Camera.main.transform.position = end;
            StartCoroutine (MoveCameraOverSeconds (curPos,nxtPos));
        }
        
    }

    void nextPlayer(){
        if(currentPlayer < TotalPlayers){
            currentPlayer++;
        }else{
            currentPlayer = 1;
        }
    }

    void showAufgabe(){
        
        Aufgabe aufgaben = new AufgabenGenerator().getRandomAufgabe();
        //Titel und Message setzen
        objTitel.text = aufgaben.getTitel();
        objMessage.text = aufgaben.getMessage();


        //am Schluss das Canvas zeigen
        aufgabe.alpha = 1;


    }

    Movement getPlayerMovement(int field){

        Movement returnMovement;

        //MapID holen
        
        map Map = new map();
        List<Movement> map = Map.getMap(GameSettings.getMapID());

        if (field >= map.Count){
            returnMovement = map[map.Count-1];
        }else{
            returnMovement = map[field];
        }
        
        

        return returnMovement;
    }

}

public class Movement{

    ////////////////////
    private int steps;
    private int richtung;
    ////////////////////


    private GameObject player;
    private Vector3 nextPos;
    private bool turn;
    private int turnDir;


    public Movement(bool bolturn,int turnDirection,Vector3 pos){
        turn = bolturn;
        turnDir = turnDirection;
        nextPos = pos;
    }

    public void setObjekt(GameObject obj){
        player = obj;
    }

    public void setNextPos(Vector3 pos){
        nextPos = pos;
    }

    public Movement(int schritte, int way){
        steps = schritte;
        richtung = way;
    }

    public int getSteps(){
        return steps;
    }

    public int getRichtung(){
        return richtung;
    }

    public GameObject getObj(){
        return player;
    }

    public Vector3 getVector(){
        return nextPos;
    }

    public bool getTurn(){
        return turn;
    }

    public int getRotation(){
        return turnDir;
    }
}
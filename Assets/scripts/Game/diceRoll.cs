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

    public static int Player1Pos = 1;
    public GameObject player1;
    public static GameObject objPlayer1;

    public static int Player2Pos = 1;
    public GameObject player2;
    public static GameObject objPlayer2;

    public static int Player3Pos = 1;
    public GameObject player3;
    public static GameObject objPlayer3;

    public static int Player4Pos = 1;
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
        Debug.Log(GameSettings.getNumOfPlayer());
        TotalPlayers = GameSettings.getNumOfPlayer();
        currentPlayer = 1;

        objTextMesh = textMeshPro;

        objPlayer1 = player1;
        objPlayer2 = player2;
        objPlayer3 = player3;
        objPlayer4 = player4;

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
            switch(currentPlayer){
                case 1:
                    player = player1;
                    Player1Pos += intRolled;
                    PlayerPos = Player1Pos;
                    break;
                case 2:
                    player = player2;
                    Player2Pos += intRolled;
                    PlayerPos = Player2Pos;
                    break;
                case 3:
                    player = player3;
                    Player3Pos += intRolled;
                    PlayerPos = Player3Pos;
                    break;
                case 4:
                    player = player4;
                    Player4Pos += intRolled;
                    PlayerPos = Player4Pos;
                    break;

            }

            //Camera und Player Movement
            //aktuelle Position

            Vector3 nextPos = player.transform.position;
            Vector3 CameraPos = Camera.main.transform.position;

            List<Movement> nextTurn = getPlayerMovement(PlayerPos,intRolled);


            for(int j=0;j<nextTurn.Count;j++){
                
                Movement move = nextTurn[j];
                move.setObjekt(player);

                int richtung = move.getRichtung();
                int schritte = move.getSteps();

                switch(richtung){
                    //z positiv
                    case 1:
                        for(int i=0;i<schritte;i++){        
                            nextPos += new Vector3(0, 0, 5.1f);
                            CameraPos += new Vector3(0, 0, 5.1f);
                        }
                        break;
                    //x positiv
                    case 2:
                        for(int i=0;i<schritte;i++){        
                            nextPos += new Vector3(-4.3f, 0, 0);
                            CameraPos += new Vector3(-4.3f, 0, 0);
                        }
                        break;
                    //z negativ
                    case 3:
                        for(int i=0;i<schritte;i++){        
                            nextPos += new Vector3(0, 0, -5);
                            CameraPos += new Vector3(0, 0, -5);
                        }
                        break;
                    //x positiv
                    case 4:
                        for(int i=0;i<schritte;i++){        
                            nextPos += new Vector3(5, 0, 0);
                            CameraPos += new Vector3(5, 0, 0);
                        }
                        break;
                }

                move.setNextPos(nextPos);

            }

            StartCoroutine (MoveOverSeconds (nextTurn,PlayerPos,intRolled));
            StartCoroutine (MoveCameraOverSeconds (CameraPos , 1.5f));
                    

        }

    }

    public IEnumerator MoveOverSeconds (List<Movement> liste, int nextPos,int rolled){

        int curPos = nextPos-rolled;

        for(int j=0;j<liste.Count;j++){
            Movement move = liste[j];
            float seconds = 1.5f;
            float elapsedTime = 0;
            Vector3 startingPos = move.getObj().transform.position;
            

            if(curPos < 9 && nextPos >= 9 && nextPos < 12){
                if(move.getRichtung() == 2){
                    move.getObj().transform.Rotate(0, -90.0f, 0, Space.Self);
                }
            }

            if(curPos < 12 && nextPos >= 12 && nextPos < 20){
                if(move.getRichtung() == 3){
                    move.getObj().transform.Rotate(0, -90, 0, Space.Self);
                }    
            }
            
            if(curPos < 20 && nextPos >= 20 && nextPos < 23){
                if(move.getRichtung() == 4){
                    move.getObj().transform.Rotate(0, -90, 0, Space.Self);
                }
            }

            

            while (elapsedTime < seconds)
            {
                move.getObj().transform.position = Vector3.Lerp(startingPos, move.getVector(), (elapsedTime / seconds));
                elapsedTime += Time.deltaTime;
                yield return new WaitForEndOfFrame();
            }
            move.getObj().transform.position = move.getVector();
        }
    }

    public IEnumerator MoveCameraOverSeconds (Vector3 end, float seconds){
        float elapsedTime = 0;
        Vector3 startingPos = Camera.main.transform.position;
        while (elapsedTime < seconds)
        {
            Camera.main.transform.position = Vector3.Lerp(startingPos, end, (elapsedTime / seconds));
            elapsedTime += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
        Camera.main.transform.position = end;

        nextPlayer();
        
        showAufgabe();
        
    }

    public void nextPlayer(){
        if(currentPlayer < TotalPlayers){
            currentPlayer++;
        }else{
            currentPlayer = 1;
        }
    }

    public void showAufgabe(){
        
        Aufgabe aufgaben = new AufgabenGenerator().getRandomAufgabe();
        //Titel und Message setzen
        objTitel.text = aufgaben.getTitel();
        objMessage.text = aufgaben.getMessage();


        //am Schluss das Canvas zeigen
        aufgabe.alpha = 1;


    }

    public List<Movement> getPlayerMovement(int nextPos, int rolled){

        List<Movement> returnList = new List<Movement>();

        int curPos = nextPos-rolled;

        while(rolled > 0){

            if(nextPos <9){

                returnList.Add(new Movement(rolled, 1));
                rolled = 0;

            }else if(nextPos >= 9 && curPos < 9){

                int stepsToTurn = 9-curPos;

                returnList.Add(new Movement(stepsToTurn, 1));

                rolled = rolled-stepsToTurn;
                curPos = curPos+stepsToTurn;

            }else if(nextPos > 9 && nextPos < 12 ){

                returnList.Add(new Movement(rolled, 2));
                rolled = 0;

            }else if(nextPos >= 12 && curPos < 12){

                int stepsToTurn = 12-curPos;

                returnList.Add(new Movement(stepsToTurn, 2));

                rolled = rolled-stepsToTurn;
                curPos = curPos+stepsToTurn;

            }else if(nextPos >= 13 && nextPos < 20){

                returnList.Add(new Movement(rolled, 3));
                rolled = 0;

            }else if(nextPos >= 20 && curPos < 20){
                 int stepsToTurn = 20-curPos;

                returnList.Add(new Movement(stepsToTurn, 3));

                rolled = rolled-stepsToTurn;
                curPos = curPos+stepsToTurn;
            }else if(nextPos > 20 && nextPos < 22){

                returnList.Add(new Movement(rolled, 4));
                rolled = 0;

            }else if(nextPos >= 22){
                rolled=0;
                Movement mv = new Movement(0, 4);
                mv.setNextPos(new Vector3(-465,1,0));
                returnList.Add(mv);
            }

        }


        return returnList;
    }

}








public class Movement{

    private int steps;
    private int richtung;
    private GameObject player;
    private Vector3 nextPos;

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

}



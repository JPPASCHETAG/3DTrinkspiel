using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ThrowDice : MonoBehaviour
{
    ///////// Parameter für MoveDice() //////////////
    public Transform cube;
    private Vector2 fingerDown;
    private Vector2 fingerUp;
    public GameObject die;
    private float SWIPE_THRESHOLD = 400f;
    public static bool isRolled = false;
    public static int value = 0;
    public static bool diceShown = false;
    public Image img;
    /////////////////////////////////////////////////

    ///////// Parameter für doRoll() //////////////
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

    //public Text PlayerTag1;
    public TextMeshProUGUI PlayerTag1; 
    public TextMeshProUGUI PlayerTag2; 
    public TextMeshProUGUI PlayerTag3; 
    public TextMeshProUGUI PlayerTag4; 

    public GameObject spawnpoint;

    public static int rolledNum = 0;
    public static bool canRoll = true;
    /////////////////////////////////////////////////
    
    // Start is called before the first frame update
    void Start()
    {

        PlayerTag1.text = GameSettings.getPlayer1name();
        PlayerTag2.text = GameSettings.getPlayer2name();
        PlayerTag3.text = GameSettings.getPlayer3name();
        PlayerTag4.text = GameSettings.getPlayer4name();

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
        if(diceShown){
            //Würfel drehen und bei swipe up werfen
            MoveDice();
            //Wert des Würfels holen
            getDiceVal();
        }


    }

    private void MoveDice(){
        if(!isRolled){

            if (Input.touchCount == 1)
            {
                // GET TOUCH 0
                Touch touch = Input.GetTouch(0);
                // APPLY ROTATION
                if (touch.phase == TouchPhase.Moved)
                {
                    cube.transform.Rotate(0f, touch.deltaPosition.x, 0f);
                    cube.transform.Rotate(touch.deltaPosition.y, 0f, 0f);
                }

                //Detects Swipe while finger is still moving
                if (touch.phase == TouchPhase.Moved)
                {
                    fingerDown = touch.position;
                    checkSwipe();
                }
            }
        }
    }

    /*
     * Prüft ob nach oben geswiped wurde
    */
    void checkSwipe()
    {
        //Check if Vertical swipe
        if (verticalMove() > SWIPE_THRESHOLD && verticalMove() > horizontalValMove())
        {
            if (fingerDown.y - fingerUp.y > 0)//up swipe
            {
                if(!isRolled){
                    onSwipeUp();
                }
            }
            fingerUp = fingerDown;
        }
    }

    public void onSwipeUp(){
                
        die.GetComponent<Rigidbody>().isKinematic = false;
        isRolled = true;
        die.GetComponent<Rigidbody>().useGravity = true;
        // apply the force impuls
        die.GetComponent<Rigidbody>().AddForce(new Vector3(0,10,10), ForceMode.Impulse);
        // apply a random torque
        die.GetComponent<Rigidbody>().AddTorque(new Vector3(-50 * Random.value * die.transform.localScale.magnitude, -50 * Random.value * die.transform.localScale.magnitude, -50 * Random.value * die.transform.localScale.magnitude), ForceMode.Impulse);
    }

    //Hilfsfunktionen für checkswipe
    private Vector3 Force(GameObject spawnpoint)
    {
        Vector3 rollTarget = Vector3.zero + new Vector3(2 + 7 * Random.value, .5F + 4 * Random.value, -2 - 60 * Random.value);
        return Vector3.Lerp(spawnpoint.transform.position, rollTarget, 1).normalized * (-35 - Random.value * 20);
    }
    float verticalMove()
    {
        return Mathf.Abs(fingerDown.y - fingerUp.y);
    }
    float horizontalValMove()
    {
        return Mathf.Abs(fingerDown.x - fingerUp.x);
    }

    private void getDiceVal(){

        if(isRolled && value == 0 && die.GetComponent<Rigidbody>().IsSleeping()){

            float rotX = (int)cube.rotation.eulerAngles.x;
            float rotY = (int)cube.rotation.eulerAngles.z;
            
            //5
            if(((rotX >= 315 && rotX <=360) || (rotX >= 0 && rotX <=45)) && ((rotY >= 315 && rotY <=360) || (rotY >= 0 && rotY <=45))){
               value = 5;
            }
            if((rotX >= 135 && rotX <=225) && (rotY >= 135 && rotY <= 225)){
                value = 5;
            }
            //4
            if(((rotX >= 315 && rotX <=360) || (rotX >= 0 && rotX <=45)) && (rotY >= 45 && rotY <= 135)){
               value = 4;
            }
            if((rotX >= 135 && rotX <=225) && (rotY >= 225 && rotY <= 315)){
                value = 4;
            }
            //2
            if(((rotX >= 315 && rotX <=360) || (rotX >= 0 && rotX <=45)) && (rotY >= 135 && rotY <= 225)){
               value = 2;
            }
            if((rotX >= 135 && rotX <=225) && ((rotY >= 315 && rotY <=360) || (rotY >= 0 && rotY <=45))){
                value = 2;
            }
            //3
            if(((rotX >= 315 && rotX <=360) || (rotX >= 0 && rotX <=45)) && (rotY >= 225 && rotY <= 315)){
                value = 3;
            }
            if((rotX >= 135 && rotX <=225) && (rotY >= 45 && rotY <= 135)){
                value = 3;
            }
            //6
            if((rotX >= 45 && rotX <=135) && ((rotY >= 315 && rotY <=360) || (rotY >= 0 && rotY <=45))){
                value = 6;
            }
            if((rotX >= 45 && rotX <=135) && (rotY >= 45 && rotY <= 135)){
                value = 6;
            }
            if((rotX >= 45 && rotX <=135) && (rotY >= 135 && rotY <= 225)){
                value = 6;
            }
            if((rotX >= 45 && rotX <=135) && (rotY >= 225 && rotY <= 315)){
                value = 6;
            }
            //1
            if((rotX >= 225 && rotX <=315) && ((rotY >= 315 && rotY <=360) || (rotY >= 0 && rotY <=45))){
                value = 1;
            }
            if((rotX >= 225 && rotX <=315) && (rotY >= 45 && rotY <= 135)){
                value = 1;
            }
            if((rotX >= 225 && rotX <=315) && (rotY >= 135 && rotY <= 225)){
                value = 1;
            }
            if((rotX >= 225 && rotX <=315) && (rotY >= 225 && rotY <= 315)){
                value = 1;
            }
            if(value != 0){
                Debug.Log("gewürfelt: " + value);
                //hier wird dann das zeug gemacht 
                doRoll(value);
            }
        }
    }


    void doRoll(int intRolled) {
        
        if(roll){
            Debug.Log("doRoll erste if");
            roll=false;

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
                Debug.Log("Start Coroutins");
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

        //Ganz am Ende das hier
        value = 0;
        diceShown = false;
        img.enabled = true;
        isRolled = false;
        die.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;


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

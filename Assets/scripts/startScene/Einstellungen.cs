using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Einstellungen : MonoBehaviour
{

    Camera m_MainCamera;
    public TextMeshPro textMeshPro;
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;

    // Start is called before the first frame update
    void Start()
    {
        m_MainCamera = Camera.main;
        
    }

    void OnMouseDown(){


        string text = textMeshPro.text;
        int playerNumber = Int32.Parse(text);
        Debug.Log(text);
        
        player1.transform.position = new Vector3(-18.66f,1,-28.007f);

        if(playerNumber >= 2){
            player2.transform.position = new Vector3(-16.17f,1,-27.77f);
        }
        if(playerNumber >= 3){
            player3.transform.position = new Vector3(-13.05f,1,-27.77f);
        }
        if(playerNumber >= 4){
            player4.transform.position = new Vector3(-10.3f,1,-27.77f);
        }
               
        moveCamera();

    }

    void moveCamera(){

        Vector3 moveToPosition = new Vector3 (-14.4f,3,-33.6f); // This is where the camera will move after the start
        float speed = 1f;

        StartCoroutine (MoveOverSeconds (m_MainCamera, moveToPosition, 1.5f));
        //m_MainCamera.transform.position = Vector3.Lerp(transform.position, moveToPosition, speed);


    }

    public IEnumerator MoveOverSeconds (Camera objectToMove, Vector3 end, float seconds){
        float elapsedTime = 0;
        Vector3 startingPos = objectToMove.transform.position;
        while (elapsedTime < seconds)
        {
            objectToMove.transform.position = Vector3.Lerp(startingPos, end, (elapsedTime / seconds));
            elapsedTime += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
        objectToMove.transform.position = end;
    }
}

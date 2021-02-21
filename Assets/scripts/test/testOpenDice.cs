using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testOpenDice : MonoBehaviour
{
    public Image img;
    public GameObject dice;

    public void OnDiceClick(){

        //Canvas verstecken
        img.enabled = false;
        dice.GetComponent<Rigidbody>().useGravity = false;
        dice.GetComponent<Rigidbody>().isKinematic = true;
        dice.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        Vector3 pos  = Camera.main.transform.position;
        pos += new Vector3(0,-2,2);
        dice.transform.position = pos;
        ThrowDice.diceShown = true;

    }
}

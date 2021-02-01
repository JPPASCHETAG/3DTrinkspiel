using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blalosfdji : MonoBehaviour
{
    public GameObject spawnpoint;

    public static int rolledNum = 0;
    private bool isRolled = true;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            RollDice();
        }

        if(rolledNum != 0 && isRolled){
            isRolled = false;
            Debug.Log(rolledNum);
        }
        
    }

    private Vector3 Force()
    {
        Vector3 rollTarget = Vector3.zero + new Vector3(2 + 7 * Random.value, .5F + 4 * Random.value, -2 - 60 * Random.value);
        return Vector3.Lerp(spawnpoint.transform.position, rollTarget, 1).normalized * (-35 - Random.value * 20);
    }

    void RollDice()
    {
        Dice.Roll("1d6", "d6-black", spawnpoint.transform.position, Force());
    }

}

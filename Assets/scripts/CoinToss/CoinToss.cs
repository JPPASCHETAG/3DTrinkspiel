using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinToss : MonoBehaviour
{

    private bool isTossed;
    public Rigidbody rb;

    Vector3 oldEulerAngles;

    // Start is called before the first frame update
    void Start()
    {
        isTossed = false;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (rb.angularVelocity == new Vector3(0,0,0)){
            if(isTossed){
                isTossed = false;
                Debug.Log("Kopf oder Zahl");
            }
        }

        if(Input.GetMouseButtonDown(0)){            
            rb.AddTorque(0,20,0,ForceMode.Force);
            StartCoroutine(stopCoin());    
        }
    }

    IEnumerator stopCoin(){
        isTossed = true;
        yield return new WaitForSeconds(2);
        rb.angularDrag = 0.5f;
    }
}

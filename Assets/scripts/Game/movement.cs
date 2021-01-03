using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    private bool moved = false;

    void Start()
    {

    }
    
    private void Update()
    {
        //Debug.Log(transform.position);
        
        if(!moved){
            
            moved = true;
        }
    
    }
    
    void OnMouseDown()
    {
        Debug.Log("click");
        transform.position += new Vector3(0, 0, 5);
    }
}

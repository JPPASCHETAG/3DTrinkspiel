using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objektZiehen : MonoBehaviour
{

    private Touch touch;
    private Vector3 previousTouchPosition;
     private Vector3 currentTouchPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.touchCount > 0){
            touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Moved){

                // Get current touch position       
                currentTouchPosition = Input.GetTouch(0).deltaPosition;
 
                // Get distance between current touch position and previous one.
                float distance = currentTouchPosition.x - previousTouchPosition.x;

                Vector3 destination = transform.position + new Vector3(distance, 0.0F, 0.0F);
                destination.x = Mathf.Clamp( destination.x, -2, 2 ) ;
                transform.position = Vector3.Lerp(transform.position, destination, Time.deltaTime);
            }
        }
    }
}

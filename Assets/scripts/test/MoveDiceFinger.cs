using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDiceFinger : MonoBehaviour
{

    public Transform cube;
    private Vector2 fingerDown;
    private Vector2 fingerUp;
    public GameObject die;
    public float SWIPE_THRESHOLD = 1000000000000f;
    public static bool isRolled = false;

    void Update()
    {
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

                // Ad torque
                //Detects Swipe while finger is still moving
                if (touch.phase == TouchPhase.Moved)
                {
                    fingerDown = touch.position;
                    checkSwipe();
                }
            }
        }
    }
    
    void checkSwipe()
    {
        //Check if Vertical swipe
        if (verticalMove() > SWIPE_THRESHOLD && verticalMove() > horizontalValMove())
        {
            //Debug.Log("Vertical");
            if (fingerDown.y - fingerUp.y > 0)//up swipe
            {
                if(!isRolled){
                    isRolled = true;
                    Debug.Log("swipe");
                    die.GetComponent<Rigidbody>().useGravity = true;
                    // apply the force impuls
                    die.GetComponent<Rigidbody>().AddForce(new Vector3(0,20,10), ForceMode.Impulse);
                    // apply a random torque
                    die.GetComponent<Rigidbody>().AddTorque(new Vector3(-50 * Random.value * die.transform.localScale.magnitude, -50 * Random.value * die.transform.localScale.magnitude, -50 * Random.value * die.transform.localScale.magnitude), ForceMode.Impulse);

                }
                
            }
            else if (fingerDown.y - fingerUp.y < 0)//Down swipe
            {
                //OnSwipeDown();
            }
            fingerUp = fingerDown;
        }

        // //Check if Horizontal swipe
        // else if (horizontalValMove() > SWIPE_THRESHOLD && horizontalValMove() > verticalMove())
        // {
        //     //Debug.Log("Horizontal");
        //     if (fingerDown.x - fingerUp.x > 0)//Right swipe
        //     {
        //         //OnSwipeRight();
        //     }
        //     else if (fingerDown.x - fingerUp.x < 0)//Left swipe
        //     {
        //         //OnSwipeLeft();
        //     }
        //     fingerUp = fingerDown;
        // }

        // //No Movement at-all
        // else
        // {
        //     //Debug.Log("No Swipe!");
        // }
    }

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

    void OnSwipeUp()
    {
        Debug.Log("Swipe UP");
    }

    void OnSwipeDown()
    {
        Debug.Log("Swipe Down");
    }

    void OnSwipeLeft()
    {
        Debug.Log("Swipe Left");
    }

    void OnSwipeRight()
    {
        Debug.Log("Swipe Right");
    }
}

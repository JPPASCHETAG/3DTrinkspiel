using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wurf : MonoBehaviour
{
    
    Rigidbody rb;
    Transform tr;
    Vector3 initPos;

	bool rolling = true;
	[Range(-1.0f, 1.0f)]
	public float xForceDirection = 0.0f;
	[Range(-1.0f, 1.0f)]
	public float yForceDirection = 0.0f;
	[Range(-1.0f, 1.0f)]
	public float zForceDirection = 0.0f;

	public float speedMultiplier = 1;

	public bool worldPivote = false;
	private Space spacePivot = Space.Self;

	private int[] face6 = {
        0,
        0,
        -90
    };

    private int[] face5 = {
        -90,
        -90,
        90
    };

    private int[] face4 = {
        90,
        0,
        -90
    };

    private int[] face3 = {
        90,
        0,
        90
    };

    private int[] face2 = {
        0,
        90,
        90
    };

    private int[] face1 = {
        0,
        180,
        0
    };

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        tr = GetComponent<Transform>();
        initPos = transform.position;
        rb.useGravity = false;
    }

    void Update() {

        if(Input.GetKeyDown(KeyCode.Space)){
            rolling = true;
        }

        if(rolling){
            RollDice();
        }
        
        if(Input.GetKeyDown(KeyCode.Escape)){
            rolling = false;
            setFace();       
        }

    }

    void RollDice(){

		int angle = Random.Range(0, 10);

		tr.Rotate(angle * speedMultiplier
							, angle * speedMultiplier
							, angle * speedMultiplier
							, spacePivot);




	}

    void setFace(){

        int face = Random.Range(1,7);

        Debug.Log(face);
        switch(face){
            case 1:
                tr.rotation  = Quaternion.Euler(face1[0],face1[1],face1[2]);
                break;
            case 2:
                tr.rotation  = Quaternion.Euler(face2[0],face2[1],face2[2]);
                break;
            case 3:
                tr.rotation  = Quaternion.Euler(face3[0],face3[1],face3[2]);
                break;
            case 4:
                tr.rotation  = Quaternion.Euler(face4[0],face4[1],face4[2]);
                break;
            case 5:
                tr.rotation  = Quaternion.Euler(face5[0],face5[1],face5[2]);
                break;
            case 6:
                tr.rotation  = Quaternion.Euler(face6[0],face6[1],face6[2]);
                break;
            default: 
                Debug.Log("Fehler bei "+ face);
                break;
        }

    }

    void FixedUpdate()
    {
        //rb.angularVelocity = Random.insideUnitSphere * tumble;
    }
}

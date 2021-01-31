using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard_Playertag : MonoBehaviour
{

    private Transform mainCamTransform;

    // Start is called before the first frame update
    private void Start()
    {
        mainCamTransform = Camera.main.transform;
    }

    private void LateUpdate() {
        transform.LookAt(transform.position + mainCamTransform.rotation * Vector3.forward,
            mainCamTransform.rotation * Vector3.up);
    }


}

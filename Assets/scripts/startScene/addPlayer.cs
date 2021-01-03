using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class addPlayer : MonoBehaviour
{

    public TextMeshPro textMeshPro;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {

        string text = textMeshPro.text;
        int result = Int32.Parse(text);

        if(result < 4){
            result++;
        }else{
            result=1;
        }
        
        textMeshPro.text = result.ToString();

    }
}

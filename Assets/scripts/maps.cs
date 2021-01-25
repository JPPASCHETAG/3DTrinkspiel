using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class map{

    public List<Movement> map1 = new List<Movement>();
    public List<Movement> map2 = new List<Movement>();

    public map(){

        //Map1
        map1.Add(new Movement(false,0, new Vector3(-465,1,5)));
        map1.Add(new Movement(false,0, new Vector3(-465,1,10.2f)));
        map1.Add(new Movement(false,0, new Vector3(-465,1,15.4f)));
        map1.Add(new Movement(false,0, new Vector3(-465,1,20.6f)));
        map1.Add(new Movement(false,0, new Vector3(-465,1,25.8f)));
        map1.Add(new Movement(false,0, new Vector3(-465,1,31)));
        map1.Add(new Movement(false,0, new Vector3(-465,1,36.2f)));
        map1.Add(new Movement(true,-90, new Vector3(-465,1,41.4f)));
        map1.Add(new Movement(false,0, new Vector3(-465,1,41.4f)));
        map1.Add(new Movement(false,0, new Vector3(-471,1,41.4f)));
        map1.Add(new Movement(true,-90, new Vector3(-477,1,41.4f)));
        map1.Add(new Movement(false,0, new Vector3(-477,1,36.2f)));
        map1.Add(new Movement(false,0, new Vector3(-477,1,31)));
        map1.Add(new Movement(false,0, new Vector3(-477,1,25.8f)));
        map1.Add(new Movement(false,0, new Vector3(-477,1,20.6f)));
        map1.Add(new Movement(false,0, new Vector3(-477,1,15.4f)));
        map1.Add(new Movement(false,0, new Vector3(-477,1,10.2f)));
        map1.Add(new Movement(false,0, new Vector3(-477,1,5)));
        map1.Add(new Movement(true,-90, new Vector3(-477,1,0)));
        map1.Add(new Movement(false,0, new Vector3(-471,1,0)));
        map1.Add(new Movement(true,-90, new Vector3(-465,1,0)));


        //weitere maps anlegen

    }

}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class map{

    public List<Movement> map1 = new List<Movement>();
    public List<Movement> map2 = new List<Movement>();
    public List<Movement> map3 = new List<Movement>();

    public List<Movement> getMap(int id)
	{
		switch (id)
		{
            case 1:
                return map1;
            case 2:
                return map2;
            case 3:
                return map3;
            default:
                return map2;
		}
	}

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

        map2.Add(new Movement(false, 0, new Vector3(-19, 0.5f, -22.5f)));
        map2.Add(new Movement(false, 0, new Vector3(-12, 0.5f, -22.5f)));
        map2.Add(new Movement(false, 0, new Vector3(-5, 0.5f, -22.5f)));
        map2.Add(new Movement(false, 0, new Vector3(1, 0.5f, -22.5f)));
        map2.Add(new Movement(true, -90, new Vector3(7, 0.5f, -22.5f)));
        map2.Add(new Movement(false, 0, new Vector3(7, 0.5f, -19)));
        map2.Add(new Movement(true, -90, new Vector3(7, 0.5f, -13.5f)));
        map2.Add(new Movement(false, 0, new Vector3(2, 0.5f, -13.5f)));
        map2.Add(new Movement(false, 0, new Vector3(-3, 0.5f, -13.5f)));
        map2.Add(new Movement(false, 0, new Vector3(-8, 0.5f, -13.5f)));
        map2.Add(new Movement(false, 0, new Vector3(-13, 0.5f, -13.5f)));
        map2.Add(new Movement(false, 0, new Vector3(-18, 0.5f, -13.5f)));
        map2.Add(new Movement(true, 90, new Vector3(-23, 0.5f, -13.5f)));
        map2.Add(new Movement(false, 0, new Vector3(-23, 0.5f, -9)));
        map2.Add(new Movement(false, 0, new Vector3(-23, 0.5f, -4.5f)));
        map2.Add(new Movement(false, 0, new Vector3(-23, 0.5f, 0)));
        map2.Add(new Movement(false, 0, new Vector3(-23, 0.5f, 4.5f)));
        map2.Add(new Movement(false, 0, new Vector3(-23, 0.5f, 9)));
        map2.Add(new Movement(false, 0, new Vector3(-23, 0.5f, 13.5f)));
        map2.Add(new Movement(true, 90, new Vector3(-23, 0.5f, 18)));
        map2.Add(new Movement(false, 0, new Vector3(-19, 0.5f, 18)));
        map2.Add(new Movement(false, 0, new Vector3(-15, 0.5f, 18)));
        map2.Add(new Movement(true, -90, new Vector3(-11, 0.5f, 18)));
        map2.Add(new Movement(false, 0, new Vector3(-11, 0.5f, 20)));
        map2.Add(new Movement(true, 90, new Vector3(-11, 0.5f, 23)));
        map2.Add(new Movement(false, 0, new Vector3(-7, 0.5f, 23)));
        map2.Add(new Movement(false, 0, new Vector3(-3, 0.5f, 23)));
        map2.Add(new Movement(false, 0, new Vector3(1, 0.5f, 23)));
        map2.Add(new Movement(false, 0, new Vector3(5, 0.5f, 23)));
        map2.Add(new Movement(false, 0, new Vector3(9, 0.5f, 23)));
        map2.Add(new Movement(false, 0, new Vector3(13, 0.5f, 23)));
        map2.Add(new Movement(true, 90, new Vector3(17, 0.5f, 23)));
        map2.Add(new Movement(false, 0, new Vector3(17, 0.5f, 19)));
        map2.Add(new Movement(false, 0, new Vector3(17, 0.5f, 14)));
        map2.Add(new Movement(true, 90, new Vector3(17, 0.5f, 9)));
        map2.Add(new Movement(false, 0, new Vector3(12, 0.5f, 9)));
        map2.Add(new Movement(true, 90, new Vector3(7, 0.5f, 9)));
        map2.Add(new Movement(true, -90, new Vector3(7, 0.5f, 15)));
        map2.Add(new Movement(false, 0, new Vector3(0.5f, 0.5f, 15)));
        map2.Add(new Movement(true, -90, new Vector3(-6, 0.5f, 15)));
        map2.Add(new Movement(true, 90, new Vector3(-6, 0.5f, 9)));
        map2.Add(new Movement(false, 0, new Vector3(-10, 0.5f, 9)));
        map2.Add(new Movement(true, -90, new Vector3(-15, 0.5f, 9)));
        map2.Add(new Movement(false, 0, new Vector3(-15, 0.5f, 3.5f)));
        map2.Add(new Movement(false, 0, new Vector3(-15, 0.5f, -2)));
        map2.Add(new Movement(true, -90, new Vector3(-15, 0.5f, -8)));
        map2.Add(new Movement(false, 0, new Vector3(-10, 0.5f, -8)));
        map2.Add(new Movement(false, 0, new Vector3(-5, 0.5f, -8)));
        map2.Add(new Movement(true, -90, new Vector3(-1, 0.5f, -8)));
        map2.Add(new Movement(false, 0, new Vector3(-1, 0.5f, -2)));
        map2.Add(new Movement(true, 90, new Vector3(-1, 0.5f, 3)));
        map2.Add(new Movement(false, 0, new Vector3(3.5f, 0.5f, 3)));
        map2.Add(new Movement(false, 0, new Vector3(8, 0.5f, 3)));
        map2.Add(new Movement(true, 90, new Vector3(13, 0.5f, 3)));
        map2.Add(new Movement(false, 0, new Vector3(13, 0.5f, -1.5f)));
        map2.Add(new Movement(false, 0, new Vector3(13, 0.5f, -6)));
        map2.Add(new Movement(false, 0, new Vector3(13, 0.5f, -10.5f)));
        map2.Add(new Movement(false, 0, new Vector3(13, 0.5f, -15)));
        map2.Add(new Movement(true, -90, new Vector3(13, 0.5f, -20)));
        map2.Add(new Movement(false, 0, new Vector3(18, 0.5f, -20)));
        map2.Add(new Movement(true, -90, new Vector3(22, 0.5f, -20)));
        map2.Add(new Movement(false, 0, new Vector3(22, 0.5f, -15)));
        map2.Add(new Movement(false, 0, new Vector3(22, 0.5f, -10)));
        map2.Add(new Movement(false, 0, new Vector3(22, 0.5f, -5)));
        map2.Add(new Movement(false, 0, new Vector3(22, 0.5f, 0)));
        map2.Add(new Movement(false, 0, new Vector3(22, 0.5f, 5)));
        map2.Add(new Movement(false, 0, new Vector3(22, 0.5f, 10)));
        map2.Add(new Movement(false, 0, new Vector3(22, 0.5f, 15)));
        map2.Add(new Movement(false, 0, new Vector3(22, 0.5f, 20)));


        //Map3
        map3.Add(new Movement(false, 0, new Vector3(-19, 0.5f, -22.5f)));
        map3.Add(new Movement(false, 0, new Vector3(-12, 0.5f, -22.5f)));
        map3.Add(new Movement(false, 0, new Vector3(-5, 0.5f, -22.5f)));
        map3.Add(new Movement(false, 0, new Vector3(1, 0.5f, -22.5f)));
        map3.Add(new Movement(true, -90, new Vector3(7, 0.5f, -22.5f)));
        map3.Add(new Movement(false, 0, new Vector3(7, 0.5f, -19)));
        map3.Add(new Movement(true, -90, new Vector3(7, 0.5f, -13.5f)));
        map3.Add(new Movement(false, 0, new Vector3(2, 0.5f, -13.5f)));
        map3.Add(new Movement(false, 0, new Vector3(-3, 0.5f, -13.5f)));
        map3.Add(new Movement(false, 0, new Vector3(-8, 0.5f, -13.5f)));
        map3.Add(new Movement(false, 0, new Vector3(-13, 0.5f, -13.5f)));
        map3.Add(new Movement(false, 0, new Vector3(-18, 0.5f, -13.5f)));
        map3.Add(new Movement(true, 90, new Vector3(-23, 0.5f, -13.5f)));
        map3.Add(new Movement(false, 0, new Vector3(-23, 0.5f, -9)));
        map3.Add(new Movement(false, 0, new Vector3(-23, 0.5f, -4.5f)));
        map3.Add(new Movement(false, 0, new Vector3(-23, 0.5f, 0)));
        map3.Add(new Movement(false, 0, new Vector3(-23, 0.5f, 4.5f)));
        map3.Add(new Movement(false, 0, new Vector3(-23, 0.5f, 9)));
        map3.Add(new Movement(false, 0, new Vector3(-23, 0.5f, 13.5f)));
        map3.Add(new Movement(true, 90, new Vector3(-23, 0.5f, 18)));
        map3.Add(new Movement(false, 0, new Vector3(-19, 0.5f, 18)));
        map3.Add(new Movement(false, 0, new Vector3(-15, 0.5f, 18)));
        map3.Add(new Movement(true, -90, new Vector3(-11, 0.5f, 18)));
        map3.Add(new Movement(false, 0, new Vector3(-11, 0.5f, 20)));
        map3.Add(new Movement(true, 90, new Vector3(-11, 0.5f, 23)));
        map3.Add(new Movement(false, 0, new Vector3(-7, 0.5f, 23)));
        map3.Add(new Movement(false, 0, new Vector3(-3, 0.5f, 23)));
        map3.Add(new Movement(false, 0, new Vector3(1, 0.5f, 23)));
        map3.Add(new Movement(false, 0, new Vector3(5, 0.5f, 23)));
        map3.Add(new Movement(false, 0, new Vector3(9, 0.5f, 23)));
        map3.Add(new Movement(false, 0, new Vector3(13, 0.5f, 23)));
        map3.Add(new Movement(true, 90, new Vector3(17, 0.5f, 23)));
        map3.Add(new Movement(false, 0, new Vector3(17, 0.5f, 19)));
        map3.Add(new Movement(false, 0, new Vector3(17, 0.5f, 14)));
        map3.Add(new Movement(true, 90, new Vector3(17, 0.5f, 9)));
        map3.Add(new Movement(false, 0, new Vector3(12, 0.5f, 9)));
        map3.Add(new Movement(true, 90, new Vector3(7, 0.5f, 9)));
        map3.Add(new Movement(true, -90, new Vector3(7, 0.5f, 15)));
        map3.Add(new Movement(false, 0, new Vector3(0.5f, 0.5f, 15)));
        map3.Add(new Movement(true, -90, new Vector3(-6, 0.5f, 15)));
        map3.Add(new Movement(true, 90, new Vector3(-6, 0.5f, 9)));
        map3.Add(new Movement(false, 0, new Vector3(-10, 0.5f, 9)));
        map3.Add(new Movement(true, -90, new Vector3(-15, 0.5f, 9)));
        map3.Add(new Movement(false, 0, new Vector3(-15, 0.5f, 3.5f)));
        map3.Add(new Movement(false, 0, new Vector3(-15, 0.5f, -2)));
        map3.Add(new Movement(true, -90, new Vector3(-15, 0.5f, -8)));
        map3.Add(new Movement(false, 0, new Vector3(-10, 0.5f, -8)));
        map3.Add(new Movement(false, 0, new Vector3(-5, 0.5f, -8)));
        map3.Add(new Movement(true, -90, new Vector3(-1, 0.5f, -8)));
        map3.Add(new Movement(false, 0, new Vector3(-1, 0.5f, -2)));
        map3.Add(new Movement(true, 90, new Vector3(-1, 0.5f, 3)));
        map3.Add(new Movement(false, 0, new Vector3(3.5f, 0.5f, 3)));
        map3.Add(new Movement(false, 0, new Vector3(8, 0.5f, 3)));
        map3.Add(new Movement(true, 90, new Vector3(13, 0.5f, 3)));
        map3.Add(new Movement(false, 0, new Vector3(13, 0.5f, -1.5f)));
        map3.Add(new Movement(false, 0, new Vector3(13, 0.5f, -6)));
        map3.Add(new Movement(false, 0, new Vector3(13, 0.5f, -10.5f)));
        map3.Add(new Movement(false, 0, new Vector3(13, 0.5f, -15)));
        map3.Add(new Movement(true, -90, new Vector3(13, 0.5f, -20)));
        map3.Add(new Movement(false, 0, new Vector3(18, 0.5f, -20)));
        map3.Add(new Movement(true, -90, new Vector3(22, 0.5f, -20)));
        map3.Add(new Movement(false, 0, new Vector3(22, 0.5f, -15)));
        map3.Add(new Movement(false, 0, new Vector3(22, 0.5f, -10)));
        map3.Add(new Movement(false, 0, new Vector3(22, 0.5f, -5)));
        map3.Add(new Movement(false, 0, new Vector3(22, 0.5f, 0)));
        map3.Add(new Movement(false, 0, new Vector3(22, 0.5f, 5)));
        map3.Add(new Movement(false, 0, new Vector3(22, 0.5f, 10)));
        map3.Add(new Movement(false, 0, new Vector3(22, 0.5f, 15)));
        map3.Add(new Movement(false, 0, new Vector3(22, 0.5f, 20)));

    }

}
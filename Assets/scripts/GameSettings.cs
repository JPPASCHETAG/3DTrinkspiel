using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameSettings
{

    public static int getNumOfPlayer(){
        return PlayerPrefs.GetInt("players");
    }

    public static void setNumOfPlayer(int num){
        PlayerPrefs.SetInt("players", num);
    }


    public static int getMapID(){
        return PlayerPrefs.GetInt("MAP_ID");
    }

    public static void setMapID(int id){
        PlayerPrefs.SetInt("MAP_ID", id);
    }



}

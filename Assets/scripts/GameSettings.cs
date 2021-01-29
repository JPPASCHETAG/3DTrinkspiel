using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameSettings
{
    private static List<Movement> map;
    private static int drinkMode;

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

    public static int getdrinkMode()
    {
        return drinkMode;
    }

    public static void setdrinkMode(int mode)
    {
        drinkMode = mode;
    }
}

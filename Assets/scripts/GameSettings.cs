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
        return PlayerPrefs.GetInt("drink_mode");
    }

    public static void setdrinkMode(int mode)
    {
        PlayerPrefs.SetInt("drink_mode", mode);
    }

    public static void setPlayer1name(string name){
        PlayerPrefs.SetString("Player1_name", name);
    }

    public static string getPlayer1name(){
        return PlayerPrefs.GetString("Player1_name");
    }
    
    public static void setPlayer2name(string name){
        PlayerPrefs.SetString("Player2_name", name);
    }

    public static string getPlayer2name(){
        return PlayerPrefs.GetString("Player2_name");
    }

    public static void setPlayer3name(string name){
        PlayerPrefs.SetString("Player3_name", name);
    }

    public static string getPlayer3name(){
        return PlayerPrefs.GetString("Player3_name");
    }

    public static void setPlayer4name(string name){
        PlayerPrefs.SetString("Player4_name", name);
    }

    public static string getPlayer4name(){
        return PlayerPrefs.GetString("Player4_name");
    }
}

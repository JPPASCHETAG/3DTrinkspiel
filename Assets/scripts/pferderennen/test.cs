using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{
    public CanvasGroup canvas;

    public Sprite cowboy;
    public Sprite police;
    public Sprite woman;
    public Sprite woman2;

    public Image img;

    private int selectedImg = 1;


    void Start()
	{
        treppchen.player1name = "";
        treppchen.player2name = "";
        treppchen.player3name = "";
        treppchen.player4name = "";

        treppchen.bet1 = "";
        treppchen.bet2 = "";
        treppchen.bet3 = "";
        treppchen.bet4 = "";

        treppchen.schluck1 = 0;
        treppchen.schluck2 = 0;
        treppchen.schluck3 = 0;
        treppchen.schluck4 = 0;

        treppchen.platz1 = false;

    }


    public void clickMe()
	{
        
        setValues();

        canvas.alpha = 0;

        race.setFinished();

    }

    public void changeCharakter()
	{
        selectedImg++;
        if (selectedImg > 4)
        {
            selectedImg = 1;
        }

        switch (selectedImg)
        {
            case 1:
                img.sprite = cowboy;
                break;
            case 2:
                img.sprite = police;
                break;
            case 3:
                img.sprite = woman;
                break;
            case 4:
                img.sprite = woman2;
                break;
        }
    }

    public void setValues()
	{
        treppchen.player1name = GameObject.Find("PlayerName1").GetComponent<InputField>().text;
        treppchen.player2name = GameObject.Find("PlayerName2").GetComponent<InputField>().text;
        treppchen.player3name = GameObject.Find("PlayerName3").GetComponent<InputField>().text;
        treppchen.player4name = GameObject.Find("PlayerName4").GetComponent<InputField>().text;

        if(GameObject.Find("Schluck1").GetComponent<InputField>().text != "")
		{
            treppchen.schluck1 = Int32.Parse(GameObject.Find("Schluck1").GetComponent<InputField>().text);
        }
        
        if (GameObject.Find("Schluck2").GetComponent<InputField>().text != "")
        {
            Debug.Log(GameObject.Find("Schluck1").GetComponent<InputField>().text);
            treppchen.schluck2 = Int32.Parse(GameObject.Find("Schluck2").GetComponent<InputField>().text);
        }
        
        if (GameObject.Find("Schluck3").GetComponent<InputField>().text != "")
        {
            treppchen.schluck3 = Int32.Parse(GameObject.Find("Schluck3").GetComponent<InputField>().text);
        }
        
        if (GameObject.Find("Schluck4").GetComponent<InputField>().text != "")
        {
            treppchen.schluck4 = Int32.Parse(GameObject.Find("Schluck4").GetComponent<InputField>().text);
        }
        

        treppchen.bet1 = GameObject.Find("CharSelect1").GetComponent<Image>().sprite.name;
        treppchen.bet2 = GameObject.Find("CharSelect2").GetComponent<Image>().sprite.name;
        treppchen.bet3 = GameObject.Find("CharSelect3").GetComponent<Image>().sprite.name;
        treppchen.bet4 = GameObject.Find("CharSelect4").GetComponent<Image>().sprite.name;

    }

    public void newRound()
	{
        Loader.Load(Loader.Scene.Pferderennen);
	}

    public void backToMainGame(){
        Loader.Load(Loader.Scene.Map2);
    }
}

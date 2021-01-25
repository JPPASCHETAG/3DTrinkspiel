using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class race : MonoBehaviour
{

    private int speed;
    private int frames = 0;
    public GameObject player;
    private static bool finished = true;
    public CanvasGroup cavGrp;

    public Text platz1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        frames++;
        if(frames%1000 == 0 && !finished){
            move();
        }
    }

    public void move(){

        speed = UnityEngine.Random.Range(1, 10);

        Vector3 startPos = player.transform.position;

        Vector3 endPos = new Vector3(0,0,speed);

        endPos += startPos;

        if (endPos.z >= 2096){
            endPos.z = 2096;
            finished = true;
        }

        StartCoroutine (MovePlayerOverSeconds (endPos,1.45f));

    }

    public IEnumerator MovePlayerOverSeconds (Vector3 end, float seconds){
        float elapsedTime = 0;
        Vector3 startingPos = player.transform.position;
        while (elapsedTime < seconds)
        {
            player.transform.position = Vector3.Lerp(startingPos, end, (elapsedTime / seconds));
            elapsedTime += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
        player.transform.position = end;

        if(end.z >= 2096){
            finished = true;
            string playername = player.name;

            if (!treppchen.platz1)
            {
                treppchen.platz1 = true;
                cavGrp.alpha = 1;
                string ergebnis = "";


                if(playername == treppchen.bet1 && treppchen.player1name != "")
                {
                    ergebnis += $"{treppchen.player1name} darf {treppchen.schluck1*2} Schluck verteilen \n";
				}
                if(playername == treppchen.bet2 && treppchen.player2name != "")
				{
                    ergebnis += $"{treppchen.player2name} darf {treppchen.schluck2 * 2} Schluck verteilen \n";
                }
                if (playername == treppchen.bet3 && treppchen.player3name != "")
                {
                    ergebnis += $"{treppchen.player3name} darf {treppchen.schluck3 * 2} Schluck verteilen \n";
                }
                if (playername == treppchen.bet4 && treppchen.player4name != "")
                {
                    ergebnis += $"{treppchen.player4name} darf {treppchen.schluck4 * 2} Schluck verteilen \n";
                }

                if(ergebnis == "")
				{
                    ergebnis = "Leider darf keiner verteilen";
				}

                platz1.text = ergebnis;

            }
        }
    }

    public static void setFinished()
	{
        finished = false;
	}

}

static class treppchen
{
    public static bool platz1;
    public static bool platz2;
    public static bool platz3;
    public static bool platz4;

    public static string player1name;
    public static string player2name;
    public static string player3name;
    public static string player4name;

    public static int schluck1;
    public static int schluck2;
    public static int schluck3;
    public static int schluck4;

    public static string bet1;
    public static string bet2;
    public static string bet3;
    public static string bet4;

}

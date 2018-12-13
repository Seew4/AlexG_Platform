using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int score = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //skapar en variabel "contoller" och sedan går och söker efter ett Gameobject i taggen "GameController
            GameObject controller = GameObject.FindWithTag("GameController");
            if (controller != null)

            {
                //skapar en variabel "tracker" och länkar den till controller och hämtar sedan komponenten ScoreTracker
                ScoreTracker tracker = controller.GetComponent<ScoreTracker>();
                if (tracker != null)
                {
                    //När man nuddar ett mynt så får man +1 poäng, sedan förstörs myntet
                    tracker.totalScore += score;
                }
                Destroy(gameObject);
            }
        }
    }
}

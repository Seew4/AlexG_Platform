using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    //Skapar variabeln touches
    public int touches;

    //När man nuddar marken sätts touches till 1
    private void OnTriggerEnter2D(Collider2D collision)
    {
        touches++;
    }

    //När man inte nuddar marken sätts touches till 0
    private void OnTriggerExit2D(Collider2D collision)
    {
        touches--;
    }

}

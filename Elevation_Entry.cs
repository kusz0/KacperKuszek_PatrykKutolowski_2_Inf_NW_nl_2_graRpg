using UnityEngine;
using System.Collections;
using System.Collections.Concurrent;
public class Elevation_Entry : MonoBehaviour
{

    public Collider2D[] mountainColliders;
    public Collider2D[] borderColliders;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
         foreach(Collider2D mountain in mountainColliders)
         {
                mountain.enabled = false;
         }
         foreach(Collider2D border in borderColliders)
            {
                border.enabled = true;
            }

         collision.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 15;
        }
    }

}

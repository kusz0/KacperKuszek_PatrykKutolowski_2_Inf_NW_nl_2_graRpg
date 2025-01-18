using UnityEngine;
using System.Collections;
using System.Collections.Concurrent;

public class Elevation_Exit : MonoBehaviour
{
    public Collider2D[] mountainColliders;
    public Collider2D[] borderColliders;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            foreach (Collider2D mountain in mountainColliders)
            {
                mountain.enabled = true;
            }
            foreach (Collider2D border in borderColliders)
            {
                border.enabled = false;
            }

            collision.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 10;
        }
    }


}

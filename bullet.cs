using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
       if (col.gameObject.tag == "enemy")
       {
         Destroy (col.gameObject);
         Destroy (gameObject);
         item_info.Score++;
       }
    } 
}

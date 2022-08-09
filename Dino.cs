using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dino : MonoBehaviour
{ 
    Rigidbody2D rg;
    SpriteRenderer sp;
    Vector2 speed;
    Animator Am;
    // Start is called before the first frame update
    void Start()
    {
        Am = GetComponent<Animator>();
        sp = GetComponent<SpriteRenderer>();
        rg = GetComponent<Rigidbody2D>();
        speed = new Vector2(5,0);

        StartCoroutine(walk());
    }

    IEnumerator walk()
    {
        while(true){
            Am.SetFloat("run", Mathf.Abs(speed.x));

            sp.flipX = false;
            rg.velocity = speed;
            yield return new WaitForSeconds(2);

            sp.flipX = true;
            rg.velocity = -speed;
            yield return new WaitForSeconds(2);
        }
    }
 
}

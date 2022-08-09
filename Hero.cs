using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public GameObject sh;
    Rigidbody2D Rigid;
    SpriteRenderer ap;
    Animator Am;
    public int speedx ;
    bool canjump = true;
    Transform trans;
    bool NoControl = false;
    
    // Start is called before the first frame update
    void Start()
    {
        Rigid = GetComponent<Rigidbody2D>();
        ap = GetComponent<SpriteRenderer>();
        Am = GetComponent<Animator>();
        trans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        if (NoControl == true )
        {
            return;
        }


        //การขว้างของด้วยคลิกซ้าย
         if(Input.GetMouseButtonDown(0))
        {
            GameObject s = Instantiate(sh,trans.position,trans.rotation);
            Rigidbody2D rg_s = s.GetComponent<Rigidbody2D>();
            if(ap.flipX == false)
            {
                rg_s.velocity = new Vector2(20,0);
            }
            if(ap.flipX == true)
            {
                rg_s.velocity = new Vector2(-20,0);
            }
        }
        if(Input.GetMouseButtonDown(1))
        {
            Am.SetBool("jump", true);
        }
        //หากตัวละครไม่ถึงพื้นให้รีเทอน์
        if(canjump == false)
        {
            return;
        }

       float x = Input.GetAxis("Horizontal")*speedx;
       Rigid.velocity = new Vector2(x, Rigid.velocity.y);   
       if(Input.GetKeyDown(KeyCode.W)) 
       {
        Rigid.velocity = new Vector2(Rigid.velocity.x, 5);
        Am.SetBool("bejump",true);
        canjump = false;
       }
       if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.A)) 
       {                                           
        ap.flipX =true;
       }
       if(Input.GetKeyDown(KeyCode.D))
       {
         Am.SetFloat("berun",Mathf.Abs(x));
         ap.flipX =false;
       } 
      
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "floor")
        {
            Am.SetBool("bejump", false);
            canjump = true;
            NoControl = false;
        }

        if(coll.gameObject.tag == "enemy")
            {
                NoControl = true;
                Rigid.velocity = new Vector2(-3,3);
                item_info.Life--;
            }
            
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "check")
        {
            ap.sortingOrder = 11;
        }
    }
    void OnTriggerexit2D(Collider2D Other)
    {
        ap.sortingOrder = 0;
    }
    
    
}

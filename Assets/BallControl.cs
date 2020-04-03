using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public int speed = 30;
    public Rigidbody2D movement;
    public Animator animatr;
 
    void Start()
    {
    GetComponent<Rigidbody2D>().velocity= new Vector2(1,-1)*speed;
    movement.velocity = new Vector2(-1,-1) * speed;
    animatr.SetBool("IsMove", true);
       
    }
    void OnCollisionEnter2D(Collision2D other){
    if(other.collider.name=="Kanan" || other.collider.name=="Kiri"){
        GetComponent<Transform>().position = new Vector2(0,0);
    }
}

    // Update is called once per frame
    void FixedUpdate()
    {
        if(movement.velocity.x > 0){
        	movement.GetComponent<Transform>().localScale = new Vector3(1,1,1);
        	}else{
        		movement.GetComponent<Transform>().localScale = new Vector3(-1,1,1);
        	}
    }
    /*void OnCollisionEnter2D (Collision2D coll) {
    if(other.collider.name=="Kanan" || other.collider.name=="Kiri"{
        StartCoroutine(jeda());
    }
}

IEnumerator jeda(){
	movement.velocity = Vector2.zero;
	animtr.SetBool("IsMove", false);
	movement.GetComponent<Transform>().position = Vector2.zero;
	yield return new WaitForSeconds(1);
	movement.velocity = new Vector2(-1,-1) * speed;
	animtr.SetBool("IsMove", true);

}*/

}

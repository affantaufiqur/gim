using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    //public int speed = 30;
    public Rigidbody2D movement;
    public Animator animatr;

    public AudioSource hitEffect;
 
    void Start()
    {
    int x = Random.Range(0, 2)*2-1;
    int y = Random.Range(0, 2)*2-1;
    int speed = Random.Range(1,5);
    //GetComponent<Rigidbody2D>().velocity= new Vector2(x, y)*speed;
    movement.velocity = new Vector2(x, y) * speed;
    movement.GetComponent<Transform>().position = Vector2.zero;
    animatr.SetBool("IsMove", true);
       
    }
    void OnCollisionEnter2D(Collision2D other){
    if(other.collider.name=="Kanan" || other.collider.name=="Kiri"){
        GetComponent<Transform>().position = new Vector2(0,0);
    }
        if (other.collider.tag == "Player")
        {
            hitEffect.Play();
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
	
	int x = Random.Range(0, 2)*2-1;
    int y = Random.Range(0, 2)*2-1;
    int speed = Random.Range(1,5);
	movement.velocity = new Vector2(-1,-1) * speed;
	animtr.SetBool("IsMove", true);

}*/

}

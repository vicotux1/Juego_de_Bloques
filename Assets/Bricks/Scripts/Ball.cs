using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour{
    Rigidbody rb2D;
    public float fuerzaDisparo;
    public Transform Paddle;
    public bool IsShoot;
    public string ShootButton="Jump", tag_ground;
    Vector3 paDdle;
    public LevelManager levelManager;
    void Start(){
        rb2D=GetComponent<Rigidbody>();
        
    }
    void Update(){
            Shoot();
            paDdle=Paddle.transform.position;
    }
    public void Shoot(){
        if(Input.GetButtonDown(ShootButton)&& IsShoot==true){
       transform.SetParent(null);
       IsShoot=false;
       rb2D.isKinematic=false;
       Vector3 Force= new Vector3(0.8f,1.0f,0);
    rb2D.AddForce(Force*fuerzaDisparo);
        }
    }
    void OnCollisionEnter(Collision other){
        
		if (other.gameObject.CompareTag(tag_ground)) {
        rb2D.velocity=Vector3.zero;
        transform.SetParent(Paddle);
        transform.position=new Vector3( paDdle.x,-5.45f,paDdle.z);
        levelManager.lifes();
         rb2D.isKinematic=true;
         IsShoot=true;
        Shoot();
		}
    }
}

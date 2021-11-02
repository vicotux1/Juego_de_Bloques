using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour{
    Rigidbody rb2D;
    public float fuerzaDisparo;
    public string ShootButton="Jump", tag_ground;
    public Vector3 Position_initial;

    void Start(){
        rb2D=GetComponent<Rigidbody>();
        transform.position=Position_initial;
        
    }
    void Update(){
            Shoot();
    }
    public void Shoot(){
        if(Input.GetButtonDown(ShootButton)){
       transform.SetParent(null);
       rb2D.isKinematic=false;
       Vector3 Force= new Vector3(0.8f,1.0f,0);
    rb2D.AddForce(Force*fuerzaDisparo);
        }
    }
    void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag(tag_ground)) {
        rb2D.velocity=Vector3.zero;
        transform.position=Position_initial;
        Shoot();
		}
    }
}

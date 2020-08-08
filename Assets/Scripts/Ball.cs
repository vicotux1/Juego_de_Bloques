using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour{
    Rigidbody rb2D;
    public float fuerzaDisparo;
    bool IsGame=false;
    public Vector3 Position_initial;

    void Start(){
        rb2D=GetComponent<Rigidbody>();
        transform.position=Position_initial;
        
    }
    void Update(){
            Shoot();
    }
    public void Shoot(){
        if(!IsGame && Input.GetButtonDown("Fire1")){
       IsGame=true;
       transform.SetParent(null);
       rb2D.isKinematic=false;
       Vector3 Force= new Vector3(1.0f,0.2f,0);
    rb2D.AddForce(Force*fuerzaDisparo);
    }}
    void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag("Ground")) {
        //StartCoroutine(Starting(0.5f)); 
        rb2D.velocity=Vector3.zero;
        transform.position=Position_initial;
        GameManager.gameManager.LifeCoint();
        IsGame=false;
        Shoot();
		}

       /* IEnumerator Starting(float waitTime){
            while (true){
        rb2D.velocity=Vector3.zero;
        transform.position=Position_initial;
        GameManager.gameManager.LifeCoint();
        IsGame=false;
        Shoot();
            }
        }  */
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed=1.0f;
    public string EjeH="Horizontal";
    Rigidbody rb2D;

    void Start(){
        rb2D=GetComponent<Rigidbody>();
    }
    void FixedUpdate(){
        float H=Input.GetAxis(EjeH);
        Vector3 Move=new Vector3(H,transform.position.y,transform.position.z) 
        *Speed*Time.fixedDeltaTime;
        rb2D.velocity=Move;
        
        
    }
}

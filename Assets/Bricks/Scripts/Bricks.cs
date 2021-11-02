using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour{
    public int BrickValue=10;
    public string tag_ball="Ball";

    void OnCollisionEnter(Collision other){
		if (other.gameObject.CompareTag(tag_ball)) {
		Destroy (this.gameObject);
        GameManager.Points+=BrickValue;
        }
    }
}

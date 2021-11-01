using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour{
    public int BrickValue=10;
    public string tag_Ball="ball";
    private void Start() {
    }

    void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.CompareTag(tag_Ball)) 
		{
		Destroy (this.gameObject);
        //GameManager.gameManager.AddPoint(BrickValue);


		}
    }
}

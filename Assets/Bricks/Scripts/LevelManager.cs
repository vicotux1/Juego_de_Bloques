using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelManager : MonoBehaviour{
    public int Life=3, lifeRest= 1, lifeGameOver=0;

    public int Score=0;
    public string Next_Scene="001";
    public TextMeshProUGUI Points,Lives,ganastes;
    
#region Funtion Unity
    void Update(){
        Score=GameManager.Points;
        Points.text="Point: ";
        Lives.text="Lives: "+Life;
        Points.text="Point: "+ Score;
    }
    void Start(){
        GameManager.lives=Life;
        ganastes.text=" ";
        Points.text="Point:0";
        Lives.text="Lives: "+ Life;
    }
#endregion

#region Funtion publics Creates
public void LifeCoint(){
        
        Life=Life-lifeRest;
        if(Life==lifeGameOver){
        StartCoroutine(Starting(2.0f));
        }else if(Life>=0){
         StartCoroutine(NewBall(1.0f));   
        }
    }
IEnumerator Starting(float waitTime){
    while (true){ganastes.text="Perdiste";
    yield return new WaitForSeconds(waitTime);
	SceneManager.LoadScene (Next_Scene);
        }
    }
IEnumerator NewBall(float Time){
    while (true){
    ganastes.text="lives:"+Life.ToString();
    yield return new WaitForSeconds(Time);
    ganastes.text=" ";
        } 
    }
#endregion


}  

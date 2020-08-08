#region previous assignments
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
#endregion
public class GameManager : MonoBehaviour{
#region Singleton 
public static GameManager gameManager;
private void Awake() {
    Life= 10;
    if (gameManager!=null){
    Destroy(this.gameObject);      
    }else{
        gameManager=this;}
    }
#endregion
#region Public Variables 
public int Life= 3;
public string Next_Scene="001";
public TextMeshProUGUI Points,Lives,ganastes;
#endregion
#region Private Variables
private int Point=0;
#endregion
#region Funtion privates Unity
void Start(){
        ganastes.text=" ";
        Points.text="Point:0";
        Lives.text="Lives: "+ Life;
    }
void Update(){
        Points.text="Point: ";
        Lives.text="Lives: "+Life;
        Points.text="Point: "+ Point;
    }
#endregion    
#region Funtion publics Creates
public void AddPoint(int Value){
        Point=Point+Value;
    }
public void LifeCoint(){
        Life=Life-1;
        if(Life==0){
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
  }  
#endregion
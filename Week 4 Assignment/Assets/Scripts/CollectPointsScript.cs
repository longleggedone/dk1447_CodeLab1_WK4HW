using UnityEngine;
using System.Collections;

public class CollectPointsScript : MonoBehaviour {

	public GameManagerScript gameManager;

	public int pointsValue = 10;

	public int damageValue = 1;

	public static CollectPointsScript instance;

	void Start(){
		if(instance == null){
			instance = this;
			DontDestroyOnLoad(this);
		}
		else{
			Destroy(this.gameObject);
		}
	}


	void OnCollisionEnter2D (Collision2D other){
		//Debug.Log ("collided");
		if (other.gameObject.tag == "Points")
		{
			Destroy(other.gameObject);
			gameManager.Score += pointsValue;
		}
		if (other.gameObject.tag == "Obstacle"){
			gameManager.Health -= damageValue;
		}
	}
}

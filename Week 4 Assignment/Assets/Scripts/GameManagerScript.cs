using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour {

	public Text scoreText;
	public Text healthText;

	private int scoreToAdvance = 100;

	private int score;

	public int Score{
		get{
			return score;
		}
		set{
			score = value;
			scoreText.text = "Score: " + score;
			Debug.Log ("Score: " + Score);
		}
	}
		
	private const int HEALTH_MIN = 0;
	public const int HEALTH_MAX = 5;

	//public int damageAmt = 1;

	private static int health;

	public int Health{
		get{
			return health;
		}

		set{
			health = value;
			healthText.text = "Health: " + health;

			if(health > HEALTH_MAX){
				health = HEALTH_MAX;
			}

			if(health < HEALTH_MIN){
				health = HEALTH_MIN;
			}

			Debug.Log ("Health: " + Health);
		}
	}
		
	public static GameManagerScript instance;

	// Use this for initialization
	void Start () {
		if(instance == null){
			instance = this;
			DontDestroyOnLoad(this);
		}
		else{
			Destroy(this.gameObject);
		}

		score = 0;
		health = HEALTH_MAX;

		scoreText.text = "Score: " + score;
		healthText.text = "Health: " + health;
	}

	// Update is called once per frame
	void Update () {
		if(Score == scoreToAdvance){
			scoreToAdvance += 100;
			SceneManager.LoadScene("Scene 2");
		}
		if(Health == 0){
			Health = HEALTH_MAX;
			SceneManager.LoadScene("Scene 1");
		}
	}
}

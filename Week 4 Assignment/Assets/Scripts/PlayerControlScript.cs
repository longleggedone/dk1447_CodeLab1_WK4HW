using UnityEngine;
using System.Collections;

public class PlayerControlScript : MonoBehaviour {
	
	public float speed = 1;

	public KeyCode upKey = KeyCode.W;
	public KeyCode downKey = KeyCode.S;
	public KeyCode leftKey = KeyCode.A;
	public KeyCode rightKey = KeyCode.D;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		Move(Vector3.up, upKey);
		Move(Vector3.down, downKey);
		Move(Vector3.left, leftKey);
		Move(Vector3.right, rightKey);
	}

	void Move(Vector3 dir, KeyCode key){
		if(Input.GetKey(key)){
			transform.Translate(dir * speed * Time.deltaTime);
		}
	}
}

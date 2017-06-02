using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ghost : MonoBehaviour {
	
	
	private float min;
	private float max;
	private float speed;

	public int x;
	// Use this for initialization
	void Start () {
		
		 min = GameObject.Find("Game(Clone)").GetComponent<Game>().MIN;
		 max = GameObject.Find("Game(Clone)").GetComponent<Game>().MAX;
		 speed = Random.Range(min, max);
		 
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Translate(Vector3.up * Time.deltaTime * speed, Space.World);
		
	}
	
	void OnMouseDown () {
		
		GameObject.Find("Game(Clone)").GetComponent<Game>().score++;
		int score = GameObject.Find("Game(Clone)").GetComponent<Game>().score;
		GameObject.Find("Score(Clone)").GetComponent<Text>().text= "Score: " + score.ToString();
	
		Destroy(gameObject);
		
	}
}

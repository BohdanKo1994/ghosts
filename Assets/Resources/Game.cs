using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour {

	
	public float MAX = 10.0f;
	public float MIN = 1.0f;
	public int score = 0;
	
	private int count = 0;
	private float time = 1.0f;  
	// Use this for initialization
	void Start () {
		
		PlayerPrefs.SetInt("restart", 0);
		
		GameObject count = Instantiate(Resources.Load("Count")) as GameObject;
		count.transform.SetParent(GameObject.Find("Canvas").transform);
		count.transform.position = new Vector3(100.0f, 700.0f, 0.0f);
		
		GameObject score = Instantiate(Resources.Load("Score")) as GameObject;
		score.transform.SetParent(GameObject.Find("Canvas").transform);
		score.transform.position = new Vector3(1000.0f, 700.0f, 0.0f);
		
		GameObject menu = Instantiate(Resources.Load("Menu")) as GameObject;
		menu.transform.SetParent(GameObject.Find("Canvas").transform);
		menu.transform.position = new Vector3(50.0f, 50.0f, 0.0f);
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if ((time >= 1.0f) && (count < 10)) {
			time = 0.0f;
			
			count++;
			GameObject.Find("Count(Clone)").GetComponent<Text>().text = count.ToString()+"/10";
			
			GameObject ghost = Instantiate(Resources.Load("Ghost")) as GameObject;
			ghost.transform.position = new Vector3(Random.Range(-4.5f, 4.5f), -4.0f, 0.0f);
		}
		
		time += Time.deltaTime;
		
	}
}

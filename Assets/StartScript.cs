using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class StartScript : MonoBehaviour {

	private int restart = 0;
	
	void Start () {
		restart = PlayerPrefs.GetInt("restart");
		if (restart==1) onMouseDown();
		GetComponent<Button>().onClick.AddListener(() => onMouseDown());
	}

	// Update is called once per frame
	void Update () {

	}

	void onMouseDown () {
		GameObject game = Instantiate(Resources.Load("Game")) as GameObject;
		
		Destroy(gameObject);
	}
}

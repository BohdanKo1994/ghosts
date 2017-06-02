using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Button>().onClick.AddListener(() => onMouseDown());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void onMouseDown () {
		
		PlayerPrefs.SetInt("restart", 0);
		SceneManager.LoadScene("Scene");
	}
	
}

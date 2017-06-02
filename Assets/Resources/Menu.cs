using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Menu : MonoBehaviour {
	
void Start () {
		GetComponent<Button>().onClick.AddListener(() => onMouseDown());
	}

	// Update is called once per frame
	void Update () {

	}

	void onMouseDown () {
		GameObject panel = Instantiate(Resources.Load("Panel")) as GameObject;
		panel.transform.SetParent(GameObject.Find("Canvas").transform);
		panel.transform.position = new Vector3(500.0f, 330.0f, 0.0f);
		
	}
}

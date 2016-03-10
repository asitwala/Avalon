using UnityEngine;
using System.Collections;

public class GameState : MonoBehaviour {
	public GameObject quest1; 
	public GameObject quest2;
	public GameObject quest3; 
	public GameObject quest4; 
	public GameObject quest5; 
	public GameObject[] successes;
	public GameObject[] fails;
	public GameObject[] accepts; 
	public int count_successes = 0; 
	public int count_fails = 0;
	public int count_choices = 0; 


	void activateObject (GameObject g, bool a) {
		g.SetActive (a);
	}

	void setQuestRed (GameObject q) {
		// Fail color = red
		Renderer rend = q.GetComponent<Renderer>(); 
		rend.enabled = true; 
		rend.material.color = Color.red; 	
	}

	void setQuestBlue (GameObject q) {
		// Fail color = red
		Renderer rend = q.GetComponent<Renderer>(); 
		rend.enabled = true; 
		rend.material.color = Color.blue; 
	}

	void questResult (GameObject q) {
		
		if (count_choices == 4) {
			if (count_successes == 4) {
				setQuestBlue (q); 
			} else {
				setQuestRed (q);
			}
			count_choices = 0;
			count_fails = 0; 
			count_successes = 0; 

			successes = GameObject.FindGameObjectsWithTag ("Succeed");
			fails = GameObject.FindGameObjectsWithTag ("Fail");
			accepts = GameObject.FindGameObjectsWithTag ("Accept");

			foreach (GameObject success in successes) {
				activateObject (success, false); 	
			}

			foreach (GameObject fail in fails) {
				activateObject (fail, false); 
			}

			foreach (GameObject accept in accepts) {
				activateObject (accept, true); 
			}
		}
	}
		

	void Start () {
		successes = GameObject.FindGameObjectsWithTag ("Succeed");
		fails = GameObject.FindGameObjectsWithTag ("Fail");
		accepts = GameObject.FindGameObjectsWithTag ("Accept");

		foreach (GameObject success in successes) {
			activateObject (success, true); 	
		}

		foreach (GameObject fail in fails) {
			activateObject (fail, true); 
		}

		foreach (GameObject accept in accepts) {
			activateObject (accept, false); 
		}
			
		//setQuestBlue (quest2); 
	}

	void Update () {
		quest1 = GameObject.FindWithTag("Quest1");
		quest2 = GameObject.FindWithTag("Quest2");
		quest3 = GameObject.FindWithTag("Quest3");
		quest4 = GameObject.FindWithTag("Quest4");
		quest5 = GameObject.FindWithTag("Quest5");

		questResult (quest5); 
		
	}
}

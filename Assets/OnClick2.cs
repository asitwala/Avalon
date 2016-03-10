using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OnClick2 : MonoBehaviour {

	void OnMouseDown() {
		//SceneManager.LoadScene ("Test_1");
		GameObject.Find ("ImageTarget").GetComponent<GameState> ().count_choices = GameObject.Find ("ImageTarget").GetComponent<GameState> ().count_choices + 1; 
		GameObject.Find ("ImageTarget").GetComponent<GameState> ().count_fails = GameObject.Find ("ImageTarget").GetComponent<GameState> ().count_fails + 1; 
	}

}

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OnClick : MonoBehaviour {

	void OnMouseDown() {
		GameObject.Find ("ImageTarget").GetComponent<GameState> ().count_choices = GameObject.Find ("ImageTarget").GetComponent<GameState> ().count_choices + 1; 
		GameObject.Find ("ImageTarget").GetComponent<GameState> ().count_successes = GameObject.Find ("ImageTarget").GetComponent<GameState> ().count_successes + 1; 

		//SceneManager.LoadScene ("Test_1");
		//LoadSceneMode.Single -- closes all current loaded scenes
		//and loads a scene
//		if (SceneManager.GetActiveScene ().name == "Scene_1_cardboard") {
//			SceneManager.LoadScene ("Scene_2_cardboard", LoadSceneMode.Single);
//		}


	}

}

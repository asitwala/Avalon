using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OnClickMountain : MonoBehaviour {

	void OnMouseDown() {
		SceneManager.LoadScene ("Scene_1");
	}
}

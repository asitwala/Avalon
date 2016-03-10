using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OnClickTower : MonoBehaviour {

	void OnMouseDown() {
		SceneManager.LoadScene ("Test_1");
	}
}

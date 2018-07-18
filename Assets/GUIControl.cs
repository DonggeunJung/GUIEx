using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GUIControl : MonoBehaviour {

	public Text titleText;

	public void OnChangeTextButtonClicked() {
		titleText.text = "Clicked";
	}

	public void OnSubSceneButtonClicked() {
		SceneManager.LoadScene ("Sub");
	}
}

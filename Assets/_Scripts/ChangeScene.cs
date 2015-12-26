using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {


	public void SceneToChange() {

	}


	public void MoveToGameScene() {
		Debug.Log ("MoveToGameScene");
		Application.LoadLevel ("GameScene");
	}

	public void MoveToTitleScene() {
		Debug.Log ("MoveToTitleScene");
		Application.LoadLevel ("TitleScene");
	}
}

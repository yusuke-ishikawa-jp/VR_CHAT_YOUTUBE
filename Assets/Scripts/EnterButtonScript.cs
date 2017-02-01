using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterButtonScript : MonoBehaviour {

	public void OnMouseEnter () {
		Debug.Log("３秒間見続けてください。");
		Invoke ( "SceneLoad", 3.0f );
	}

	public void SceneLoad () {
		Debug.Log("3秒経ちました。ログインします。");
		SceneManager.LoadScene ("Main");
	}

	public void OnMouseExit () {
		Debug.Log("選択をキャンセルしました。");
		CancelInvoke ();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoginScript : MonoBehaviour {
/*
	public void OnMouseEnter () {

		StartCoroutine("SceneLoad()");

	}

	
	public IEnumerator SceneLoad() {


		for (int i = 0; i < 5; i++) {
			Debug.Log("i:" + i);
			yield return new WaitForSeconds(3.0f);

			if(i == 3) {
				Debug.Log("3秒経ちました。ログイン画面に移ります。");
				SceneManager.LoadScene ("LoginView");
			}
		}
	}
*/
	void start () {

	}

	public void OnMouseEnter () {
		Debug.Log("３秒間見続けてください。");
		Invoke ( "SceneLoad2", 3.0f );
	}

	public void SceneLoad2 () {
		Debug.Log("3秒経ちました。ログイン画面に移ります。");
		SceneManager.LoadScene ("LoginView");
	}

	public void OnMouseExit () {
		Debug.Log("選択をキャンセルしました。");
		CancelInvoke ();
	}
}

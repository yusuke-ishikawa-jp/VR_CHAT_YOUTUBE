using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class EnterButtonScript : MonoBehaviour {

	public Button EnterButton;

	void start () {

		EnterButton = GameObject.Find ("Canvas/Panel/EnterButton").GetComponent<Button> ();

	}

	void Update () {
		Text  x = GameObject.Find("InputText").GetComponent<Text>();
		//Text  y = GameObject.Find("Placeholder").GetComponent<Text>();

		if( x.text == "" ) {
		//	Debug.Log("ユーザーネームを入れてください。");
			EnterButton.interactable = false;
		}
		else {
		//	Debug.Log(x.text);
			EnterButton.interactable = true;
		}
	}

	public void OnMouseEnter () {

		Text  x = GameObject.Find("InputText").GetComponent<Text>();
		if( x.text == "" ) {
			Debug.Log("ユーザーネームを入れないと押せません。");
		}
		else {
			Debug.Log("３秒間見続けてください。");
			Invoke ( "SceneLoad", 3.0f );
		}
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

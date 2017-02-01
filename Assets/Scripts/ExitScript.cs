using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitScript : MonoBehaviour {

	public void OnMouseEnter () {
		Debug.Log("３秒間見続けてください。");
		Invoke ( "GameEnd", 3.0f );
	}

	public void OnMouseExit () {
		Debug.Log("選択をキャンセルしました。");
		CancelInvoke ();
	}

	public void GameEnd () {
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;

		#else
		Applicatin.Quit ();

		#endif
	}
}

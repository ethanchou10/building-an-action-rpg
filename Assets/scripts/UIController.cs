using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour {

	void OnEnable() {
		Messenger.AddListener(GameEvent.LEVEL_COMPLETE, OnLevelComplete);
	}
	void OnDisable() {
		Messenger.RemoveListener(GameEvent.LEVEL_COMPLETE, OnLevelComplete);
	}

	private void OnLevelComplete() {
		StartCoroutine(CompleteLevel());
	}
	private IEnumerator CompleteLevel() {
		Debug.Log("Level completes");

		yield return new WaitForSeconds(2);

		Managers.Mission.GoToNext();
	}

	private void OnGameComplete() {
	
	}
}

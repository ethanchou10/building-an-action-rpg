using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour {

	void OnEnable() {
		Messenger.AddListener(GameEvent.LEVEL_COMPLETE, OnLevelComplete);
		Messenger.AddListener(GameEvent.LEVEL_FAILED, OnLevelFailed);
	}
	void OnDisable() {
		Messenger.RemoveListener(GameEvent.LEVEL_COMPLETE, OnLevelComplete);
		Messenger.RemoveListener(GameEvent.LEVEL_FAILED, OnLevelFailed);
	}

	private void OnLevelFailed() {
		StartCoroutine(FailLevel());
	}

	private void OnLevelComplete() {
		StartCoroutine(CompleteLevel());
	}
	private IEnumerator CompleteLevel() {
		Debug.Log("Level completed");

		yield return new WaitForSeconds(2);

		Managers.Mission.GoToNext();
	}

	private IEnumerator FailLevel() {
		Debug.Log("Level failed");

		yield return new WaitForSeconds(2);

		Managers.Player.Respawn();
		Managers.Mission.RestartCurrent();
	}

	private void OnGameComplete() {
	
	}
}

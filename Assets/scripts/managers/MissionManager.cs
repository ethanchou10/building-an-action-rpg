using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class MissionManager : MonoBehaviour, IGameManager {
	public ManagerStatus status {get; private set;}
	
	public int curLevel {get; private set;}
	public int maxLevel {get; private set;}
	
	public void Startup() {
		Debug.Log("Mission manager starting...");
		
		curLevel = 0;
        maxLevel = 1;
		
		// any long-running startup tasks go here, and set status to 'Initializing' until those tasks are complete
		status = ManagerStatus.Started;
	}

	public void GoToNext() {
		if (curLevel < maxLevel) {
			curLevel++;
			string name = "Level" + curLevel;
			Debug.Log("Loading " + name);
			SceneManager.LoadScene(name);
		} else {
			Debug.Log("Last level");
		}
	}
}

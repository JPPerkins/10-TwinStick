using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class GameManager : MonoBehaviour {
	public bool recording = true;
	private float initialFixedDelta;
	private bool isPaused = false;

	void Start() {
		PlayerPrefsManager.UnlockLevel(2);
		initialFixedDelta = Time.fixedDeltaTime;
//		print(PlayerPrefsManager.IsLevelUnlocked(1));
//		print(PlayerPrefsManager.IsLevelUnlocked(2));
	}

	// Update is called once per frame
	void Update () {
		if (CrossPlatformInputManager.GetButton("Fire1")) {
			recording = false;
		} else {
			recording = true;
		}

		if (Input.GetKeyDown(KeyCode.P) && isPaused) {
			ResumeGame();
			isPaused = false;
		} else if (Input.GetKeyDown(KeyCode.P) && !isPaused) {
			ResumeGame();
			isPaused = true;
		}

//		print("update");
	}

	void ResumeGame() {
		Time.timeScale = 1f;
		Time.fixedDeltaTime = initialFixedDelta;
	}

	void PauseGame() {
		Time.timeScale = 0;
		Time.fixedDeltaTime = 0;
	}

	void OnApplicationPause(bool pauseStatus) {
		isPaused = pauseStatus;
	}
}

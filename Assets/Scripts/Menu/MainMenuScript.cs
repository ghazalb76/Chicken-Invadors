using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainMenuScript : MonoBehaviour {
	public GameObject menu;
	/*public void ShowProfile(){
		
		SceneManager.LoadScene("Profile", LoadSceneMode.Single);
	}
	public void ShowPreferences(){
		SceneManager.LoadScene("Preferences", LoadSceneMode.Single);
	}*/
	public void QuitMenu(){
		Debug.Log("Canvas has been disabled");
	}
	public void loadOtherScene(){
		menu.SetActive(false);
		SceneManager.LoadScene("SampleScene", LoadSceneMode.Additive);

	}
}

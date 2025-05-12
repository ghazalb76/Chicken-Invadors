using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Logo : MonoBehaviour {
	public GameObject logo;
	public GameObject Menu;
	
 	AudioSource audioData;

	// Use this for initialization
	void Start () {

		StartCoroutine(LateCall());
		audioData = GetComponent<AudioSource>();
		
	}
    IEnumerator LateCall()
    {
 
        yield return new WaitForSeconds(5);
		logo.SetActive(false);
		SceneManager.LoadScene("MainMenu", LoadSceneMode.Additive);
		//Menu.SetActive(true);
     }

		
	
}



       

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;


public class ProfileScript : MonoBehaviour {
	public InputField NameField, UsernameField, EmailField;
	public Text name, username, email;
	private string path;
	public RawImage EditImg, ProfileImg;

    void Start(){
		// Restore Name
		name.text = PlayerPrefs.GetString("TempName");
		NameField.text = PlayerPrefs.GetString("TempName");
		// Restore UserName
		username.text = PlayerPrefs.GetString("TempUserName");
		UsernameField.text = PlayerPrefs.GetString("TempUserName");
		// Restore Email
		email.text = PlayerPrefs.GetString("TempEmail");
		EmailField.text = PlayerPrefs.GetString("TempEmail");
		// Restore Image
		
		path = PlayerPrefs.GetString("TempImage");
		WWW www = new WWW("file:///"+path);
		EditImg.texture = www.texture;
		www = new WWW("file:///"+path);
		ProfileImg.texture = www.texture;
	}

	public void storeData(){
		if (NameField.text != ""){
			PlayerPrefs.SetString("TempName", NameField.text);
			name.text = PlayerPrefs.GetString("TempName");
		}
		if (UsernameField.text != ""){
			PlayerPrefs.SetString("TempUserName", UsernameField.text);
			username.text = PlayerPrefs.GetString("TempUserName");
		}
		if (EmailField.text != ""){
			PlayerPrefs.SetString("TempEmail", EmailField.text);
			email.text = PlayerPrefs.GetString("TempEmail");
		}
	}

	public void openExplorer(){
		path = EditorUtility.OpenFilePanel("Overwrite with png", "", "png");
		getImage();
	}

	void getImage(){
		if (path != null){
			updateImage();
		}
	}

	void updateImage(){
		WWW www = new WWW("file:///"+path);
		EditImg.texture = www.texture;
	}

	public void updateProfileImage(){
		WWW www = new WWW("file:///"+path);
		ProfileImg.texture = www.texture;
		PlayerPrefs.SetString("TempImage", path);
	}
	/*public void BackToMenu(){
		SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
	}*/
}

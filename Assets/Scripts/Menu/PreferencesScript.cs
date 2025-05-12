using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PreferencesScript : MonoBehaviour {

	[SerializeField]
	private Font[] fontatt;
	private Camera mycamera;
	public Button[] buttons;
	public Text[] texts;
	List<Color32> normal_colors_list = new List<Color32>(){
        new Color32(255, 102, 0, 204),
		new Color32(255, 133, 51, 255),
		new Color32(255, 0, 0, 230),
		new Color32(255, 255, 0, 255)
		//new Color32(255, 191, 255, 0)
    };
	List<Color32> highlighted_colors_list = new List<Color32>(){
        new Color32(255, 179, 102, 255),
		new Color32(255, 209, 179, 255),
		new Color32(255, 128, 128, 255),
		new Color32(255, 255, 128, 255)
		//new Color32(255, 230, 255, 153)
    };

	public void Start(){
		mycamera = Camera.main;
	}

	public void ChangeFonts(){
		int index = Random.Range(0, 3);
		foreach(Text text in texts){
			text.font = fontatt[index];
		}
	}

	public void ChangeButtonsColors(){
		int index = Random.Range(0, 4);
		foreach (Button btn in buttons){
			ColorBlock colors = btn.colors;
			colors.normalColor = normal_colors_list[index];
			Debug.Log(index);
			colors.highlightedColor = highlighted_colors_list[index];
			colors.pressedColor = highlighted_colors_list[index];
			btn.colors = colors;
		}
	}

	public void ChangePanleColor(){
		int index = Random.Range(0, 4);
		mycamera.backgroundColor = normal_colors_list[index];
	}

	/*public void BackToMenu(){
		SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
	}*/
}

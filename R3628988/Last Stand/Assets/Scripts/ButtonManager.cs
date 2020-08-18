using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour {

	public Canvas lootScreen;
	public GameObject lootManager;

	public void loadScene(){
		SceneManager.LoadScene ("Level01");
	}

	public void enableLootScreen(){
		lootScreen.gameObject.SetActive (true);
		lootManager.GetComponent<LootManager>().populateText ();

	}
}

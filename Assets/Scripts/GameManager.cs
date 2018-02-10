using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	public static bool gameOver;
	public static bool win;
	public static int level = 1;
	public GameObject gameOverText;
	public GameObject player;
	public GameObject nextLevelButton;
	public GameObject winObject;
	public MovePlayer playMove;



	void Update () {
		if (gameOver == true) {
			Debug.Log("Player Died");
			gameOverText.SetActive(true);
			Destroy(player);

		}

		if (win == true) {

			winObject.SetActive(true);
			nextLevelButton.SetActive(true);
		}
	}
	public void NextLevel()
	{
		level++;
		SceneManager.LoadScene("Level" + level);
	}

}
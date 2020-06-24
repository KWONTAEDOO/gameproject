using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour
{

	private bool gameStarted = false;

	[SerializeField]

	private Text gameStateText;

	[SerializeField]

	private GameObject player;

	[SerializeField]

	private BirdMovement birdMovement;

	[SerializeField]

	private TargetFollow targetFollow;

	private float restartDelay = 3;

	private float restartTimer;

	private FrogMovement frogMovement;

	private PlayerHealth playerHealth;
  
    void Start()
    {
		Cursor.visible = false;

		frogMovement = player.GetComponent<FrogMovement>();

		playerHealth = player.GetComponent<PlayerHealth>();

		//시작때 움직이는거 방지 왜 frog 만 true로 설정해줘야 진행?
		frogMovement.enabled = true;

		birdMovement.enabled = false;

		targetFollow.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {

		if(gameStarted == false&&Input.GetKeyUp(KeyCode.Space))
		{
			//스페이스바눌리면 시작
			StartGame();
		}
		//죽으면 끝내라
		if(playerHealth.alive==false)
		{
			EndGame();

			//재시작 타임 설정
			restartTimer = restartTimer + Time.deltaTime;

			if(restartTimer>=restartDelay)
			{
				//화면 재시작
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			}
		}
    }
	private void StartGame()
	{
		gameStarted = true;
		gameStateText.color = Color.clear;
		frogMovement.enabled = true;
		birdMovement.enabled = true;
		targetFollow.enabled = true;
	}
	private void EndGame()
	{
		gameStarted = false;

		gameStateText.color = Color.white;
		gameStateText.text = "GameOver!";

		player.SetActive(false);
	}
}

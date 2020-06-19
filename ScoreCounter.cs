using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
	public static int score;

	private Text ScoreCounterText;
	// Start is called before the first frame update
	void Start()
	{
		ScoreCounterText = GetComponent<Text>();

		score = 0;
	}
	public void UpdateScoreCounter()
	{
		ScoreCounter.score++;
		ScoreCounterText.text = score.ToString() + "Flies";
	}
	// Update is called once per frame
	
}
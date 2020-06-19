using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyPickup : MonoBehaviour
{
	[SerializeField]

	private GameObject pickupparticle;

	private ScoreCounter counter;

	private void Start()
	{
		counter = FindObjectOfType<ScoreCounter>();
	}


    //개구리랑 부딪혔을 때 파괴
    void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("Player"))
		{
			//파티클 추가
			Instantiate(pickupparticle, transform.position, Quaternion.identity);
			// fly가 계쏙해서 생성
			flyspawner.totalFlies--;
			counter.UpdateScoreCounter();
			Destroy(gameObject); 
		}

	}
}

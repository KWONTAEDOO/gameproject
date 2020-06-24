using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
	//public이아니라 private여서 캐릭터가 종료가 안됬었다 !!
	public bool alive;

	[SerializeField]
	private GameObject pickupPrefab;
   
    void Start()
    { 
		alive = true;// 게임시작됬을때 살아있다.
    }
	
	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Enemy")&&alive==true)
		{
			alive = false;

			Instantiate(pickupPrefab, transform.position, Quaternion.identity);

		}
	}
}

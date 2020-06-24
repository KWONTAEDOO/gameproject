
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyspawner : MonoBehaviour
{
	[SerializeField]

	private GameObject flyprefab;

	[SerializeField]

	private int totalFlymin = 12;

	[SerializeField]

	private float spawnArea = 25f;

	public static int totalFlies;



    void Start()
    {
		totalFlies = 0;
    }

    void Update()
    {
        while(totalFlies < totalFlymin)
		{
			totalFlies++;

			//파리 랜덤위치에서 생성
			float positionX = Random.Range(-spawnArea, spawnArea);
			float positionZ = Random.Range(-spawnArea, spawnArea);

			Vector3 flyposition = new Vector3(positionX, 2f, positionZ);

			//새로운 파리설정
			Instantiate(flyprefab, flyposition, Quaternion.identity);
		}
    }
}

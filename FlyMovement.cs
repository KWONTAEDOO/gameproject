using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyMovement : MonoBehaviour
{
	[SerializeField]

	private Transform center;

	private float flySpeed;
    //파리가 날아다니는 속도 
	void Start()
    {
		flySpeed = Random.Range(300f, 700f);
    }

    //파리가 날아다니는 범위
    void Update()
    {
		transform.RotateAround(center.position, Vector3.up, flySpeed*Time.deltaTime);     
    }
}

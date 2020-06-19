using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetFollow : MonoBehaviour
{
	[SerializeField]
	private Transform target;

	[SerializeField]
	private Vector3 offset;

	[SerializeField]
	private float followSpeed;
 
    // Update is called once per frame
    void LateUpdate()
    {
		Vector3 newPosition = target.position + offset;

		transform.position = Vector3.Lerp(transform.position, newPosition, followSpeed * Time.deltaTime);
    }
}

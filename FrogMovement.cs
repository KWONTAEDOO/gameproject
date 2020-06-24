using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogMovement : MonoBehaviour
{
	private float horizontalMovement;

	private float verticalMovement;

	private Vector3 desiredDirection;

	private Animator frogAnimator;

	private Rigidbody frogRigidbody;

	Quaternion rotation = Quaternion.identity;

	[SerializeField] private float turnSpeed;

	[SerializeField]
	private RandomSound playerFootSteps;

	
	void Start()
	{
		frogAnimator = GetComponent<Animator>();
		frogRigidbody = GetComponent<Rigidbody>();
		frogAnimator.SetBool("IsIdle", true);
	}

	

	void Update()
	{
		horizontalMovement = Input.GetAxisRaw("Horizontal");
		verticalMovement = Input.GetAxisRaw("Vertical");
		desiredDirection = new Vector3(horizontalMovement, 0, verticalMovement);
	}

	void FixedUpdate()
	{

		if (desiredDirection == Vector3.zero)
		{
			frogAnimator.SetBool("IsIdle", true);

			//발걸음내지마라
			playerFootSteps.enabled = false;
		}
		else
		{
			Quaternion targetRotation = Quaternion.LookRotation(desiredDirection, Vector3.up);

			Quaternion newRotation = Quaternion.Lerp(frogRigidbody.rotation, targetRotation, turnSpeed * Time.fixedDeltaTime);

			frogRigidbody.MoveRotation(newRotation);

			frogAnimator.SetBool("IsIdle", false);

			playerFootSteps.enabled = true;
		}
	}
}

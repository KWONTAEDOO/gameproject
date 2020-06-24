using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BirdMovement : MonoBehaviour
{

	[SerializeField]

	private Transform frogTranform;

	private NavMeshAgent birdAgent;

	private Animator _birdAnimator;

	[SerializeField]

	private RandomSound birdFootSteps;
   
    void Start()
    {
		birdAgent = GetComponent<NavMeshAgent>();
		_birdAnimator = GetComponent<Animator>();

		_birdAnimator.SetBool("Walking", true);
	}

    void Update()
    {
		birdAgent.SetDestination(frogTranform.position);

		if(birdAgent.velocity.magnitude>0)
		{
			birdFootSteps.enabled = true;
		}
		else
		{
			birdFootSteps.enabled = false;
		}
    }

	private void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("Player"))
		{
			_birdAnimator.SetBool("Attacking", true);
		}
	}
}

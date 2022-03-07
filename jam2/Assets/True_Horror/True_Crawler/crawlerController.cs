using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crawlerController : MonoBehaviour
{
	[SerializeField] private CrawlerState currentState;
	[SerializeField] private float alertRange = 10f;
	[SerializeField] private float huntRange = 5f;
	[SerializeField] private float speed = 1f;
	[SerializeField] private GameObject player;
	[SerializeField] private Animator animationController;

	enum CrawlerState
	{
		Patrol = 0,
		Alert,
		Hunt,
		Attack,
		Stun
	}

	void Start()
    {
		animationController = GetComponent<Animator>();
		currentState = CrawlerState.Patrol;
	}

    void Update()
    {
		switch (currentState)
		{
			case (CrawlerState.Patrol):
				break;

			case (CrawlerState.Alert):
				break;

			case (CrawlerState.Hunt):
				break;

			case (CrawlerState.Attack):
				break;

			case (CrawlerState.Stun):
				break;

			default:
				break;
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    private Camera mainCamera;
    private  NavMeshAgent navMeshAgent;

    private void Start()
    {
		mainCamera = Camera.main;
		navMeshAgent = GetComponent<NavMeshAgent>();
	}

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(mainCamera.ScreenPointToRay(Input.mousePosition), out RaycastHit hit))
            {
                navMeshAgent.SetDestination(hit.point);
			}
        }
    }
}

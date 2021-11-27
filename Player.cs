using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
	public List<Transform> destinos;
	private UnityEngine.AI.NavMeshAgent variable;
	
	void Start()
	{
		variable = GetComponent<UnityEngine.AI.NavMeshAgent>();
		SiguienteDestino();
	}

	private void SiguienteDestino()
	{
        Debug.Log(transform.position);
		if(destinos.Count > 0)
		{
			variable.destination = destinos[0].position;
			destinos.RemoveAt(0);
		}
		else
		{
			variable.isStopped = true;
		}
	}

	//Si lo haces con la posicion¿
	private bool EstaEnDestino()
	{
		return transform.position.x == variable.destination.x && transform.position.z == variable.destination.z;
	}

	void Update()
	{
		if(EstaEnDestino())
		{
			SiguienteDestino();
		}
	}
		
}

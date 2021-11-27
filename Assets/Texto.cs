using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Texto : MonoBehaviour
{
    public GameObject finishText;

    void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("Finish")) //Eso del tag lo debes agregar en unity
		{
			finishText.SetActive(true);
		}
	}
}

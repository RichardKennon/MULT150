using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class StationaryDoughnut : MonoBehaviour
{
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			Debug.Log("Doughnut collected!");
			Destroy(gameObject);
		}
	}
}

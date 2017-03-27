using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathMaker : MonoBehaviour {

	public Transform floorPrefab;
	public Transform pathmakerSpherePrefab; 

	List<Transform> pathmakerList = new List<Transform>();

	
	// Update is called once per frame
	void Update ()
	{
		int counter = 0; 

		if (counter < 50) {
			if (Random.Range (0.0f, 1.0f) > 0.0f) {
				if (Random.Range (0.25f, 0.5f) < 0.25f) {
					transform.Rotate (0f, 90f, 0f);
				}
			} else if (Random.Range (0.0f, 1.0f) > 0.25f) {
				if (Random.Range (0.0f, 1.0f) < 0.5f) {
					transform.Rotate (0f, -90f, 0f);
				}
			} else if (Random.Range (0.99f, 1.0f) > 0.99f) {
				Instantiate (pathmakerSpherePrefab, transform.position, Quaternion.identity);
			}
			Instantiate (floorPrefab, transform.position, Quaternion.identity);
			transform.Translate (0f, 5f, 0f);
		}

		counter++; 

	}
}
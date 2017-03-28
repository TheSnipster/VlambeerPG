using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathMaker : MonoBehaviour {

	public Transform floorPrefab;
	public Transform pathmakerSpherePrefab; 



	//List<Transform> pathmakerList = new List<Transform>();

	
	// Update is called once per frame
	void Update ()
	{
		int floorCounter = 0; 

		while (floorCounter < 10) {
			float myRandomNumber = Random.Range (0.0f, 1.0f); 
			if (myRandomNumber < 0.25f) {
				transform.Rotate (0f, 90f, 0f);
			} else if (myRandomNumber >= 0.25f && myRandomNumber < 0.5f) {
				transform.Rotate (0f, -90f, 0f);
			} else if (myRandomNumber >= 0.99f && myRandomNumber < 1.0f) {
				Instantiate (pathmakerSpherePrefab, transform.position, Quaternion.identity);
			}

			Instantiate (floorPrefab, transform.position, Quaternion.identity);
			transform.Translate (0f, 0f, 5f);
			floorCounter++;
		}




	}
}







//			if (Random.Range (0.0f, 1.0f) > 0.0f) {
//				if (Random.Range (0.25f, 0.5f) < 0.25f) {
//					transform.Rotate (0f, 90f, 0f);
//				}
//			} else if (Random.Range (0.0f, 1.0f) > 0.25f) {
//				if (Random.Range (0.0f, 1.0f) < 0.5f) {
//					transform.Rotate (0f, -90f, 0f);
//				}
//			} else if (Random.Range (0.99f, 1.0f) > 0.99f) {
//				Instantiate (pathmakerSpherePrefab, transform.position, Quaternion.identity);
//			}
//			Instantiate (floorPrefab, transform.position, Quaternion.identity);
//			transform.Translate (0f, 5f, 0f);
//		}
//
//		counter++; 


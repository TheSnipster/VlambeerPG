using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PathMaker : MonoBehaviour
{

	public Transform floorPrefab;
	public Transform pathmakerSpherePrefab;
	//public static int globalTileCount = 500; 

	//List<Transform> tileList = new List<Transform> ();
	List<Transform> pathMakerList = new List<Transform> ();

	public GameObject[] tiles;

	
	// Update is called once per frame
	void Update ()
	{
		int floorCounter = 0; 

		if (floorCounter < 500) {
			float myRandomNumber = Random.Range (0.0f, 1.0f); 
			if (myRandomNumber < 0.25f) {
				transform.Rotate (0f, 90f, 0f);
			} else if (myRandomNumber >= 0.25f && myRandomNumber < 0.5f) {
				transform.Rotate (0f, -90f, 0f);
			} else if (myRandomNumber >= 0.99f && myRandomNumber < 1.0f) {
				//Instantiate (pathmakerSpherePrefab, transform.position, Quaternion.identity);
				Transform newMakerClone = (Transform)Instantiate (pathmakerSpherePrefab, transform.position, Quaternion.identity);
				pathMakerList.Add (newMakerClone); //add Maker clone to list
			} else {
				Destroy (this.gameObject);
			}

			Instantiate (tiles[UnityEngine.Random.Range(0,3)], transform.position, Quaternion.identity);

		
			//GameObject newTileClone = (GameObject) Instantiate (tiles[UnityEngine.Random.Range(0,3)], transform.position, Quaternion.identity);
			//Instantiate (floorPrefab, transform.position, Quaternion.identity);
			transform.Translate (0f, 0f, 5f);
			//tileList.Add (newTileClone); //add tile clone to list
			floorCounter++;
		}



	}
}

//
//		foreach (Transform thisTile in tileList) {
//			
//		}
//			



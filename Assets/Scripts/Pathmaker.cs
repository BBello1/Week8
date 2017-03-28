using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pathmaker : MonoBehaviour {

    private int counter = 0;
    public Transform floorPrefab1;
    public Transform floorPrefab2;
    public Transform floorPrefab3;
    public Transform pathmakerSphere;
	
	// Update is called once per frame
	void Update () {
		if(counter < 200)
        {
            float randNum1 = Random.Range(0.0f, 1.0f);
            float randNum2 = Random.Range(0.0f, 1.0f);

            if (randNum1 <0.25f)
            {
                transform.Rotate(0f, 90f, 0f);
                
            } else if(randNum1 >= 0.25f && randNum1 <= 0.5f)
            {
                transform.Rotate(0f, -90f, 0f);
            } else if(randNum1 >= .99f && randNum1 <= 1.0f)
            {
                Instantiate(pathmakerSphere, transform.position, Quaternion.identity);
            }

            if (randNum2 < .33f)
            {
                Instantiate(floorPrefab1, transform.position, Quaternion.identity);
            }
            else if (randNum2 >= .33f && randNum2 <= .66f)
            {
                Instantiate(floorPrefab2, transform.position, Quaternion.identity);
            }
            else if (randNum2 >= .66f && randNum2 <= 1.0f)
            {
                Instantiate(floorPrefab3, transform.position, Quaternion.identity);
            }

            transform.Translate(Vector3.forward * 5f);
            counter++;

            
        } else
        {
            Destroy(this.gameObject);
        }

        
	}
}

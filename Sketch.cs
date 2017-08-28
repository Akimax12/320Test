using UnityEngine;
using System.Collections;

public class Sketch : MonoBehaviour {

    public GameObject myPrefab;
    public GameObject mySphere;

    // Use this for initialization
    void Start() { 
    
        int totalCubes = 30;
        float totalDistance = 2.9f;
             
        //sin distro
        for (int i = 0; i < totalCubes; i++)
        {
          if(i%2 == 0) {  
            float perc = i / (float)totalCubes;
            float sin = Mathf.Sin(perc * Mathf.PI/2);

            float x = 1.8f + sin * totalDistance;
            float y = 5.0f;
            float z = 0.0f;
            
            var newCube = (GameObject)Instantiate(mySphere, new Vector3(x, y, z), Quaternion.identity);
            newCube.GetComponent<SphereSc>().rotateSpeed = .2f + perc*4.0f;
                newCube.GetComponent<ShpereSc>().SetSize(.30f * (1.0f - perc));

            }
            else
            {
                float perc = i / (float)totalCubes;
                float sin = Mathf.Sin(perc * Mathf.PI / 2);

                float x = 1.8f + sin * totalDistance;
                float y = 5.0f;
                float z = 0.0f;

                var newCube = (GameObject)Instantiate(myPrefab, new Vector3(x, y, z), Quaternion.identity);
                newCube.GetComponent<CubeScript>().rotateSpeed = .2f + perc * 4.0f;
                newCube.GetComponent<CubeScript>().SetSize(.30f * (1.0f - perc));

            }
        }
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}

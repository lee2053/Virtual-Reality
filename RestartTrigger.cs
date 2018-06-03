using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartTrigger : MonoBehaviour {
    private Scene scene;

	// Use this for initialization
	void Start () {
        scene = SceneManager.GetActiveScene();

		
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag =="Player")
        {
            SceneManager.LoadScene(scene.name);

        }
        else
        {

        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour {

    public int levelToLoad2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

	}

    public void SceneChanger()
    {

    SceneManager.LoadScene(levelToLoad2);
       } 
}

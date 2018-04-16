using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class MainMenuScript : VRTK_InteractableObject
{

	// Use this for initialization
	void Start () {
        GetComponent<VRTK_ControllerEvents>().GripPressed += new ControllerInteractionEventHandler(DoGripPressed);
        GetComponent<VRTK_ControllerEvents>().ButtonTwoPressed += new ControllerInteractionEventHandler(DoButtonTwoPressed);
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    private void DoGripPressed(object sender, ControllerInteractionEventArgs e)
    {
        Debug.Log("grippressed");
    }


    private void DoButtonTwoPressed(object sender, ControllerInteractionEventArgs e)
    {
        Debug.Log("button2 pressed");
    }


}

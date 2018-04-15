using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class CustomInteractions : VRTK_InteractableObject
{
    public GameObject canvaS;

    public override void StartUsing(VRTK_InteractUse usingObject)
    {
        base.StartUsing(usingObject);
        Debug.Log("esta usado");
        canvaS.SetActive(true);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

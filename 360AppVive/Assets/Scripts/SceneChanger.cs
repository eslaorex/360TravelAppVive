using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
using UnityEngine.SceneManagement;

public class SceneChanger : VRTK_InteractableObject
{
    public GameObject sceneCave01;
    public VRTK_ControllerEvents vRTK_ControllerEvents;
    private bool sceneCaveLaberintEnter;
    public int levelToLoad2;

    private void Start()
    {

        vRTK_ControllerEvents.TriggerPressed += new ControllerInteractionEventHandler(DoTriggerPressed);
    }

    private void DoTriggerPressed(object sender, ControllerInteractionEventArgs e)
    {
        if (sceneCaveLaberintEnter)
        {
            SceneManager.LoadScene(levelToLoad2);
        }

    }

    public override void StartUsing(VRTK_InteractUse usingObject)
    {

        base.StartUsing(usingObject);
        {
            if (!sceneCave01.activeInHierarchy)
            {
                sceneCave01.SetActive(true);
                sceneCaveLaberintEnter = true;

            }
        }
    }
    public override void StopUsing(VRTK_InteractUse usingObject)
    {

        base.StopUsing(usingObject);
        {
            if (sceneCave01.activeInHierarchy)
            {
                sceneCave01.SetActive(false);
                sceneCaveLaberintEnter = false;

            }
        }
    }


}

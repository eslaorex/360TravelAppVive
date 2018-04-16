using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingMaterials : MonoBehaviour {
    public GameObject TravelRoom;
    public GameObject TravelRoomEnviroment;
    public List<GameObject> TravelRoomControls;

    

    public GameObject Sphere360;
    public List<Texture> Textures;

    public GameObject btnExit;
    public List<GameObject> SphereControls; 

    public void goToSkyBox (int skybox)
    {
        Sphere360.GetComponent<Renderer> ().material.mainTexture = Textures[skybox];
        UpdateTravelControls(false);
        TravelRoomEnviroment.SetActive(false);

       // StartCoroutine (DissolveRoom(0, 1.5f));
    }
    /*
    IEnumerator DissolveRoom (float fromValue, float toValue)
    {
        for ( float t = 0f; t<1.5f; t+= Time.deltaTime / 2 )
        {
            TravelRoomEnviroment.GetComponent<Renderer>().material.SetFloat("_DissolveIntensity", Mathf.Lerp(fromValue, toValue, t));
            yield return null;
        }
        if (toValue <0)
        {
            UpdateTravelControls (true);
        }
    }
    */

   

    public void goToTravelRoom (bool active)
    {
        UpdateTravelControls(true);
        TravelRoomEnviroment.SetActive(true);
        
    }

    void UpdateTravelControls(bool active)
    {
        foreach (GameObject obj in TravelRoomControls)
        {
            obj.SetActive(active);
        }
    }

    

}

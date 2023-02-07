using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseMyScriptableObject : MonoBehaviour
{   

    public MyScriptableObjectClass myScriptableObject;

    private List<Light> myLights;

    // Start is called before the first frame update
    void Start()
    {
        myLights = new List<Light>();
        foreach (Vector3 spawn in myScriptableObject.spawnPoints)
        {
            GameObject myLight = new GameObject("Light");
            myLight.AddComponent <Light>();
            myLight.transform.position = spawn;
            myLight.GetComponent<Light>().enabled = false;
            if (myScriptableObject.colorIsRandom)
            {
                myLight.GetComponent<Light>().color = new Color (Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0f,1f));
            }
            else
            {
                myLight.GetComponent<Light>().color = myScriptableObject.thisColor;
            }
            myLights.Add(myLight.GetComponent<Light>());
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            foreach(Light light in myLights)
            {
                light.enabled = !light.enabled;
            }
        }
        if (Input.GetButtonDown("Fire2"))
        {
            UpdateLights();
        }
    }

    public void UpdateLights()
    {
        foreach(var myLight in myLights)
        {
            myLight.color = new Color (Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0f,1f));
        }
    }
}

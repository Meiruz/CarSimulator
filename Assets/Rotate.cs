using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform element;
    public float speed;
    Light[] lights;
    public bool isSun = false;
    private bool isLight = true;
    public GameObject[] pointLights;


    void Start()
    {
        pointLights = GameObject.FindGameObjectsWithTag("Lights");
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(element.transform.position, Vector3.right, speed*Time.deltaTime);

        if (isSun)
        {

            if (element.transform.rotation.x > 0)
            {
                if (element.transform.rotation.x > 0.7)
                {
                    if (!isLight)
                    {
                        onLights();
                        isLight = true;
                    }
                }
                else
                {
                    if (isLight)
                    {
                        offLights();
                        isLight = false;
                    }
                }
            }
            else
            {
                if (element.transform.rotation.x < -0.7)
                {
                    if (!isLight)
                    {
                        onLights();
                        isLight = true;
                    }
                }
                else
                {
                    if (isLight)
                    {
                        offLights();
                        isLight = false;
                    }
                }
            }
        }
    }
    private void onLights()
    {
        foreach (GameObject light in pointLights)
        {
            var lightSettings = light.GetComponent<Light>();
            lightSettings.intensity = 3;
        }

    }

    private void offLights()
    {
        foreach (GameObject light in pointLights)
        {
            var lightSettings = light.GetComponent<Light>();
            lightSettings.intensity = 0;
        }
    }
}
    
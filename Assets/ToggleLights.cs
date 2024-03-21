using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ToggleLights : MonoBehaviour
{
    public InputActionProperty ToggleBtn;
    public GameObject light1, light2;
    bool touched = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (ToggleBtn.action.ReadValue<float>() == 1)
        {
            if (!touched)
            {
                touched = true;
                var leftCarLightSettings = light1.GetComponent<Light>();
                var rightCarLightSettings = light2.GetComponent<Light>();
                if (leftCarLightSettings.intensity == 0)
                {
                    leftCarLightSettings.intensity = 8.5f;
                    rightCarLightSettings.intensity = 8.5f;
                }
                else
                {
                    leftCarLightSettings.intensity = 0f;
                    rightCarLightSettings.intensity = 0f;
                }
            } 
            
        }

        if (ToggleBtn.action.ReadValue<float>() == 0)
        {
            touched = false;
        }
    }
}

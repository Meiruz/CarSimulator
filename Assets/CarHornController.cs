using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CarHornController : MonoBehaviour
{
    public GameObject carHorn;
    public InputActionProperty ToggleBtn;

    private void FixedUpdate()
    {
        if (ToggleBtn.action.ReadValue<float>() == 1)
        {
            var carAudioHorn = carHorn.GetComponent<AudioSource>();
            carAudioHorn.mute = false;
            Debug.Log("Off");
        }
        else
        {
            var carAudioHorn = carHorn.GetComponent<AudioSource>();
            carAudioHorn.mute = true;
            Debug.Log("Off");
        }
    }
}


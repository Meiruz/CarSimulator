using System;
using System.Timers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Door : MonoBehaviour
{
    
    [SerializeField] private InputActionProperty buttonRight;
    [SerializeField] private GameObject User;
    [SerializeField] private Transform Car;
    [SerializeField] private GameObject Seets;
    bool inCar = false;
    public GameObject DoorCoords;

    private void OnTriggerStay(Collider other)
    {
        Debug.Log(1);

        if (!inCar)
        {
            if (buttonRight.action.ReadValue<float>() == 1)
            {
                Vector3 coords;
                coords = Seets.transform.position;
                coords.y = -0.4f;
                User.transform.position = coords;
                User.transform.SetParent(Car, true);
                inCar = true;
            }
        }
        else
        {
            if (buttonRight.action.ReadValue<float>() == 1)
            {
                Vector3 coords;
                coords = DoorCoords.transform.position;
                User.transform.position = coords;
                User.transform.SetParent(Car, false);
                inCar = false;
            }
        }
        
    }


}

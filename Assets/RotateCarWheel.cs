using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;
using UnityEngine.XR.Interaction;
using UnityEngine.XR.Interaction.Toolkit;

public class RotateCarWheel : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform carWheel;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(carWheel.rotation.x);
    }


}

using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using static OVRInput;

public class NewBehaviourScript : MonoBehaviour
{
    public float horizontal;
    public float vertical;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        horizontal = OVRInput.Get(Axis2D.PrimaryThumbstick).x;
        vertical = OVRInput.Get(Axis2D.PrimaryThumbstick).y;

        transform.Translate(horizontal, 0, vertical);
        

        
    }
}

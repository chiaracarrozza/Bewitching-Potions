using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikeball : MonoBehaviour
{
    [SerializeField]  float rotationspeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, rotationspeed); //making the obstacle rotate at a certain speed
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
    
{
    [SerializeField] GameObject ObjecttoFollow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = ObjecttoFollow.transform.position + new Vector3(0, 0, -10); //to make the camera follow the player
        
    }
}

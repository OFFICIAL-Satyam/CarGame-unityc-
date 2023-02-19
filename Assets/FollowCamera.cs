using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    
   [SerializeField] GameObject thingstoFollow;
    
    void LateUpdate()
    {
        transform.position = thingstoFollow.transform.position + new Vector3 (0,0,-10);
    }
}

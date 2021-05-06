using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject player;
    private Vector3 targetPosition;

    public float speed = 0.125f;
   void Start(){
       player = new GameObject("Default Camera Holder");
   }

    void LateUpdate()
    {       
            targetPosition = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
            transform.position = Vector3.Lerp(transform.position, targetPosition, speed);
        
    }
}

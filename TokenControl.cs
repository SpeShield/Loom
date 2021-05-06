using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TokenControl : MonoBehaviour
{

    public Camera mainCamera;
    private Vector3 targetPosition;
 
    public bool selected = false;
    //When hearing an OnMove command
    void OnMove(InputValue value){
        if(selected){
            var inputDirection = value.Get<Vector2>();
            transform.position = new Vector2(transform.position.x+inputDirection.x,transform.position.y+inputDirection.y);
        }
            
    }

public void Change(GameObject player){
        Debug.Log(player.name);
        Debug.Log(gameObject.name);
        if(player.name == gameObject.name){
            selected = true;
        }else{
            selected = false;
        }
    }
    
   
}

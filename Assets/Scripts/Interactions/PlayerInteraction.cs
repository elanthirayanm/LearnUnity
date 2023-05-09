using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;



public class PlayerInteraction : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        LearnUnity learnUnity=new LearnUnity();
        learnUnity.Enable();
        learnUnity.Player.Move.performed += Move;
        learnUnity.Player.Fire.performed += Fire;
    }

    private void Fire(InputAction.CallbackContext context)
    {
        Debug.Log("Fired");
    }

    public void Move(InputAction.CallbackContext context){
        Debug.Log(context.ReadValue<Vector2>());
    }

}

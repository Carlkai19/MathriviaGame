using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ButtonInteractable : MonoBehaviour
{
    //public KeyCode InteractKey;
    public InputAction EAction;
    // Update is called once per frame

    private void OnEnable()
    {
        EAction.Enable();

        EAction.performed += _ => PerformAction();
    }
    private void OnDisable()
    {
        EAction.Disable();

        EAction.performed -= _ => PerformAction();
    }

    void PerformAction()
    {
        Input.GetKeyDown(KeyCode.E);
        
            
    }
    public void OnClick()
    {
        PerformAction();
    }
    
}

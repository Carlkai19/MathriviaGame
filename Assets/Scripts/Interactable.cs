using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class Interactable : MonoBehaviour
{
    public bool isInRange;
    public UnityEvent interactAction;

    void Update()
    {
        if (isInRange && Keyboard.current.eKey.wasPressedThisFrame) // Using the new Input System to check for the 'E' key press
        {
            Interact();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            Debug.Log("Player can interact!");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = false;
            Debug.Log("Player can't interact!");
        }
    }

    // This method gets called both by pressing 'E' and by UI button click
    public void Interact()
    {
        if (isInRange)
        {
            interactAction.Invoke(); // Trigger the interaction
        }
    }
}

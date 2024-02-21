using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestKeyDropForPlayer : MonoBehaviour
{
    public int keyCount;

        public void PickUpKey()
    {
        keyCount++;
        Debug.Log("got a key!");
    }
    public void UseKey()
    {
        keyCount--;
        Debug.Log("key has been used ");
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInractableForItem : MonoBehaviour
{

    //THIS CODE IS TO TEST WHEN PLAYER PRESSES E TO AN INTERACTABLE 


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void TestText()
    {
        Debug.Log("omg I think it works!");
    }

    public void DestroyThisGameObject(GameObject obj)
    {
        TestKeyDropForPlayer manager = obj.GetComponent<TestKeyDropForPlayer>();
        if (manager)
        {
            if (manager.keyCount > 0)
            {
                Destroy(gameObject);
                manager.UseKey();
            }
        }
    }
}

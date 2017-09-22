using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C : MonoBehaviour {

    // Use this for initialization
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MyEvents.EventA.Fire("Hello from Object C!");
        }
    }


}

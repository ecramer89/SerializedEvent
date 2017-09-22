using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class B : MonoBehaviour {

	// Use this for initialization
	void Start () {
        MyEvents.EventA.Subscribe((string arg) =>
        {
            Debug.Log("Object B received word of event A "+arg);
            MyEvents.EventB.Fire("Hello from Object B", 10);
        }
      );
        MyEvents.EventB.Subscribe((string arg0, int arg1) => {
            Debug.Log("Object B received word of event B: "+arg0);
        });
	}
	
}

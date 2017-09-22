using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyEvents : MonoBehaviour  {

    public static UnaryParameterizedEvent<string> EventA = new UnaryParameterizedEvent<string>("EventA");
    public static BinaryParameterizedEvent<string, int> EventB = new BinaryParameterizedEvent<string, int>("EventB");
}

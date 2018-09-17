﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMono : MonoBehaviour {
    
    public int TestField = 1;
    private int TestFieldPrivate = 2;

    public int TestProp { get; set; }
    public int TestPropGet { get { return -1; } }

    public void TestFunc() { Debug.Log("Wow!"); }
    public void TestFuncPrivate() { Debug.Log("Wow private!"); }

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }
}
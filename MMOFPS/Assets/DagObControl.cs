using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DagObControl:MonoBehaviour
{
    private Vector2 screenPoint; // 存储物体在屏幕上的位置

    private void Start()
    {
        Debug.Log("5");
        screenPoint.x = 1;
        screenPoint.y=0;
        this.transform.position = screenPoint; // 更新物体的位置
    }
    private void Update()
    {
        
        
    }
}
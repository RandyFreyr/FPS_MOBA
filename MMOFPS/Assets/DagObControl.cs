using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DagObControl:MonoBehaviour
{
    private Vector2 screenPoint; // �洢��������Ļ�ϵ�λ��

    private void Start()
    {
        Debug.Log("5");
        screenPoint.x = 1;
        screenPoint.y=0;
        this.transform.position = screenPoint; // ���������λ��
    }
    private void Update()
    {
        
        
    }
}
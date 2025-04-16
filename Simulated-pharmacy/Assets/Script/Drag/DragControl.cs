using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragControl : MonoBehaviour
{
    //���ƫ��������걣����ק

    private Vector3 offset;
    private bool isDragging = false;
    //current mouseposition and last mouseposition
    private Vector3 prevMousePos;
    private Vector3 curMousePos;
    private Vector3 deltaMousePos;
    private Vector3 player_postion;
    
    private void Start()
    {
        //�ű���������λ��
        player_postion = this.GetComponent<Transform>().position;
        prevMousePos = Input.mousePosition;
    }
    
    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            isDragging = true;
            ItemMove();

        }

        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("failed");
            isDragging = false;
        }

        //ÿһ֡���δ֪��Ϊ��һ�����λ��
         prevMousePos= Input.mousePosition;
    }
    public void ItemMove()
    {
        deltaMousePos = Input.mousePosition - prevMousePos;
        Debug.Log(deltaMousePos.x);
        this.GetComponent<Transform>().position += deltaMousePos;
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragControl : MonoBehaviour
{
    //鼠标偏移量，鼠标保持拖拽

    private Vector3 offset;
    private bool isDragging = false;
    //current mouseposition and last mouseposition
    private Vector3 prevMousePos;
    private Vector3 curMousePos;
    private Vector3 deltaMousePos;
    private Vector3 player_postion;
    
    private void Start()
    {
        //脚本挂载物体位置
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

        //每一帧鼠标未知作为上一个鼠标位置
         prevMousePos= Input.mousePosition;
    }
    public void ItemMove()
    {
        deltaMousePos = Input.mousePosition - prevMousePos;
        Debug.Log(deltaMousePos.x);
        this.GetComponent<Transform>().position += deltaMousePos;
    }
}


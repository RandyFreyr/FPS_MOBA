using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragControl : MonoBehaviour
{
    private Vector3 offset;
    private bool isDragging = false;
    private Vector3 player_postion;
    private void Start()
    {
        player_postion = this.GetComponent<Transform>().position;
    }
    void Update()
    {

        if (Input.GetMouseButton(0) && isDragging)
        {

            Vector3 curPosition = player_postion + Input.mousePosition;
            this.transform.position = curPosition;
        }

        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("failed");
            isDragging = false;
            //事件和委托，跳转到锅炉/初始位置，但是会更新
        }
    }
    void IsDraggingJudge()
    {
        isDragging= true;
    }
}


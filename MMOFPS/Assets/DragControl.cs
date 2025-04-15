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
            //�¼���ί�У���ת����¯/��ʼλ�ã����ǻ����
        }
    }
    void IsDraggingJudge()
    {
        isDragging= true;
    }
}


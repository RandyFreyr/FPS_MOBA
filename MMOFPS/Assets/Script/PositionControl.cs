using UnityEngine;

[System.Serializable]
public class PositionControl:MonoBehaviour
{
    private int id; // �������
    private Vector2 initialPosition; // ��ʼλ��
    private Vector2 finalPosition;
    public Vector2 curMousePosition;

    private void Start()
    {
        //�ӿ�ά�������ݽṹ��ȡ��ǰ��Ϸ�����Ӧ�ĳ�ʼλ��
        //initialPosition=
        finalPosition = initialPosition;
    }
    void Update()
    {
        
    }
}
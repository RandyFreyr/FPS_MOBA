using UnityEngine;

[System.Serializable]
public class PositionControl:MonoBehaviour
{
    private int id; // 物体序号
    private Vector2 initialPosition; // 初始位置
    private Vector2 finalPosition;
    public Vector2 curMousePosition;

    private void Start()
    {
        //从可维护的数据结构获取当前游戏物体对应的初始位置
        //initialPosition=
        finalPosition = initialPosition;
    }
    void Update()
    {
        
    }
}
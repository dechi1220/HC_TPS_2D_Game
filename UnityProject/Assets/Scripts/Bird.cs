using UnityEngine;

public class Bird : MonoBehaviour
{
    //跳越高度，是否死亡
    [Header("跳越高度"),Range(10,2000)]
    public int jump = 100;
    [Header("死了沒"), Tooltip("ture 死亡, false 還沒死")]
    public bool dead ;



}

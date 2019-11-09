using UnityEngine;

public class Bird : MonoBehaviour
{
    //跳越高度，是否死亡
    [Header("跳越高度"),Range(10,2000)]
    public int jump = 100;
    [Header("死了沒"), Tooltip("ture 死亡, false 還沒死")]
    public bool dead ;

    /// <summary>
    /// 定義小雞跳躍
    /// </summary>
    private void Jump()
    {
    
    }

    /// <summary>
    /// 定義小雞死亡
    /// </summary>
    private void Dead()
    {

    }

}

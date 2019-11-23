using UnityEngine;

public class Bird : MonoBehaviour
{
    //跳越高度，是否死亡
    [Header("跳越高度"),Range(10,2000)]
    public int jump = 100;
    [Header("旋轉角度"), Range(0, 100)]
    public float angle = 10;

    [Header("死了沒"), Tooltip("ture 死亡, false 還沒死")]
    public bool dead ;
    [Header("剛體")]
    public Rigidbody2D r2d;

    public GameObject goScore, goGM;


    /// <summary>
    /// 定義小雞跳躍
    /// </summary>
    private void Jump( )
    {
        // 如果 死亡 跳出此程式區塊 
        if (dead == true) 
        {
            return; // return= 跳過大括號裡寫的，不要執行
        }
        //簡寫: if(dead) retrun;

        //如果 玩家 按下 左鍵
        // 輸入. 按下左鍵(案件列舉.滑鼠左鍵)(手機觸控)
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            print("玩家按下左鍵");
            r2d.Sleep();                                                      //小雞剛體.睡著( ) - 重設剛體所有資訊
            r2d.gravityScale = 2;                                   //小雞剛體.重力 = 1;   //小雞 往上跳
            r2d.AddForce(new Vector2(0, jump));  //小雞剛體.增加推力(二為向量(左右，上下));

            goScore.SetActive(true);                          // 分數顯示
            goGM.SetActive(true);                             // GM 顯示
        }

        // Rigidbody2D.SetRotation(float)設定角度(角度)
        // Rigidbody2D.velocity 加速度(二為向量 x,y)
        r2d.SetRotation(angle * r2d.velocity.y);

    }

    /// <summary>
    /// 定義小雞死亡
    /// </summary>
    private void Dead()
    {
        print("死ㄌ!!!!!");
        dead = true;
    }
    

    //固定幀數 0.002 一幀：要控制物理請寫在此事件內
    private void FixedUpdate()

    {
        Jump( );

    }

    
    // 事件:碰撞開始 - 碰撞開始實執行一次 (Collision2D collision)(碰撞類別 名稱) 存放碰到物件的資訊
    private void OnCollisionEnter2D(Collision2D hit)
    {
        // 碰到物件.遊戲物件.名稱
        print(hit.gameObject.name);   
        
        if(hit.gameObject.name == "地板")
        {
            Dead();
        }

    }
}

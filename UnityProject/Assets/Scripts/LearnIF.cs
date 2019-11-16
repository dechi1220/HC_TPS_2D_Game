using UnityEngine;

public class LearnIF : MonoBehaviour
{
    public bool test;
    public string prop;
    public float hp = 100;

    // 更新事件:一秒執行60次
    private void Update()
    {
        #region 練習 if
        // 判斷式 if 與法
        // if (布林植) {陳述式或演算法}
        // () 裡面的布林值為 true 才會執行 if { }
        if (true)
        {
            print("打開開關~~~");
        
        }

        // () 裡面的布林值為 false 才會執行 else {}
        else
        {
            print("關閉開關~");
        }

        if (prop == "紅色藥水")
        {
            print("補血");
        }
else if (prop == "藍色藥水")
        {
            print("補魔力");
        }

        else if(prop == "黃色藥水")
        {
            print("補體力");
                }
        else
        {
            print("沒發生任何事~");
        }  
        #endregion
   
  if  (hp>=70)
	{
           print("安全") ;
	}

        else if (hp >=50)
        {
            print("警告!");
        }
else
{
print("快死了!!!");
}
  
     }



}

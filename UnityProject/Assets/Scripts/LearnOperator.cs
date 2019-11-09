using UnityEngine;

public class LearnOperator : MonoBehaviour
{
    public int a = 10, b=3, c=10, d=10;
    public int score = 50;
    public int num1 = 90, num2 =10 ;
    public bool boolA = true, boolB = false;
    public int hp = 100;
    public int prop = 10;

    private void Start()
    {

        #region 程式運算子區域
   
    
        // 數學運算子
        print(a + b);  // 加法13
        print(a - b);  // 減法7
        print(a * b);  // 承30
        print(a / b);  // 除3
        print(a % b);  // 餘數10/3=3...1

      //遞增 ++、遞減 --
        print(c++); // 先輸出再執行遞增
        print(++d); // 先執行遞增再輸出

        // 指定運算:等號右邊會先運算再傳給左邊
        // = 等號是指定的意思
        
        score = score + 10;
        //上面那行的簡寫
        score += 10;
        #endregion
        #region 比較運算子
        // 比較運算子 (結果為布林值)
        print(num1 > num2);
        print(num1 < num2);
        print(num1 >= num2);
        print(num1 <= num2);
        print(num1 == num2); //等於
        print(num1 != num2); //不等於
        #endregion

    
        // 邏輯運算子
        // 並且 &&

        print(boolA && boolB); // 只要有一個 false 結果為false
        print(true && true); //t
        print(true && false); //f
        print(false && true); //f
        print(false && false); //f

        //或者 ||
        print(boolA || boolB); //只要有一個true 結果為true
        print(true || true); //t
        print(true || false); //t
        print(false || true); //t
        print(false || false); //f
        //(範例) 過關條件:HP>50 並且 道具>7
        print(hp < 50 && prop > 7);

        //相反
        print(!true); //f
        print(!false); //t
    }
}

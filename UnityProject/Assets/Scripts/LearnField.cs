using UnityEngine;

public class LearnField : MonoBehaviour
{
    // 定義欄位 Field
    // 語法 : 修飾詞 欄位類型 欄位名稱 (指定 值:不一定要寫~) 結束
    // 修飾詞意義: 1私人:隱藏 private (預設) 2.公開 :顯示 public
    // 整數 int       ex 0, 1, 999, -100
    // 浮點數 float    ex 1.5
    // 字串 string    ex 藥水、鞋子
    // 布林值 bool     ex true、false

        [Header("角色等級"),Range(1,9999)]
    public int lv = 1;
[Tooltip("角色的移動速度不要調太高~")]
[Range(0.1f,99.9f)]
    public float speed = 1.5f;
    public string prop1 = "紅色藥水";
    public bool mission = true;

}

using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 目前分數，最高分數
    [Header("目前分數")]
    public int score;

    [Header("最高分數")]
    public int scoreHeight;

    // 修飾詞全限:
    // private  其他類別無法使用
    // 其他類別可以使用

    /// <summary>
    /// 定義加分
    /// </summary>
    public void AddScore()
    {

    }

    /// <summary>
    /// 定義最高分數判定
    /// </summary>
    private void BestScore()
    {

    }

    /// <summary>
    /// 定義生成水管
    /// </summary>
    private void SpawnPipe()
    {

    }

    /// <summary>
    /// 定義遊戲失敗
    /// </summary>
    public void GameOver()
    {

    }
}

using UnityEngine;

public class GameManager : MonoBehaviour
{
    // 目前分數，最高分數
    [Header("目前分數")]
    public int score;

    [Header("最高分數")]
    public int scoreHeight;

    [Header("水管")]
    // GameObject 可以存放場景上的遊戲物件與專案內的預製物(prefab)

    public GameObject pipe;

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
        print("生水管");
        // 生成(物件)  ，Object 可省略
        //  Object.Instantiate(pipe);

        //生成(物件，座標，角度)
       float y = Random.Range(-1f, 1.2f);
        //區域欄位(不需要修飾詞public)
        Vector3 pos = new Vector3(0, y, 0);



        //Quaternion.identity 代表零角度 (0,0,0,0)
        Instantiate(pipe, pos, Quaternion.identity);
    }

    /// <summary>
    /// 定義遊戲失敗
    /// </summary>
    public void GameOver()
    {



   }
    private void Start()
    {
        // 重複調用("方法名稱",開始時間,間隔時間)
        InvokeRepeating("SpawnPipe", 0, 1.5f);
    }
}

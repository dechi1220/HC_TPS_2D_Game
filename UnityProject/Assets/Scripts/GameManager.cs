using UnityEngine;
using UnityEngine.UI; //引用 介面 API
using UnityEngine.SceneManagement; //引用  場景管理API

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

    [Header("遊戲結算畫面")]
    public GameObject goFinal;
    [Header("分數介面")]
     public Text textScore;
    public Text textBest;

    // static 不會顯示在Unity裡的屬性 Inspector面板上，就算有public也不會~
    public static bool gameOver;

  


    // 修飾詞全限:
    // private  其他類別無法使用
    // 其他類別可以使用

    /// <summary>
    /// 定義加分
    /// </summary>
    public void AddScore()
    {
        print("++~!");
        score++;
        //分數介面.文字內容 = 分數.轉為字串()
        // ToString() 可以將任何類型轉為字串
        textScore.text = score.ToString();

        //呼叫最佳分數判定
        HeightScore();
    }

    /// <summary>
    /// 定義最高分數判定
    /// </summary>
    private void HeightScore()
    {
        // 如果 目前分數 > 最佳分數
        if ( score > PlayerPrefs.GetInt("最佳分數") )
        {
            //玩家資料.設定整數("最佳分數"，目前分數)
            PlayerPrefs.SetInt("最佳分數", score);
        }
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
        Vector3 pos = new Vector3(10, y, 0);



        //Quaternion.identity 代表零角度 (0,0,0,0)
        Instantiate(pipe, pos, Quaternion.identity);
    }

    /// <summary>
    /// 定義遊戲失敗
    /// </summary>
    public void GameOver()
    {
        goFinal.SetActive(true); //顯示結算畫面
        gameOver = true; // 遊戲結束 = 是
        CancelInvoke("SpawnPipe");  //停止 InvokeReapeating、Invoke的方法


   }


    // 要給UI按鈕呼叫的方法必須是public 
    /// <summary>
    /// 重新遊戲
    /// </summary>
    public void Replay ()
    {
       // Application.LoadLevel("遊戲場景");  //應用程式.載入場景("場景名稱") 舊版ㄉAPI!!
        SceneManager.LoadScene("遊戲場景"); //場景管理器.載入場景("場景名稱") ; 新版API 記得在最上面引用場景API~

    }

    /// <summary>
    /// 離開遊戲
    /// </summary>
    public void Quit()
    {
        Application.Quit(); //使用 應用程式 離開( );

    }


    //遊戲開始與載入場景會執行一次
    private void Start()
    {
        //螢幕.設定解析度(寬,高,是否全螢幕)
        Screen.SetResolution(450, 800, false);

        //靜態成員在載入場景都不會還原
        gameOver = false;

        // 重複調用("方法名稱",開始時間,間隔時間)
        InvokeRepeating("SpawnPipe", 0, 1.5f);

        textBest.text = PlayerPrefs.GetInt("最佳分數").ToString( ) ;


    }
}

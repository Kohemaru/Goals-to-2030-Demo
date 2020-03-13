using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//for Title scene
public class GameSystem : MonoBehaviour
{
    private static int stage = 0;//ステージ選択のための変数

    public static int getStage() //他のシーンから読み取るためのget関数
    {
        return stage;
    }

    void Start()
    {
        //ポーズやゴールした後にタイトルに飛んだときシーンのスリープを解除
        Screen.sleepTimeout = SleepTimeout.SystemSetting;
    }
    //　スタートボタンを押してプレイ画面に遷移
    public void StartGame()
    {
        // this.stage =　selectStage;　// ステージの数字を設定
        SceneManager.LoadScene("Playing-demo");
    }

}
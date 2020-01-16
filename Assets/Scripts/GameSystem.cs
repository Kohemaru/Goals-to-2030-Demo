using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSystem : MonoBehaviour
{
    private static int stage = 0;
    public static int getStage()
    {
        return stage;
    }

    void Start()
    {
        Screen.sleepTimeout = SleepTimeout.SystemSetting;
    }
    //　スタートボタンを押したら実行する
    public void StartGame()
    {
        // this.stage =　stagelist;
        SceneManager.LoadScene("Playing-demo");
    }

}
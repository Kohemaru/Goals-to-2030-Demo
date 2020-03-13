using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// プレイ画面のポーズ時やゴール後のメニューのそれぞれの処理
public class PourseManager : MonoBehaviour
{

    public GameObject PourseBotton;
    public GameObject PoursePanel;
    public GameObject Player;
    public GameObject StartPos;

    // Start is called before the first frame update
    void Start()
    {
        Player.transform.position = StartPos.transform.position;
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }

    // Update is called once per frame
    void Update()
    {

    }

//ポーズの機能（時間を止めポーズメニューの表示）
    public void OnClickPourse()
    {
        Time.timeScale = 0f;
        PourseBotton.SetActive(false);
        PoursePanel.SetActive(true);
    }

//　ポーズを解除
    public void OnClickResume()
    {
        Time.timeScale = 1f;
        PourseBotton.SetActive(true);
        PoursePanel.SetActive(false);
    }

//プレイヤー（ボール）を初期位置に移動
    public void OnClickRestart()
    {
        Player.transform.position = StartPos.transform.position;
    }

//プレイを初期化（アイテムの獲得など）
    public void OnClickRestart2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Playing-demo");
    }

//タイトルシーンに遷移
    public void OnClickToTitle()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Title-demo");
    }
}

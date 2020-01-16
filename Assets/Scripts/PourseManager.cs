using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public void OnClickPourse()
    {
        Time.timeScale = 0f;
        PourseBotton.SetActive(false);
        PoursePanel.SetActive(true);
    }

    public void OnClickResume()
    {
        Time.timeScale = 1f;
        PourseBotton.SetActive(true);
        PoursePanel.SetActive(false);
    }

    public void OnClickRestart()
    {
        Player.transform.position = StartPos.transform.position;
    }

    public void OnClickRestart2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Playing-demo");
    }


    public void OnClickToTitle()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Title-demo");
    }
}

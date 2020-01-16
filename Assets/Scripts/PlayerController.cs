using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Threading.Tasks;

public class PlayerController : MonoBehaviour {
    public GameObject PourseBotton;
    public GameObject GoalPanel;
    public int g_c;
    private int count;

    void Start ()
    {
    }

    void FixedUpdate ()
    {
    }

    async void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ("Pick up"))
        {
            other.gameObject.SetActive (false);
            count = count + 1;
        }
        if(other.gameObject.tag == "Start")
        {
        }
        if(other.gameObject.tag == "Goal")
        {
            if(count > g_c){
                await Task.Delay(500);
                Time.timeScale = 0f;
                PourseBotton.SetActive(false);
                GoalPanel.SetActive(true);}
        }
    }

}
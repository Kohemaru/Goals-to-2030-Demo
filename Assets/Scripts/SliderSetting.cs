using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderSetting : MonoBehaviour
{
    Slider slider;
    public Text sensNum;
    
	private static float sens = 60;

    public static float getSens(){
		return sens;
	}

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        slider.value = sens; 
        sensNum.text = sens.ToString("#.#");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sensSetting()
    {
        sens = slider.value;
        sensNum.text = sens.ToString("#.#");
        
    }
}

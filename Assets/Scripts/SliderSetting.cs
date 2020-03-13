using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//タイトル画面とボーズメニューの感度調整スライダーの実装
public class SliderSetting : MonoBehaviour
{
    Slider slider;
    public Text sensNum;
    
	private static float sens = 60;

    public static float getSens(){
		return sens;
	}

    // Start is called before the first frame update
    //スタイダーの設定の初期化
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

//スライダーを動かしたときの値の設定と表示のために値を整える
    public void sensSetting()
    {
        sens = slider.value;
        sensNum.text = sens.ToString("#.#");
        
    }
}

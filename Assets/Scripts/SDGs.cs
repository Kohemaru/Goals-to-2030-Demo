using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SDGs : MonoBehaviour
{
    public GameObject SDGsn;
    public GameObject SDGsContentsList;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
//　対応したアイテムを取得したときに対応したオブジェクトを表示
    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ("Player"))
        {
            SDGsn.SetActive(true);

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI_Item : MonoBehaviour
{
    Text T;
    // Start is called before the first frame update
    void Start()
    {
        T = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        T.text = "Item :"+item_info.Item;
    }
}
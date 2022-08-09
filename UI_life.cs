using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI_life : MonoBehaviour
{
    // Start is called before the first frame update
 Text T;
    // Start is called before the first frame update
    void Start()
    {
        T = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        T.text = "Life "+item_info.Life;
    }
}

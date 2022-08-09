using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Score : MonoBehaviour
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
        T.text = "Score "+item_info.Score;
    }
}

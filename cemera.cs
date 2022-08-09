using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cemera : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Hero;
     Transform Trans;
    // Start is called before the first frame update+
    void Start()
    {
        Trans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Trans.position = new Vector3 (Hero.position.x, 0,-10);
    }
}

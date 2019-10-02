using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour
{
    Text scorelabel;

    // Start is called before the first frame update
    // Start is called before the first frame update
    void Start()
    {
        scorelabel = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scorelabel.text = "score: " + Mathf.Ceil(timer.Timee).ToString();

    }
}

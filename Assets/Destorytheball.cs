using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Destorytheball : MonoBehaviour
{

    public float DestoryTime = 5.0f;
    

    // Start is called before the first frame update
    void Start()
    {
       Destroy(gameObject, DestoryTime);
    }


    // Update is called once per frame
    void Update()
    {
      
    }
}

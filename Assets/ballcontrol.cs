using UnityEngine;


public class ballcontrol : MonoBehaviour
{
    public GameObject BallPrefab;
    float span = 1.0f;
    float delta = 0;

    public void Setparameter (float span)
    {
      this.span = span;
    }

    // Update is called once per frame
    void Update()
    {
        
        this.delta += Time.deltaTime;
        if(this.delta>span)
        {
            this.delta = 0;
            GameObject item;
            item = Instantiate(BallPrefab) as GameObject;
            float x = Random.Range(-13, 11);
            float z = Random.Range(6, 17);
            item.transform.position = new Vector3(x, 26, z);
        }
        

    }
}

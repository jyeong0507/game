using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class plyercontrol : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody rigd;

    // Start is called before the first frame update
    void Start()
    {
        rigd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
        rigd.AddForce(movement * speed);

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Obstacle"))
        {
            Debug.Log("THE END");
            SceneManager.LoadScene("3.END");
        }
    }



}

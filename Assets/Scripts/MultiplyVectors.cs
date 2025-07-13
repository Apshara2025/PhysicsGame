using UnityEngine;

public class MultiplyVectors : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    Camera myCamera;


    void Start()
    {
        myCamera = FindFirstObjectByType<Camera>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("collided without player tag");
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("collided");
            myCamera.backgroundColor = Color.red;
        }
    }
}

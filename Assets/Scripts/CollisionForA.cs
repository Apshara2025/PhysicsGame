using UnityEngine;

public class CollisionForA : MonoBehaviour
{
    [SerializeField] float delayBeforeDestruction = 0.5f;
    [SerializeField] GameObject mass;

    string correct_answer = "Scalar";
    string incorrect_answer = "Vector";
    void OnCollisionEnter2D(Collision2D other)
    {
        MonoBehaviour background = FindFirstObjectByType<Background>();
        SpriteRenderer mySpriteRenderer = background.GetComponent<SpriteRenderer>();

        if (other.gameObject.tag == correct_answer)
        {

            mySpriteRenderer.color = Color.green;

            Invoke("SetMassActive", delayBeforeDestruction);
            Invoke("DestroyGameObject", delayBeforeDestruction);


        }
        else if (other.gameObject.tag == incorrect_answer)
        {
            mySpriteRenderer.color = Color.red;
        }
    }

    private void SetMassActive()
    {
        mass.SetActive(true);
    }

    private void DestroyGameObject()
    {
        Destroy(gameObject);
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

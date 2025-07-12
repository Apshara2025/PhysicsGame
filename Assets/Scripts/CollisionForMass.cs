using UnityEngine;

public class CollisionForMass : MonoBehaviour
{
    [SerializeField] float delayBeforeDestruction = 0.5f;
    [SerializeField] GameObject velocity;

    string correct_answer = "Scalar";
    string incorrect_answer = "Vector";
    void OnCollisionEnter2D(Collision2D other)
    {
        MonoBehaviour background = FindFirstObjectByType<Background>();
        SpriteRenderer mySpriteRenderer = background.GetComponent<SpriteRenderer>();

        if (other.gameObject.tag == correct_answer)
        {

            mySpriteRenderer.color = Color.green;

            Invoke("SetVelocityActive", delayBeforeDestruction);
            Invoke("DestroyGameObject", delayBeforeDestruction);


        }
        else if (other.gameObject.tag == incorrect_answer)
        {
            mySpriteRenderer.color = Color.red;
        }
    }

    private void SetVelocityActive()
    {
        velocity.SetActive(true);
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

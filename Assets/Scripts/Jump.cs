using UnityEngine;
using UnityEngine.InputSystem;
public class Jump : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] InputAction thrust;
    [SerializeField] float thrustStrength = 10;
    SurfaceEffector2D mySurfaceEffector2D;
    Rigidbody2D myRigidBody;

    void Awake()
    {
        thrust.Enable();
    }
    void Start()
    {
        //Debug.Log("Start()");
        //Camera myCamera = FindFirstObjectByType<Camera>();
        //myCamera.backgroundColor = Color.blue;
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        if (thrust.IsPressed())
        {
            StartThrusting();
        }

    }

    void StartThrusting()
    {
        //mySurfaceEffector2D = FindFirstObjectByType<SurfaceEffector2D>();
        //mySurfaceEffector2D.enabled = false;
        transform.Translate(Vector3.up * thrustStrength * Time.fixedDeltaTime);
    }
}

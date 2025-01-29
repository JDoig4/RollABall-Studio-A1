using UnityEngine;

public class BallController : MonoBehaviour
{

    [SerializeField] private Rigidbody sphereRigidBody; // reference to the rigidbody component of the sphere
    [SerializeField] private float ballSpeed = 2f; // speed of the sphere

    void Start()
    {
    }

    // Update is called once per frame
    public void MoveBall(Vector2 input)
    {
        Vector3 inputXZPlane = new(input.x, 0, input.y); // create a vector in the xz plane
        sphereRigidBody.AddForce(inputXZPlane * ballSpeed); // add force to the sphere
    }
}

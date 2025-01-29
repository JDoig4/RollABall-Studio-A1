using UnityEngine;

public class BallController : MonoBehaviour
{

    public Rigidbody sphereRigidBody; // reference to the rigidbody component of the sphere
    public float ballSpeed = 2f; // speed of the sphere

    void Start()
    {
        Debug.Log("Calling the Start method");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputVector = Vector2.zero; //initialize input vector
        if (Input.GetKey(KeyCode.W))
        {
            inputVector += Vector2.up; // add up vector to input vector
        }

        if (Input.GetKey(KeyCode.A))
        {
            inputVector += Vector2.left; // add left vector to input vector
        }

        if (Input.GetKey(KeyCode.S))
        {
            inputVector += Vector2.down; // add down vector to input vector 
        }

        if (Input.GetKey(KeyCode.D))
        {
            inputVector += Vector2.right; // add right vector to input vector
        }

        // create a vector in the XZ plane
        Vector3 inputXZPlane = new Vector3(inputVector.x, 0, inputVector.y); 
        sphereRigidBody.AddForce(inputXZPlane * ballSpeed); // add force to the sphere in the XZ plane
        Debug.Log("Resultant Vector: " + inputVector);
        Debug.Log("Resultant 3D Vector: " + inputXZPlane);
    }
}

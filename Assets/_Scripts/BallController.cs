using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] float ballSpeed;
    private Rigidbody ballRB;
    private InputManager inputManager;
    void Start()
    {
        ballRB = GetComponent<Rigidbody>();
        inputManager = GetComponent<InputManager>();
        inputManager.OnMove.AddListener(MoveBall);
    }

    public void MoveBall(Vector2 input)
    {
        Vector3 inputXZPlane =  new(input.x, 0, input.y);
        ballRB.AddForce(inputXZPlane * ballSpeed);
    }
}

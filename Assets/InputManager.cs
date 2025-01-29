using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
   public UnityEvent<Vector2> OnMove = new UnityEvent<Vector2>(); // event to handle movement
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

        OnMove?.Invoke(inputVector); // invoke the event
    }
}

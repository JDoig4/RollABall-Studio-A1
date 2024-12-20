using System;
using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public UnityEvent<Vector2> OnMove = new();
    
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Mouse");
        }
        if (Input.GetKey(KeyCode.W))
        {
            OnMove?.Invoke(Vector2.up);
            Debug.Log($"User's Input: up");
        }
        else if (Input.GetKey(KeyCode.S))
        {
            OnMove?.Invoke(Vector2.down);
            Debug.Log($"User's Input: down");
        }
        else if (Input.GetKey(KeyCode.A))
        {
            OnMove?.Invoke(Vector2.right);
            Debug.Log($"User's Input: right");
        }
        else if (Input.GetKey(KeyCode.D))
        {
            OnMove?.Invoke(Vector2.left);
            Debug.Log($"User's Input: left");
        }
    }
}

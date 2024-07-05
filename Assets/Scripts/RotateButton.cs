using UnityEngine;

public class RotateButton : MonoBehaviour
{
    public Transform _squareTransform; // Reference to the transform of the object to rotate
    public float Speed = 1000f; // Rotation speed
    private bool isRotatingLeft = false;
    private bool isRotatingRight = false;

    private void Update()
    {
        if (isRotatingLeft)
        {
            RotateLeft();
        }
        else if (isRotatingRight)
        {
            RotateRight();
        }
    }

    private void RotateLeft()
    {
        if (_squareTransform != null)
        {
            _squareTransform.Rotate(Vector3.forward * Speed * Time.deltaTime);
        }
    }

    private void RotateRight()
    {
        if (_squareTransform != null)
        {
            _squareTransform.Rotate(Vector3.back * Speed * Time.deltaTime);
        }
    }

    public void StartRotatingLeft()
    {
        isRotatingLeft = true;
    }

    public void StopRotatingLeft()
    {
        isRotatingLeft = false;
    }

    public void StartRotatingRight()
    {
        isRotatingRight = true;
    }

    public void StopRotatingRight()
    {
        isRotatingRight = false;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuterMaze : MonoBehaviour
{
    [SerializeField]
    private int Speed = 500;

    [SerializeField]
    private Transform _squareTransform;

    private void Start()
    {
        Debug.Log("Start");
        Debug.Log(_squareTransform.position);
        Debug.Log(_squareTransform.rotation);
        Debug.Log(_squareTransform.localScale);

        // Vector3 newPosition = new Vector3(5, 0, 0);
        // _squareTransform.position = newPosition;

        // Quaternion newRotation = Quaternion.Euler(0, 0, 45);
        // _squareTransform.rotation = newRotation;

        // Vector3 newScale = new Vector3(2, 2, 2);
        // _squareTransform.localScale = newScale;        
    }

    private void Update()
    { 
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _squareTransform.Rotate(Vector3.forward * Speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            _squareTransform.Rotate(Vector3.back * Speed * Time.deltaTime);
        }

        // transform.eulerAngles = Vector3.back * Time.time * Speed;
    }
}

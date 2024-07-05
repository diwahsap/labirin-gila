using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _spawnedObject;

    // Menentukan posisi spawn
    Vector3 spawnPosition = new Vector3(4.9724f, 0, 0);

    // Menentukan rotasi spawn
    Quaternion spawnRotation = Quaternion.Euler(0, 0, 45);

    private void Start()
    {
        // Spawn object dengan posisi dan rotasi tertentu
        Instantiate(_spawnedObject, spawnPosition, spawnRotation);
    }

    private void Update()
    { 
        
    }
}

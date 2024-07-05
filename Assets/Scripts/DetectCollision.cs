using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DetectCollisions : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Kode akan dijalankan ketika ada object lain masuk ke dalam trigger
        Debug.Log("Trigger Enter");
        //change scene to gameover
        SceneManager.LoadScene("GameOver");
    }
}

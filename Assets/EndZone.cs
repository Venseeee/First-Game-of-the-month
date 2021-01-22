using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndZone : MonoBehaviour
{
    public string GameOver;

    public void ChangeScene()
    {
        SceneManager.LoadScene("GameOver");
    }
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player");
        ChangeScene();
    }
    
}


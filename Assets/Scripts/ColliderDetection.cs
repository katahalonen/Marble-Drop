using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColliderDetection : MonoBehaviour
{
    public GameObject LevelFailedText;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Marble")
        {
            LevelFailedText.SetActive(true);
            Invoke(nameof(DelayedRestart), 3.0f);
        }
    }
    public void DelayedRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

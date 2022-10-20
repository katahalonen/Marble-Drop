using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColliderDetection : MonoBehaviour
{
    public GameObject LevelClearedText;
    public GameObject LevelFailedText;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            LevelClearedText.SetActive(true);
            Invoke(nameof(DelayedNextScene), 5.0f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Marble")
        {
            LevelFailedText.SetActive(true);
            Invoke(nameof(DelayedRestart), 5.0f);
        }
    }

    public void DelayedNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void DelayedRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

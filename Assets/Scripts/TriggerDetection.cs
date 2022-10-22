using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerDetection : MonoBehaviour
{
    public GameObject LevelClearedText;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            LevelClearedText.SetActive(true);
            Invoke(nameof(DelayedNextScene), 3.0f);
        }
    }

    public void DelayedNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

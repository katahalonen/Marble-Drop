using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Unity.Notifications.Android;

public class UIController : MonoBehaviour
{
    public static UIController instance;

    private void Awake()
    {
        instance = this;
    }

    public TMP_Text LevelText;

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ExitMenu()
    {
        Application.Quit();
    }

    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        var channel = new AndroidNotificationChannel()
        {
            Id = "channel_id",
            Name = "Default Channel",
            Importance = Importance.Default,
            Description = "Generic notifications",
        };
        AndroidNotificationCenter.RegisterNotificationChannel(channel);

        var notification = new AndroidNotification();
        notification.Title = "You failed huh?";
        notification.Text = "It's okay if you had to reset the level";
        notification.FireTime = System.DateTime.Now.AddSeconds(1);

        AndroidNotificationCenter.SendNotification(notification, "channel_id");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainPanel;
    public GameObject optionsPanel;
    public GameObject creditsPanel;
    public GameObject statsPanel;
    public static float volume, highScore;
    public AudioSource music;
    public string highScoreText;
    public Text statText;

    void Start()
    {
        mainPanel.SetActive(true);
        optionsPanel.SetActive(false);
        creditsPanel.SetActive(false);
        statsPanel.SetActive(false);
        music = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioSource>();
        HighScore();
    }

    public void VolumeChange()
    {
        volume = music.volume;
    }
    public void ChangeScene(int sceneId)
    {
        SceneManager.LoadScene(sceneId);
    }
    public void ExitToDesktop()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }
    public void Restart(int sceneId)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneId);

    }

    public void HighScore()
    {
        statText.text = "Your High Score is: " + highScore;
    }
}

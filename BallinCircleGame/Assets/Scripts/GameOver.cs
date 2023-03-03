using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOver : MonoBehaviour
{

    [SerializeField] private TMP_Text scoreText;


    private void Start()
    {
        var score = PlayerPrefs.GetInt("score");
        scoreText.text = score.ToString();
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        SceneManager.LoadScene(0);
    }
}

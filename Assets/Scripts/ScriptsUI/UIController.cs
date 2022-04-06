using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    [SerializeField] GameObject endGamePanel;
    [SerializeField] float totalTime;
    [SerializeField] TextMeshProUGUI timer;

    void Awake()
    {
        endGamePanel.SetActive(false);
    }

    void Update()
    {
        totalTime += Time.deltaTime;

        float minutes = Mathf.FloorToInt(totalTime / 60);
        float seconds = Mathf.FloorToInt(totalTime % 60);
        float milliseconds = (totalTime % 1) * 1000;

        timer.text = "Time: " + string.Format("{0:00}:{1:00}:{2:0}", minutes, seconds, milliseconds);

        //totalTime -= Time.deltaTime;
        //timer.text = totalTime.ToString("F1");
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(0);
        Debug.Log("Se ha presionado el boton de Play Again");
    }

    public void QuitGame()
    {
        Debug.Log("Se ha presionado el boton de Quit Game");
    }

    public void PlayerDeath()
    {
        endGamePanel.SetActive(true);
    }
}

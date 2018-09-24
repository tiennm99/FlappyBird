using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Control : MonoBehaviour
{
    public Text txtPoint;
    public GameObject pnlStart;
    public Button btnStart;
    public GameObject pnlRestart;
    public Text txtRestart;
    public Button btnRestart;
    public Sprite btnRestartIdle;
    public Sprite btnRestartHover;
    public Sprite btnRestartClick;
    public Sprite btnStartIdle;
    public Sprite btnStartHover;
    public Sprite btnStartClick;
    public GameObject bird;
    public GameObject column;
    public GameObject sky;
    public GameObject grass;
    private int gamePoint;
    void Start()
    {
        gamePoint = 0;
        Time.timeScale = 0;
        pnlStart.SetActive(true);
    }
    void Update()
    {
        /*
         *column.GetComponent<Column>().randRange = 3.0f;
         * sky.GetComponent<Move>().moveSpeed += 0.5f;
         * grass.GetComponent<Move>().moveSpeed += 0.5f;
         * bird.GetComponent<Bird>().flyPower += 10f;
         */
    }
    public void RestartButtonIdle()
    {
        btnRestart.GetComponent<Image>().sprite = btnRestartIdle;
    }
    public void RestartButtonHover()
    {
        btnRestart.GetComponent<Image>().sprite = btnRestartHover;
    }
    public void RestartButtonClick()
    {
        btnRestart.GetComponent<Image>().sprite = btnRestartClick;
    }
    public void StartButtonIdle()
    {
        btnStart.GetComponent<Image>().sprite = btnStartIdle;
    }
    public void StartButtonHover()
    {
        btnStart.GetComponent<Image>().sprite = btnStartHover;
    }
    public void StartButtonClick()
    {
        btnStart.GetComponent<Image>().sprite = btnStartClick;
    }
    public void StartGame()
    {
        pnlStart.SetActive(false);
        pnlRestart.SetActive(false);
        Time.timeScale = 1;
    }
    public void GetPoint()
    {
        gamePoint++;
        txtPoint.text = "Point: " + gamePoint.ToString();
    }
    public void EndGame()
    {
        Time.timeScale = 0;
        txtRestart.text = "Your point:\n" + gamePoint.ToString();
        pnlRestart.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}

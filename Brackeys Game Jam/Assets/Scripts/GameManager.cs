using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    private Transform playerTransform;
    public List<GameObject> enemies;
    public TextMeshProUGUI timer;
    public GameObject winText;
    public GameObject loseText;
    public float timerTime = 60.0f;
    public bool isGameActive;
    public GameObject WinPanel;
    public GameObject LosePanel;
    public void GameOver()
    {
        WinPanel.SetActive(true);
        winText.SetActive(true);
        if (Input.GetKey(KeyCode.Escape))
        {
            Back();
        }
        else if (Input.GetKey(KeyCode.R))
        {
            Restart();
        }
    }

    public void Restart()
@ -70,7 +78,15 @@ public class GameManager : MonoBehaviour
    }
public void Death()
{
    LosePanel.SetActive(true);
    loseText.SetActive(true);
    if (Input.GetKey(KeyCode.Escape))
    {
        Back();
    }
    else if (Input.GetKey(KeyCode.R))
    {
        Restart();
    }
}

}  

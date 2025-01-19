using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Logic : MonoBehaviour
{
    public int Score;
    public Text scoretext;
    public GameObject gameoverscreen;

    [ContextMenu("Increase Score")]
    public void addscore(int scoretoadd)
    {
        Score = Score + scoretoadd;
        scoretext.text = Score.ToString();
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameover()
    {
        gameoverscreen.SetActive(true);
    }
}

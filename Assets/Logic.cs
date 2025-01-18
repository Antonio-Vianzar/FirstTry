using UnityEngine;
using UnityEngine.UI;

public class Logic : MonoBehaviour
{
    public int Score;
    public Text scoretext;

    [ContextMenu("Increase Score")]
    public void addscore(int scoretoadd)
    {
        Score = Score + scoretoadd;
        scoretext.text = Score.ToString();
    }
}

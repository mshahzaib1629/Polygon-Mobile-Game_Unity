using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OptionsMenuScript : MonoBehaviour
{
    public TextMeshProUGUI highestScore;

    // Start is called before the first frame update
    void Start()
    {
        highestScore.text = "Highest Score: " + HighestScoreScript.highestScore.ToString();
    }

}

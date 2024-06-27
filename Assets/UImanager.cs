using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UImanager : MonoBehaviour
{
    public TextMeshProUGUI LeftPlayer;
    public TextMeshProUGUI RightPlayer;

    public void Start()
    {
        LeftPlayer.SetText("0");
        RightPlayer.SetText("0");
    }
    public void SetLeftPlayerScoreText (string text)
    {
        LeftPlayer.SetText (text);
    }

    public void SetRightPlayerScoreText(string text)
    {
        RightPlayer.SetText(text);
    }
}

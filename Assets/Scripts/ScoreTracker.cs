﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTracker : MonoBehaviour {

    public int totalScore;
    public TextMeshProUGUI scoreText;

    private void Update()
    {
        scoreText.text = string.Format("Score: {0}", totalScore);
    }

}

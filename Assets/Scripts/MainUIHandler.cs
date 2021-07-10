using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUIHandler : MonoBehaviour
{
    [SerializeField] private Text bestScoreText;

    private int bestScore = 0;

    private void OnEnable()
    {
        PersistantDataManager.Instance.LoadBestScore();
        bestScore = PersistantDataManager.Instance.bestScore;
        bestScoreText.text = PersistantDataManager.Instance.username + " Your Best Score is: " + bestScore;
    }
}
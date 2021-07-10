using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainUIHandler : MonoBehaviour
{
    [SerializeField] private Text bestScoreText;

    private void OnEnable()
    {
        bestScoreText.text = PersistantDataManager.Instance.username + " Your Best Score is: ";
    }
}
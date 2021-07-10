using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    public void UsernameSelected(string username)
    {
        PersistantDataManager.Instance.username = username;
    }

    public void LoadLevel()
    {
        SceneManager.LoadScene(1);
    }
}
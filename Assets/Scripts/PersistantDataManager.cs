using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class PersistantDataManager : MonoBehaviour
{
    public static PersistantDataManager Instance;

    public string username;
    public int bestScore;

    public class SessionPersistantData
    {
        public int bestScore;
    }

    public void SaveBestScore()
    {
        SessionPersistantData sessionPersistantData = new SessionPersistantData();
        sessionPersistantData.bestScore = bestScore;

        string json = JsonUtility.ToJson(sessionPersistantData);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadBestScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SessionPersistantData data = JsonUtility.FromJson<SessionPersistantData>(json);

            bestScore = data.bestScore;
        }
    }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
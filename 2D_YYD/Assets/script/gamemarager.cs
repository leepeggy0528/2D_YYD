using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemarager : MonoBehaviour
{
    public void OnStartGame(int SceneNumber)
    {
        SceneManager.LoadScene(SceneNumber, LoadSceneMode.Additive);
    }

}

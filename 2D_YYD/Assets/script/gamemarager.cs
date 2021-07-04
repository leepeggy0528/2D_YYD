using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemarager : MonoBehaviour
{
    private void Start()
    {
        SceneManager.LoadScene("coffee store", LoadSceneMode.Additive);
    }
    public void OnStartGame(int SceneNumber)
    {
        SceneManager.LoadScene(SceneNumber, LoadSceneMode.Additive);
    }

}

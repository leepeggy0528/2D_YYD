using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gamemarager : MonoBehaviour
{
    #region 欄位


    #endregion

    #region 事件
    public void OnStartGame(int SceneNumber)
    {
        SceneManager.LoadScene(SceneNumber);
    }



    #endregion




}

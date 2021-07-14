using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class storemarage : MonoBehaviour
{
    #region 欄位
    ///<summary>
    ///player information
    /// </summary>
    private CanvasGroup groupFinal;

    private Button btnPause;
    private Button btnContinue;

    #endregion

    #region 事件
    private void Start()
    {
        groupFinal = GameObject.Find("pauseImage").GetComponent<CanvasGroup>();

        btnPause = GameObject.Find("pause").GetComponent<Button>();
        btnContinue = GameObject.Find("continue").GetComponent<Button>();


        btnPause.onClick.AddListener(Pause);
        btnContinue.onClick.AddListener(Continue);
    }

    private void Pause()
    {

        groupFinal.alpha = 1;
        groupFinal.interactable = true;
        groupFinal.blocksRaycasts = true;
    }

    private void Continue()
    {
        groupFinal.alpha = 0;
        groupFinal.interactable = false;
        groupFinal.blocksRaycasts = false;
    }
    #endregion

    #region 方法

    #endregion
}

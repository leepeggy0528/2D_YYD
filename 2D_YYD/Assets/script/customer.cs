using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class customer : MonoBehaviour
{
    #region 欄位
    [Header("訂單種類")]
    public Sprite[] sprOrder;
    [Header("金幣")]
    public Sprite sprCoin;

    /// <summary>
    /// Order-image
    /// </summary>
    private Image imgOrder;

    /// <summary>
    /// order-button
    /// </summary>
    private Button btnOrder;

    /// <summary>
    /// ordernumber
    /// </summary>
    private int indexOrder;

    /// <summary>
    /// 
    /// </summary>
    private boss boss;

    private Animator ani;
    #endregion

    #region 事件
    // Start is called before the first frame update
    void Start()
    {
        imgOrder = transform.GetChild(0).Find("order").GetComponent<Image>();
        btnOrder = imgOrder.GetComponent<Button>();
        btnOrder.onClick.AddListener(ClickOrder);
        boss = GameObject.Find("老闆").GetComponent<boss>();

        ani = GetComponent<Animator>();

        RandomOrder();

    }


    void Update()
    {
    }
    #endregion

    #region 方法
    /// <summary>
    /// 隨機訂單
    /// </summary>
    private void RandomOrder()
    {
        indexOrder = Random.Range(0, sprOrder.Length);
        imgOrder.color = new Color(255, 255, 255, 1);
        imgOrder.sprite = sprOrder[indexOrder];
    }

    /// <summary>
    /// 點擊訂單
    /// </summary>
    private void ClickOrder()
    {
        boss.GetOrder(indexOrder, transform);
        ani.SetBool("wait", true);
    }

    /// <summary>
    /// 取得餐點
    /// </summary>
    public void GetMeal()
    {
        ani.SetBool("wait", false);
        imgOrder.sprite = sprCoin;
    }
    #endregion
}

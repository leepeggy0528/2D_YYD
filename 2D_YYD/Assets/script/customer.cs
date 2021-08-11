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
    [Header("心情")]
    public Sprite[] sprEmg;
    [Header("思考")]
    public Sprite sprTik;

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

    private bool bad= true;

    private boss boss;

    
    private Money Money;

    private Animator ani;

    private CanvasGroup groupFinal;

    #endregion

    #region 事件
    // Start is called before the first frame update
    void Start()
    {
        imgOrder = transform.GetChild(0).Find("order").GetComponent<Image>();
        btnOrder = imgOrder.GetComponent<Button>();


        boss = GameObject.Find("老闆").GetComponent<boss>();
        Money = GameObject.Find("Canvas").GetComponent<Money>();

        groupFinal = GameObject.Find("GameOver").GetComponent<CanvasGroup>();

        ani = GetComponent<Animator>();

        imgOrder.color = new Color(255, 255, 255, 1);
        imgOrder.sprite = sprTik;
        Invoke("RandomOrder", 0.7f);
        Invoke("Mood", 3f);

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
        imgOrder.sprite = sprOrder[indexOrder];
        btnOrder.onClick.AddListener(ClickOrder);
    }

    private void Mood()
    {
        StartCoroutine(MoodBad());
    }

    private IEnumerator MoodBad()
    {
        if (bad == true)
        {
            imgOrder.sprite = sprEmg[1];
            btnOrder.onClick.RemoveListener(ClickOrder);
            yield return new WaitForSeconds(1f);
            this.gameObject.SetActive(false);
        }
    }

    /// <summary>
    /// 點擊訂單
    /// </summary>
    private void ClickOrder()
    {
            bad = false;
            boss.GetOrder(indexOrder, transform);
            ani.SetBool("wait", true);
    }

    /// <summary>
    /// 取得餐點
    /// </summary>
    public void GetMeal()
    {
        ani.SetBool("wait", false);
        imgOrder.sprite = sprEmg[0];
        Invoke("SprCoin", 0.7f);
        btnOrder.onClick.RemoveListener(ClickOrder);
        
    }

    private void SprCoin()
    {
        imgOrder.sprite = sprCoin;
        btnOrder.onClick.AddListener(ClickMoney);
    }

    private void ClickMoney()
    {
        Money.AddMoney(indexOrder);
        imgOrder.color = new Color(255, 255, 255, 0);
    }
    #endregion
}

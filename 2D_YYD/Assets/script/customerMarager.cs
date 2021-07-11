using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class customerMarager : MonoBehaviour
{
    #region 欄位
    [Header("客人種類")]
    public GameObject[] objcustomer;

    [Header("出發點位置")]
    public Transform pointdeparture;
    [Header("抵達點位置")]
    public Transform pointarrival;

    private int indexOrder;

    private GameObject imgOrder;

    private float speed = 2f;
    private float firstSpeed;
    private float delta = 0.2f; // 誤差值
    private static int i = 0;


    #endregion

    #region 事件
    private void Start()
    {
        imgOrder = GameObject.Find("departure").GetComponent<GameObject>();
        indexOrder = Random.Range(0, objcustomer.Length);
        firstSpeed = Vector3.Distance(objcustomer[indexOrder].transform.position, pointarrival.transform.position) * speed;
    }

    private void Update()
    {
        SpawnCustomer(indexOrder);
    }

    
    #endregion

    #region 方法
    private float calculateNewSpeed()
    {
        //因為每次移動都是 Obj 在移動，所以要取得 Obj 和 PathB 的距離
        float tmp = Vector3.Distance(objcustomer[indexOrder].transform.position, pointarrival.transform.position);

        //當距離為0的時候，就代表已經移動到目的地了。
        if (tmp == 0)
            return tmp;
        else
            return (firstSpeed / tmp);
    }


    ///<summary>
    ///間隔生成節點
    /// </summary> cf
    void SpawnCustomer(int indexOrder)
    {
        GameObject oUp =Instantiate(objcustomer[indexOrder], pointdeparture.position, Quaternion.identity);
        Transform tup = oUp.transform;

        // 讓物體朝向目標點 
        transform.LookAt(pointarrival.position);

        // 物體向前移動
        transform.Translate(-speed * Time.deltaTime, 0, 0); ;

        // 判斷物體是否到達目標點
        if (pointarrival.position.x > tup.position.x - delta
            && pointarrival.position.x < tup.position.x + delta
            && pointarrival.position.y > tup.position.y - delta
            && pointarrival.position.y < tup.position.y + delta)
            i = (i + 1) % objcustomer.Length;
    }

    #endregion
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class customerMarager : MonoBehaviour
{
    #region 欄位
    [Header("客人種類")]
    public GameObject[] objcustomer;

    [Header("客人位置")]
    public Transform[] pointcustomer;

    [Header("出發點位置")]
    public Transform pointdeparture;
    [Header("抵達點位置")]
    public Transform[] pointarrival;

    [Header("客人")]
    public customerdata customer;

    private int indexOrder;

    private GameObject imgOrder;

    private float speed = 300f;
    private float firstSpeed;
    private float delta = 0.2f; // 誤差值
    private static int i = 0;


    #endregion

    #region 事件
    private void Start()
    {
        imgOrder = GameObject.Find("departure").GetComponent<GameObject>();
        Invoke("Startcustomer", 1f);
    }
    private void Update()
    {
    }


    #endregion

    #region 方法
    private void Startcustomer()
    {
        print("開始生成");
        StartCoroutine(SpawnCustomer());
    }

    private IEnumerator SpawnCustomer()
    {
        for (int i = 0; i < customer.points.Length; i++)
        {
           switch (customer.points[i])
            {
                case customerdata.PointType.zero:
                    indexOrder = Random.Range(0, objcustomer.Length);
                    GameObject o0 = Instantiate(objcustomer[indexOrder], pointarrival[0].position, Quaternion.identity);
                    Destroy(o0, 10f);
                    break;
                case customerdata.PointType.one:
                    indexOrder = Random.Range(0, objcustomer.Length);
                    GameObject o1 = Instantiate(objcustomer[indexOrder], pointarrival[1].position, Quaternion.identity);
                    Destroy(o1, 10f);
                    break;

                case customerdata.PointType.two:
                    indexOrder = Random.Range(0, objcustomer.Length);
                    GameObject o2 = Instantiate(objcustomer[indexOrder], pointarrival[2].position, Quaternion.identity);
                    Destroy(o2, 10f);
                    break;
                case customerdata.PointType.three:
                    indexOrder = Random.Range(0, objcustomer.Length);
                    GameObject o3 = Instantiate(objcustomer[indexOrder], pointarrival[3].position, Quaternion.identity);
                    Destroy(o3, 10f);
                    break;
                case customerdata.PointType.four:
                    indexOrder = Random.Range(0, objcustomer.Length);
                    GameObject o4 = Instantiate(objcustomer[indexOrder], pointarrival[4].position, Quaternion.identity);
                    Destroy(o4, 10f);
                    break;
            }

            yield return new WaitForSeconds(4f);
            
        }
        
    }

    ///<summary>
    ///間隔生成顧客
    /// </summary>
    /*private IEnumerator SpawnCustomer(int indexOrder)
    {
        for (int i = 0; i < 60; i++)
        {
            indexOrder = Random.Range(0, objcustomer.Length);
            pointOrder = Random.Range(0, pointarrival.Length);
            GameObject oUp = Instantiate(objcustomer[indexOrder], pointdeparture.position, Quaternion.identity);

            // 讓物體朝向目標點 
            transform.LookAt(pointarrival[pointOrder].position);

            // 物體向前移動
            oUp.transform.Translate(speed * Time.deltaTime, speed * Time.deltaTime, 0);

            // 判斷物體是否到達目標點
            if (pointarrival[pointOrder].position.x > pointcustomer[indexOrder].position.x - delta
                && pointarrival[pointOrder].position.x < pointcustomer[indexOrder].position.x + delta
                && pointarrival[pointOrder].position.y > pointcustomer[indexOrder].position.y - delta
                && pointarrival[pointOrder].position.y < pointcustomer[indexOrder].position.y + delta)
                i = (i + 1) % objcustomer.Length;
        }
        yield return new WaitForSeconds(2f); //等待秒數

    }*/

    #endregion
}

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

    private CanvasGroup groupFinal;

    private int indexOrder;
    private int pointOrder;

    private GameObject imgOrder;

    #endregion

    #region 事件
    private void Start()
    {
        imgOrder = GameObject.Find("departure").GetComponent<GameObject>();
        groupFinal = GameObject.Find("thankCanvas").GetComponent<CanvasGroup>();
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
        for (int j = 0; j < 40; j++)
        {
            for (int i = 0; i < customer.points.Length; i++)
            {
                pointOrder = Random.Range(0, pointarrival.Length);
                switch (customer.points[i])
                {
                    case customerdata.PointType.zero:
                        indexOrder = Random.Range(0, objcustomer.Length);
                        GameObject o0 = Instantiate(objcustomer[indexOrder], pointarrival[0].position, Quaternion.identity);
                        Destroy(o0, 6.2f);
                        break;
                    case customerdata.PointType.one:
                        indexOrder = Random.Range(0, objcustomer.Length);
                        GameObject o1 = Instantiate(objcustomer[indexOrder], pointarrival[1].position, Quaternion.identity);
                        Destroy(o1, 6.2f);
                        break;

                    case customerdata.PointType.two:
                        indexOrder = Random.Range(0, objcustomer.Length);
                        GameObject o2 = Instantiate(objcustomer[indexOrder], pointarrival[2].position, Quaternion.identity);
                        Destroy(o2, 6.2f);
                        break;
                    case customerdata.PointType.three:
                        indexOrder = Random.Range(0, objcustomer.Length);
                        GameObject o3 = Instantiate(objcustomer[indexOrder], pointarrival[3].position, Quaternion.identity);
                        Destroy(o3, 6.2f);
                        break;
                    case customerdata.PointType.four:
                        indexOrder = Random.Range(0, objcustomer.Length);
                        GameObject o4 = Instantiate(objcustomer[indexOrder], pointarrival[4].position, Quaternion.identity);
                        Destroy(o4, 6.2f);
                        break;
                }
                yield return new WaitForSeconds(4f);
            }
        }
        yield return new WaitForSeconds(2f);
        groupFinal.alpha = 1;
        groupFinal.interactable = true;
        groupFinal.blocksRaycasts = true;

    }

    #endregion
}

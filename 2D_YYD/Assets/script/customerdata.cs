using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "peggy/customerdata", fileName = "CustomerData")]
public class customerdata : ScriptableObject
{
    [Header("音樂節點")]
    public PointType[] points;
    public enum PointType
    {
       one,two,three,four,zero
    }
}

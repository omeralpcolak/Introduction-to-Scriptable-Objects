using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Inventory/List", order = 1)]
public class MyScriptableObjectClass : ScriptableObject
{   
    
    public string objectName = "New MyScritableObject";
    public bool colorIsRandom = false;
    public Color thisColor = Color.white;
    public Vector3[] spawnPoints;
}

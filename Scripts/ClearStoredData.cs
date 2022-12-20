using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearStoredData : MonoBehaviour
{
    public void ClearData()
    {
        PlayerPrefs.DeleteAll();
    }
}

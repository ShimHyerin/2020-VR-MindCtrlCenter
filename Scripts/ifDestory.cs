using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ifDestory : MonoBehaviour
{
    public GameObject obj;
    public void DestroyObj(){
        Destroy(obj);
    }
}

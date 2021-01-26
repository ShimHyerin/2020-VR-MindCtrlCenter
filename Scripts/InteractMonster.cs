using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class InteractMonster : MonoBehaviour
{
    private Material ThisMaterial = null;
    public Color HighlightColor = Color.red;
    public Color DefaultColor = Color.white;
    private Color DestColor = Color.white;
    public UnityEvent OnSelected;

    private void Awake()
    {
        // ThisMaterial = GetComponent<MeshRenderer>().material;
        // DestColor = DefaultColor;
    }

    // public void AddHighlight()
    // {
    //     DestColor = HighlightColor;
    // }

    // public void RemoveHighlight()
    // {
    //     DestColor = DefaultColor;
    // }

    public void Select()
    {
        OnSelected.Invoke();
    }

    // private void Update()
    // {
    //     float pingPong = Mathf.PingPong(Time.time, 1f);
    //     Color Result = Color.Lerp(DefaultColor, DestColor, pingPong);
    //     ThisMaterial.SetColor("_BaseColor", Result);
    // }
}

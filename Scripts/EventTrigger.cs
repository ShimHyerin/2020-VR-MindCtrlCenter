using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;


public class EventTrigger : MonoBehaviour
{

    public UnityEvent TriggerEnter;
    public UnityEvent TriggerExit;
    public string ColliderTag = "Player";

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag(ColliderTag))
            return;
        TriggerEnter.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag(ColliderTag))
            return;
        TriggerExit.Invoke();
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

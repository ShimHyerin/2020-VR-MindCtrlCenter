using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{   
    public GameObject[] Teleporters;
    public string ColliderTag = "Player";
    public static bool CanActivate = true;
    public int targetTeleporter = 0;
    public static float TimeOut = 3f;


    // Start is called before the first frame update
    private void Start()
    {
        if(Teleporters == null){
            Teleporters = GameObject.FindGameObjectsWithTag("Teleporter");
        }
    }
    private void OnTriggerEnter(Collider other){
        if(!other.CompareTag(ColliderTag)) return;
        if(Teleporters.Length <= 1) return;
        if(!CanActivate) return;

        GameObject GO = Teleporters[targetTeleporter];

        while (GO.GetInstanceID() == gameObject.GetInstanceID())
            GO = Teleporters[targetTeleporter];
        
        other.transform.position = GO.transform.position;
        CanActivate = false;
        Invoke("ReActivate", TimeOut);
    }

    private void ReActivate(){
        CanActivate = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

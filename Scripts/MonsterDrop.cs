using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDrop : MonoBehaviour
{
    GameCtrl gameCtrl;
    public GameObject monster;
    public GameObject player;
    public int cnt = 1;

    private AudioSource audio;
    public AudioClip sound;

    // Start is called before the first frame update
    void Start()
    {   
        // Invoke("SpawnMonster", 5f);
        InvokeRepeating("SpawnMonster", 8, 1);
        gameCtrl = GameObject.Find("GameController").GetComponent<GameCtrl>();

        // this.audio = this.gameObject.AddComponent<AudioSource>();
        // this.audio.clip = this.sound;
        // this.audio.loop = false;
    }

    void SpawnMonster()
    {
        float posX = player.transform.position.x;
        float posZ = player.transform.position.z;
        float randomX = Random.Range(-40.0f, 40.0f);
        float randomZ = Random.Range(80.0f, 11.0f);
        // Debug.Log("Invoke");
        // cnt++;
        // Debug.Log(cnt);
        // if(cnt > 2) {
        //     Debug.Log(cnt);
        //     CancelInvoke("SpawnMonster");
        //     Debug.Log("Cancel");
        // }
        // Debug.Log(cnt);
        if(cnt<7){
            cnt++;
            GameObject Monster = (GameObject)Instantiate(monster, new Vector3(randomX, 2.7f, randomZ), Quaternion.identity);

        }
        // if(tmp == 1){
        //     cnt -= 1;
        // }

    }

    // IEnumerator PlaySfx(AudioClip getClip){
    //     GetComponent<AudioSource>().PlayOneShot(getClip, 0.9f);
    //     yield return null;
    // }
    public void DestroyGameObj(){
        gameCtrl.monsterKill += 1;
        Debug.Log(gameCtrl.monsterKill);
        Destroy(this.gameObject);
        // StartCoroutine(this.PlaySfx(exploSfx));
        // this.audio.Play();
        // cnt-=1;
        // Debug.Log(tmp);
    }
}

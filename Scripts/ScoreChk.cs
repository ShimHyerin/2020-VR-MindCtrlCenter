using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreChk : MonoBehaviour
{
    GameCtrl gameCtrl;
    // public Text score_text;
    public Text sc_text;

    // Start is called before the first frame update
    void Start()
    {
        sc_text = GameObject.Find("Score").GetComponent<Text>();
        gameCtrl = GameObject.Find("GameController").GetComponent<GameCtrl>();
    }

    // Update is called once per frame
    void Update()
    {   
        if(gameCtrl.monsterKill<15)
            sc_text.text = "모은 마음조각\n" + gameCtrl.monsterKill.ToString() + " / 15";
        else{
            sc_text.text = "모은 마음조각: " + gameCtrl.monsterKill.ToString() + "\n임무완료!";
        }
    }
}

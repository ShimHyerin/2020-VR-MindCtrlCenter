using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBox : MonoBehaviour
{
    SaveTextToBtn savemsg;
    public Text box_text;
    public Text box_text2;
    public Text box_text3;

    public string[] Msg = new string[6];

    // Start is called before the first frame update
    void Start()
    {   
        box_text = GameObject.Find("boxmsg").GetComponent<Text>();
        box_text2 = GameObject.Find("boxmsg2").GetComponent<Text>();
        box_text3 = GameObject.Find("boxmsg3").GetComponent<Text>();
        savemsg = GameObject.Find("StartMsg").GetComponent<SaveTextToBtn>();
    }

    public void ChangeText(){
        Msg = savemsg.saveMsg;
        box_text.text = "주인을 힘들게하는 '"+ Msg[0] + "' 생각을 없애고 " + Msg[3] + "을(를)하는 생각을 심어줬어! ";
        box_text2.text = "주인을 힘들게하는 '"+ Msg[1] + "' 생각을 없애고 " + Msg[4] + "을(를)먹는 생각을 심어줬어! ";
        box_text3.text = "주인을 힘들게하는 '"+ Msg[2] + "' 생각을 없애고 " + Msg[5] + "은(는) 생각을 심어줬어! ";

        // Debug.Log(box_text.text);
    }

    // Update is called once per frame
    void Update()
    {
    }
}

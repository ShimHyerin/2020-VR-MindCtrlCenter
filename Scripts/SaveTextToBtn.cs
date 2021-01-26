using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveTextToBtn : MonoBehaviour
{   
    // public InputField m_input;
    TextBox textbox;
    public InputField m_input;
    public Text m_text;
    private string msg;
    public string[] saveMsg = new string[6];
    public int cnt = 0;
    // private Animation StartMsg;

    void Start(){
        
    }

    public void saveMsgBtn(){
        // saveMsg[0] = "hihi"; // tmp text saveMsg[0]
        msg = m_input.text;
        saveMsg[cnt] = msg;
        // Debug.Log(msg);
        Debug.Log(cnt + " " + saveMsg[cnt]);
        m_input.text = "save!";
        cnt += 1;
        m_input.text = "";

        if(cnt == 6){
            // GameObject.Find("boxmsg").GetComponent<TextBox>().SetActive(true);
            textbox = GameObject.Find("boxmsg").GetComponent<TextBox>();
            // textbox.ChangeText();
            GameObject.Find("boxmsg").SendMessage("ChangeText");
        }
    }
}

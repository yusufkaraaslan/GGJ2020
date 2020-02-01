using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCDialogue : MonoBehaviour
{
    public Dialogue dialogue;
    //public LevelController lc;
    public Text text;
    public bool isActivated = false;

    public GameObject TalkCanvas;

    public void PlayerEnter()
    {
        if(dialogue.dType.choice == 2)
        {//Talk Text
            TalkCanvas.SetActive(true);
            TalkCanvas.transform.GetChild(2).gameObject.SetActive(true);
        }
        else if(dialogue.dType.choice == 1)
        {//Choice Text
            TalkCanvas.SetActive(true);
            TalkCanvas.transform.GetChild(3).gameObject.SetActive(true);
        }
    }
    public void PlayerExit()
    {

    }

    public void TriggerEvent(int c = 0)
    {
        if(dialogue.dType.choice == 1)
        {
            //if(c =)
            //lc.
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if (!isActivated)
                PlayerEnter();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
                PlayerExit();
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

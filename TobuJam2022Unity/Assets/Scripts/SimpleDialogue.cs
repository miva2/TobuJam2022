using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleDialogue : MonoBehaviour, Talkable
{

    public Dialogue dialogue;
    public GameObject talkableIcon;
    // public Collider2D conversationRangeCollider; // not sure how to use this for triggering collision

    private bool talkedTo = false;
    private int currentCueIndex = 0;

    void Start()
    {
        talkableIcon.SetActive(false);

    }

    // TODO: I don't want to be dependent on the gameobject having a collider. I want to use the given collider instead. Not sure how to do that
    // this might be a solution: https://answers.unity.com/questions/867859/how-to-detect-ontriggerenter-on-another-gameobject.html
    // but for now this is good enough I guess
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(Tags.PLAYER))
        {
            talkableIcon.SetActive(true);
            startConversation(); // TODO: should start only when player presses button
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag(Tags.PLAYER))
        {
            talkableIcon.SetActive(false);
            currentCueIndex = 0;
        }
    }

    public void startConversation()
    {
        
        //TODO: pop up dialogue box with first cue
        nextCue();
    }

    public void nextCue()
    {
        string cue = dialogue.cues[currentCueIndex++];
      
        //TODO: show text in dialogue box
        Debug.Log(cue);
    }

    public void endConversation()
    {
        throw new System.NotImplementedException();
    }
}

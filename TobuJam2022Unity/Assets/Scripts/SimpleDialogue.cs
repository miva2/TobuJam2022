using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleDialogue : MonoBehaviour, Talkable
{

    public Dialogue dialogue;
    public GameObject talkableIcon;

    private bool talkedTo = false;
    private int currentCueIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        talkableIcon.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        // check if player is withing conversation range and show talkableIcon
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

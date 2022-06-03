using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Talkable
{
    void startConversation();
    void nextCue();
    void endConversation();
}

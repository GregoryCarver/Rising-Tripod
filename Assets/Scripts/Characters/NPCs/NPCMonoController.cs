using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Things to do: -Set up flags for NPC triggered events, -Decide whether or not to store which dialogue sequence a particuliar NPC is on
//              between game start ups(maybe list in dialogue manager storing NPC static variable?), -

//Used to control the monobehaviour of the NPC and initialize the NPC character.
public class NPCMonoController : MonoBehaviour
{
    public NPC npc;
    public string npcName;
    public List<string> Dialogues;
    public byte currentDialogue = 0;

	// Use this for initialization
	void Start ()
    {
        npc = new NPC(npcName, Dialogues, currentDialogue);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public string RetrieveDialogue()
    {
        string tempDialogue = npc.Dialogues[npc.CurrentDialogue];

        npc.CurrentDialogue++;

        if (npc.CurrentDialogue == npc.Dialogues.Count)
        {
            npc.CurrentDialogue = 0;
        }

        return tempDialogue;
    }
}

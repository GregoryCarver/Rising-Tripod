using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Things to add: -NPC walk-around AI(in mono script?), -Dialogue AI, 
//               -Flag system for what NPC's have been talked to, especially important NPC's

public class NPC : BaseCharacter {

    public List<string> Dialogues { get; set; }
    public byte CurrentDialogue { get; set; }
    //The number of different dialogues the NPC has. Used to cycle through the dialogues.
    //public int DialoguesAmount { get; set; } just use Dialogues.Count?

    public NPC(string name, List<string> dialogue, byte currentDialogue) : base(name)
    {
        Dialogues = dialogue;
        CurrentDialogue = currentDialogue;
    }
}

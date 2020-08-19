using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PartyManager
{
    //public static List<BasePlayableCharacter> party = new List<BasePlayableCharacter> { new BasePlayableCharacter("Adam", 9, 9, 9, 9, 9, 9) };
    public static List<BasePlayableCharacter> party = new List<BasePlayableCharacter> { PlayableCharacterData.Adam };

    public static void AddMemberToParty(BasePlayableCharacter member)
    {
        party.Add(member);
    }
}

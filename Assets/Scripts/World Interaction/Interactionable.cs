using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Things to do: -Make a script to handle the dialogue UI, -Move dialogue to dialogue manager

public class Interactionable : MonoBehaviour
{
    public bool dialogue;
    public bool item;
    public bool trigger;

    public string itemToPickUp;

    public GameObject dialoguePanel;
    public GameObject dialogueText;
    public GameObject npcNameText;

	// Use this for initialization
	void Start ()
    {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void InterAction()
    {
        if (dialogue)
        {
            dialoguePanel.SetActive(true);
            npcNameText.GetComponent<Text>().text = gameObject.GetComponent<NPCMonoController>().npcName;
            dialogueText.GetComponent<Text>().text = gameObject.GetComponent<NPCMonoController>().RetrieveDialogue();
        }
        if (item)
        {
            if (!Inventory.CheckIfHaveItem(itemToPickUp))
            {
                Inventory.AddItem(itemToPickUp);
            }
            else if(Inventory.inventoryStorage[itemToPickUp] < 99)
            {
                Inventory.inventoryStorage[itemToPickUp]++;
            }
            else
            {
                Debug.Log("Have 99 of that item");
            }
        }
        if (trigger)
        {
            Debug.Log(PartyManager.party[0].CurrLevel);
            Debug.Log(PartyManager.party[0].MaxHp);
            Debug.Log(PartyManager.party[0].CurrHp);
            Debug.Log(PartyManager.party[0].MaxMp);
            Debug.Log(PartyManager.party[0].CurrMp);
            Debug.Log(PartyManager.party[0].Strength);
            Debug.Log(PartyManager.party[0].Defense);
            Debug.Log(PartyManager.party[0].Intelligence);
            Debug.Log(PartyManager.party[0].Will);
            Debug.Log(PartyManager.party[0].Speed);
            Debug.Log(PartyManager.party[0].Agility);
            Debug.Log(PartyManager.party[0].ExpToNextLevel);
        }
    }
}

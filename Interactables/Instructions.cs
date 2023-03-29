using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//Puah Li Hao//
//IM2073//
public class Instructions : Interactable
{

    [SerializeField]
    private GameObject doll;
    public TextMeshProUGUI Text;
    private bool interacting = false;

    protected override void Interact()
    {
        interacting = !interacting;
        if (interacting)
        {
            Text.text = "YOU HAVE TO ESCAPE THIS PLACE!\nI couldnt make it out of this house filled with cursed people like me but you have a chance.\nI gave you a gun I found in the wardrobe, please.\nEscape and avenge me!\nWASD to walk .Left Mouse to shoot.\nF to end convo.";
        }
        else
        {
            Text.text = "";
        }
    }

}

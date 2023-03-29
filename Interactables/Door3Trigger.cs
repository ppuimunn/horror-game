using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Puah Li Hao//
public class Door3Trigger : Interactable
{
    [SerializeField]
    private GameObject door;
    private bool doorOpen = false;
    protected override void Interact()
    {
        doorOpen = !doorOpen;
        door.GetComponent<Animator>().SetBool("open", doorOpen);
    }
}

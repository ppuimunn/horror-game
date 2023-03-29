using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Puah Li Hao//
public class SpawnDoorknob : Interactable
{
    [SerializeField]
    private GameObject door;
    private bool doorOpen;
    // Start is called before the first frame update
    protected override void Interact()
    {
        doorOpen = !doorOpen;
        door.GetComponent<Animator>().SetBool("open", doorOpen);
    }
}

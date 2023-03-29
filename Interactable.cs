using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Puah Li Hao//
public abstract class Interactable : MonoBehaviour
{   //Add or remove InteractionEvent component to this gameObject
    public bool useEvents;
    // Start is called before the first frame update
    public string promptMessage;
    public void BaseInteract()
    {
        if (useEvents)
            GetComponent<InteractionEvent>().OnInteract.Invoke();
        Interact();
    }
    protected virtual void Interact()
    {
        //template function to be overwritten
    }
}

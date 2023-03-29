using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PickupGun : Interactable
{
    [SerializeField]
    private GameObject gun;
    private bool gunPicked = false;
    public PlayerInput.OnFootActions onFoot;
    public PlayerInput.WithGunActions withGun;
    //private PlayerInput playerInput;

    protected override void Interact()
    {
        gunPicked = !gunPicked;
        Destroy(gun, 0);
        onFoot.Enable();
        withGun.Enable();
        //PlayerInput.actions.FindActionMap("OnFoot").Disable();
        //PlayerInput.actions.FindActionMap("WithGun").Enable();
    }

}

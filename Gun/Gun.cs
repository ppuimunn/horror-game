using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//IM2073 - Low Pui Mun
public class Gun : MonoBehaviour
{
    private PlayerMotor _input;
    public AudioSource audioSource;
    public AudioClip audioclip;
    
    [SerializeField]
    private GameObject bulletPrefab;
    [SerializeField]
    private GameObject bulletPoint;
    [SerializeField]
    private float bulletSpeed = 500;

    void Start()
    {
        _input = transform.root.GetComponent<PlayerMotor>();
        InstantiateAudioClip(audioclip);
        
    }

    void Update()
    {
        if (_input.shoot)
        {
            Shoot();
            PlaySound();
            _input.shoot = false;
        }
    }

    void Shoot()
    {
        //Debug.Log("shoot");
        GameObject bullet = Instantiate(bulletPrefab, bulletPoint.transform.position, transform.rotation);
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);
        Destroy(bullet, 1);
    }

    private void InstantiateAudioClip(AudioClip clip)
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = clip;
    }

    public void PlaySound()
    {
        if(audioSource.isPlaying)
        {
            audioSource.Stop();
            audioSource.Play();
        }
    }
}

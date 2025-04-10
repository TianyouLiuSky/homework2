using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    public GameObject prefab;
    public GameObject shootingPoint;
    public ParticleSystem muzzleEffect;
    public AudioSource shootSound;
    public int bulletsAmount;

    public float fireRate = 0.2f;

    private Animator animator;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void OnFire(InputValue value)
    {
        animator.SetBool("Shooting", value.isPressed);

        if (value.isPressed)
        {
            InvokeRepeating(nameof(Shoot), fireRate, fireRate);
        }
        else
        {
            CancelInvoke(nameof(Shoot));
        }
    }

    private void Shoot()
    {
        if (bulletsAmount > 0 && Time.timeScale > 0)
        {
            bulletsAmount--;

            GameObject clone = Instantiate(prefab);
            clone.transform.position = shootingPoint.transform.position;
            clone.transform.rotation = shootingPoint.transform.rotation;

            muzzleEffect.Play();
            shootSound.Play();
        }
    }
}

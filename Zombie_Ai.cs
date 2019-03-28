using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie_Ai : MonoBehaviour
{
    [SerializeField]
    private Transform _player;

    private float animationCooldown;

    static Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        animationCooldown = Time.time + 1.45f;
    }

    // Update is called once per frame
    void Update()
    {
        ChasePlayer();
    }
    private void ChasePlayer()
    {
        if (Time.time > animationCooldown)
        {
            transform.LookAt(_player);
            transform.Translate(Vector3.forward * Time.deltaTime);
        }
    }

}

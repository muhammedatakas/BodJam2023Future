using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportEffect : MonoBehaviour
{
    public GameObject particle;
     private ParticleSystem particleSystem;
   [SerializeField] Animator animator;
    [SerializeField] private Transform gelecek;
    bool hasGone;
    private void Awake()
    {
        particleSystem = GetComponent<ParticleSystem>();
        
    }
    private void Update()
    {
        if (!hasGone&&Transfer.isAtAdult) {
           hasGone = true;
        }
       
        if (!Transfer.isAtAdult&&hasGone)
        {
            particle.transform.position = gelecek.transform.position;
            particle.gameObject.SetActive(true);
            particleSystem.Play();
            animator.SetBool("isAtAdult", true);

        }
        else animator.SetBool("isAtAdult", false); 
        
    }
}

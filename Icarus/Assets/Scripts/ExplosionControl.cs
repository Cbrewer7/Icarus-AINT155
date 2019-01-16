
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionControl : MonoBehaviour {

    public ParticleSystem Explosion;
    // Use this for initialization
    void Start()
    {
        Explosion.GetComponent<ParticleSystem>().enableEmission = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Explosion.GetComponent<ParticleSystem>().enableEmission = true;
        Explosion.GetComponent<ParticleSystem>().Play();
    }

    IEnumerator StopExplosion()
    {
        yield return new WaitForSeconds(.1f);
        Explosion.GetComponent<ParticleSystem>().enableEmission = false;
        
    }
}

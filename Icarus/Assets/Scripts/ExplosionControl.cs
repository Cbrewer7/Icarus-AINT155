
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
        StartCoroutine(StopExplosion());
    }

    IEnumerator StopExplosion()
    {
        yield return new WaitForSeconds(.1f);
        Explosion.GetComponent<ParticleSystem>().enableEmission = false;
        //.enableEmission
    }
    //private void Update()
    //{
    //    var emission = Explosion.emission;
    //    emission.enabled = moduleEnabled;
    //}

    //private void Start()
    //{
    //    ParticleSystem Explosion = GetComponent<ParticleSystem>();
    //    var em = Explosion.emission;
    //    em.enabled = true;

    //    em.type = ParticleSystemEmissionType.Time;

    //    em.SetBurst(
    //        new ParticleSystem.Burst[] {
    //        new ParticleSystem.Burst(2.0f, 100),
    //        new ParticleSystem.Burst(4.0f, 100)
    //        });
    //}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;
using System;

public class Bricks : MonoBehaviour
{
    private SpriteRenderer sr;
    public ParticleSystem DestroyEffect;
    public static event Action<Bricks> OnBrickDestruction;
    public int HitPoints = 1;


    private void Start()
    {
        this.sr = this.GetComponent<SpriteRenderer>();
    }
    void OnCollisionEnter(Collision other)
    {
        Ball ball = other.gameObject.GetComponent<Ball>();
        ApplyCollisionLogic(ball);
    }



    private void ApplyCollisionLogic(Ball ball)
    {
        this.HitPoints--;
        if (this.HitPoints <= 0)
        {
            Destroy(gameObject);
            OnBrickDestruction?.Invoke(this);
            SpawnDestroyEffect();

        }
        else
        {
            //Change the sprite
        }
    }

    private void SpawnDestroyEffect()
    {
        Vector3 brickPos = gameObject.transform.position;
        Vector3 spawnPosition = new Vector3(brickPos.x, brickPos.y, brickPos.z - 0.2f);
        GameObject effect = Instantiate(DestroyEffect.gameObject, spawnPosition, Quaternion.identity);

        MainModule mm = effect.GetComponent<ParticleSystem>().main;
        mm.startColor = this.sr.color;
        Destroy(effect, DestroyEffect.main.startLifetime.constant);
    }
}

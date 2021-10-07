using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DashAbility : Ability
{

    public float dashVelocity;
    public float effectDeleteTime;
    private GameObject castEffect;

    public override void Activate(GameObject parent)
    {
        GameObject caster = parent;
        Transform casterTransform = caster.transform;
        castEffect = Instantiate(castEffectPrefab,casterTransform.position,casterTransform.rotation, casterTransform);


        PlayerMovement movement = caster.GetComponent<PlayerMovement>();
        movement.acceleration = dashVelocity;
        Destroy(castEffect, effectDeleteTime);
    }

    public override void BeginCooldown(GameObject parent)
    {
        PlayerMovement movement = parent.GetComponent<PlayerMovement>();
        movement.acceleration = movement.stockAcceleration;
    }
}

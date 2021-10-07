using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FireBall : Ability
{
    public float fireballVelocity=2;
    private GameObject castEffect;
    public float effectDeleteTime=5;

    public override void Activate(GameObject parent)
    {
        GameObject caster = parent;
        Transform casterTransform = caster.transform;
        castEffect = Instantiate(castEffectPrefab, casterTransform.position, casterTransform.rotation);

        IsoLookSelectCustom script = caster.GetComponent<IsoLookSelectCustom>();

        castEffect.transform.LookAt(new Vector3(script.mouseLocation.x, casterTransform.position.y, script.mouseLocation.z));
        Destroy(castEffect, effectDeleteTime);
    }
    public override void BeginCooldown(GameObject parent)
    {
    }
}

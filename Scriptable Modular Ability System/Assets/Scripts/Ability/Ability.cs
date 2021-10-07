using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability : ScriptableObject
{
    public new string name;

    public float cooldowntime;
    public float activeTime;

    public int baseDamage;
    public int elementalDamage;
    //crit chance?
    public int manaCost;

    public GameObject castEffectPrefab;
    public GameObject hitEffectPrefab;
    //public GameObject critEffectPrefab;

    public virtual void Activate(GameObject parent) { }
    public virtual void BeginCooldown(GameObject parent) { }
    public virtual void DeleteEffect(GameObject parent) { }
}

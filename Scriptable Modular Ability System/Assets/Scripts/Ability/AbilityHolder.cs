using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityHolder : MonoBehaviour
{
    public Ability ability;

    float coolDownTime;
    float activeTime;
    //float effectDeleteTime;

    enum AbilityState
    {
        ready,
        active,
        cooldown
    }

    AbilityState state = AbilityState.ready;

    public KeyCode key;

    void Update()
    {
        switch(state)
        {
            case AbilityState.ready:

                if (Input.GetKeyDown(key))
                {
                    ability.Activate(gameObject);
                    state = AbilityState.active;
                    activeTime = ability.activeTime;

                }
            break;
            case AbilityState.active:

                if (activeTime > 0)
                {
                    activeTime -= Time.deltaTime;
                }
                else
                {
                    ability.BeginCooldown(gameObject);
                    state = AbilityState.cooldown;
                    coolDownTime = ability.cooldowntime;
                }
            break;
            case AbilityState.cooldown:

                if (coolDownTime > 0)
                {
                    coolDownTime -= Time.deltaTime;
                }
                else
                {
                    state = AbilityState.ready;
                }
            break;
        }
    }
}

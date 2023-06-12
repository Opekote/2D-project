using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpKill : Monster
{
    protected override void OnTriggerEnter2D(Collider2D collider)
    {
        Unit unit = collider.GetComponent<Unit>();

        if (unit && unit is Character)
        {
            if (Mathf.Abs(unit.transform.position.x - transform.position.x) < 0.4F) ReceiveDamage();
            else unit.ReceiveDamage();
        }
    }
}

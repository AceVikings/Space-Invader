using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public void Die()
    {
        Destroy(gameObject);
    }
}

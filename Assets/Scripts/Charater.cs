using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class Charater : MonoBehaviour
{
    private int atk;

    public void Attack(Enemy enemy)
    {
        enemy.TakeDamage(atk);
    }

    public void SetAtk(int atkValue)
    {
        atk = atkValue;
    }
}
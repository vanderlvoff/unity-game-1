using System;
using UnityEngine;

//
public class PlayerManager : MonoBehaviour
{
    //
    Action tapAction;


    public int hp;
    public int at;

    //
    public void Attack(EnemyManager enemy)
    {
        enemy.Damage(at);
    }

    //
    public void Damage(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            hp = 0;
        }
    }

    //
    public void AddEventListenerOnTap(Action action)
    {
        tapAction += action;
    }

    public void OnTap()
    {
        Debug.Log("クリックされた");
        tapAction();
    }
}

using System;
using UnityEngine;

//
public class EnemyManager : MonoBehaviour
{
    //
    Action tapAction;

    public new string name;
    public int hp;
    public int at;

    //
    public void Attack(PlayerManager player)
    {
        player.Damage(at);
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
　
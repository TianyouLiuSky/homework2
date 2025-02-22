using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemiesManager : MonoBehaviour
{
    public List<Enemy> enemies;

    public UnityEvent onChanged;

    public static EnemiesManager instance;

    void Awake()
    {

        if (instance == null)
        {
            instance = this; 
        }
        else
        {
            Destroy(gameObject); 
            return;
        }
    }

    public void AddEnemy(Enemy enemy) {
        enemies.Add(enemy);
        onChanged.Invoke();
    }

    public void RemoveEnemy(Enemy enemy) {
        enemies.Remove(enemy);
        onChanged.Invoke();
    }

}

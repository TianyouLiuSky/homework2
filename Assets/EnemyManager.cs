using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyManager : MonoBehaviour
{
    public static EnemyManager instance;

    public UnityEvent onChanged = new UnityEvent();

    public List<GameObject> enemies = new List<GameObject>();

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Example: Call this when an enemy dies
    public void RemoveEnemy(GameObject enemy)
    {
        enemies.Remove(enemy);
        onChanged.Invoke(); // Trigger UI update
    }

    // Example: Call this when an enemy spawns
    public void AddEnemy(GameObject enemy)
    {
        enemies.Add(enemy);
        onChanged.Invoke(); // Trigger UI update
    }
}

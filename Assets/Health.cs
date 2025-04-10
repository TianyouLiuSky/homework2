using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public float amount;
    public UnityEvent onDeath;



    void Update() {
        if(amount <= 0) {
            onDeath.Invoke();
            Destroy(gameObject);
        }
    }

    private void Awake()
    {
        var life = GetComponent<Life>();
        life.onDeath.AddListener(GivePoints);
    }

    void GivePoints() {
        ScoreManager.instance.amount += (int)amount;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    // Start is called before the first frame update
    public int amount;

    void OnDestroy()
    {
        ScoreManager.instance.amount += amount;
    }
}

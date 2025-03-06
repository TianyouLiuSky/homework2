using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static ScoreManager instance;

    public int amount;

    void Awake()
    {
        if (instance == null) {
            instance = this;
        } else {
            print("Duplicate ScoreManager, ignoring this one");
        }
    }
}

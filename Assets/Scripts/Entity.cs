using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    private float health;
    public int destroyedTargets;

    public float Health
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
          

            if(health <= 0f) {
            Destroy(gameObject);
            }
        }
    }

    void Start()
    {
        Health = startingHealth;
    }

}

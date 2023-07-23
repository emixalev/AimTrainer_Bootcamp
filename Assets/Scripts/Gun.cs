using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public UnityEvent OnGunShoot;
    public float fireCooldown;
    public bool Auto;
    public float currentCooldown;
    // Start is called before the first frame update
    void Start()
    {
        currentCooldown = fireCooldown;

    }

    // Update is called once per frame
    void Update()
    {
        if (Auto)
        {
            if (Input.GetMouseButton(0))
            {
                if (currentCooldown <= 0f)
                {
                    OnGunShoot?.Invoke();
                    currentCooldown = fireCooldown;
                    
                }

            }
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (currentCooldown <= 0f)
                {
                    OnGunShoot?.Invoke();
                    currentCooldown = fireCooldown;
                }
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;
using UnityEngine.UI;


public class gunDamage : MonoBehaviour
{
    public float damage;
    public float bulletRange;
    private Transform PlayerCamera;
    public int killCount=0;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        PlayerCamera = Camera.main.transform;
    }
public void Shoot()
    {
        Ray gunRay = new Ray(PlayerCamera.position, PlayerCamera.forward);
        if(Physics.Raycast(gunRay, out RaycastHit hitInfo, bulletRange)) 
        {
            if(hitInfo.collider.gameObject.TryGetComponent(out Entity enemy)) {
                enemy.Health -= damage;
                killCount++;

            }
        }
    }
    private void Update()
    {
        scoreText.text = killCount.ToString();
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character, IShootable
{
    public float ReloadTime { get; set; }
    public float WaitTime { get; set; }
    Transform spawnPoint;
    GameObject bullet;
    [field: SerializeField]public Transform SpawnPoint { get; set; }
    [field: SerializeField] public GameObject Bullet { get; set; }
    void Start()
    {
        WaitTime = 0.0f;
        ReloadTime = 1.0f;
        Init(100);
    }
    private void FixedUpdate()
    {
        WaitTime += Time.fixedDeltaTime;
    }
    public void Shoot()
    {
        if (Input.GetMouseButtonDown(0) && WaitTime > ReloadTime)
        {
            GameObject obj = Instantiate(Bullet, SpawnPoint.position, Quaternion.identity);
            WaitTime = 0;
        }
    }
    private void Update()
    {
        Shoot();
    }
}
   


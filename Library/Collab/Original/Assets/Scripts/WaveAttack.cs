// using System;
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
//
// public class WaveAttack : MonoBehaviour {
//     // sin bullet prefab
//     public GameObject bullet;
//     private int _bulletGuid;
//
//     public int amountToSpawn;
//     private int currentNumber;
//
//     // Start is called before the first frame update
//     private void Start() {
//         _bulletGuid = bullet.GetComponent<GUID>().guid;
//     }
//
//     private void Update() {
//         if (currentNumber == amountToSpawn) {
//         }
//
//         if (currentNumber > amountToSpawn) {
//             currentNumber = amountToSpawn;
//         }
//
//         if (currentNumber < amountToSpawn) {
//             var pos = transform.position;
//             pos.y += (float)currentNumber/2;
//             pos.x = (float) Mathf.Sin(Mathf.Rad2Deg * Time.deltaTime);
//             SpawnBullet(pos, transform.rotation);
//             currentNumber += 1;
//         }
//     }
//
//     public void SpawnBullet(Vector2 position, Quaternion rotation) {
//         BulletManager.Spawn(_bulletGuid, position, rotation);
//     }
// }
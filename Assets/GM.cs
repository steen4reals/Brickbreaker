﻿// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine.UI;

// public class GM : MonoBehaviour
// {   
//     public int lives = 3;

//     public int bricks = 20;

//     public float resetDelay = 1f;

//     //public Text livesText;

//     //public GameObject gameOver;

//     //public GameObject youWon;

//     //public GameObject paddle;

//     //public GameObject bricksPrefab;

//     public static GM instance = null;

//     private GameObject clonePaddle;
//     // Start is called before the first frame update
//     void Start()
//     {
//         if(instance == null)
//         instance = this;
//         else if (instance != this)
//         Destroy(gameObject);

//        // Setup();
//     }

//     // public void Setup(){
//     //     clonePaddle = Instantiate(paddle, transform.position, Quaternion.identity) as GameObject;
//     //     Instantiate(bricksPrefab, transform.position, Quaternion.identity);
//     // }

//     void CheckGameOver(){
//         if (bricks<1){
//             youWon.SetActive(true);
//             Time.timeScale = .25f;
//             Invoke("Reset", resetDelay);
//         }

//         if(lives<1){
//             gameOver.SetActive(true);
//             Time.timeScale = .25f;
//             Invoke("Reset", resetDelay);
//         }
//     }

//     void Reset(){
//         Time.timeScale = 1f;
//         Application.LoadLevel(Application.loadedlevel);
//     }

//     // Update is called once per frame
//     public void LoseLife(){
//         lives --;
//         livesText.text = "Lives" + lives;
//         Destroy(clonePaddle);
//         Invoke("SetupPaddle", resetDelay);
//         CheckGameOver();
//     }

//     void SetupPaddle(){
//         clonePaddle = Instantiate(paddle, transform.position, Quaternion.identity) as GameObject;
//     }

//     public void DestroyBrick(){
//         bricks --;
//         CheckGameOver();
//     }
// }

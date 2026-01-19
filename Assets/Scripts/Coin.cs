using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    //Link to other game objects and prefabs
    [SerializeField] private CoinCountUI CoinCountUI;
    [SerializeField] private Coin coinPrefab;

    //Coin moving speed
    [SerializeField] private float coinSpeed = 2f;

    //Random.Range(time till next appear)
    [SerializeField] private float coinAppearSoonest = 0.1f;
    [SerializeField] private float coinAppearSlowest = 3f;

    //y-level coin will appear
    [SerializeField] private float coinAppearLevel = 1f;
    [SerializeField] private Transform _ground;

    //Distance from the previous coin
    [SerializeField] private float coinAppearDistance = 1f;

    //Timer
    private float timer = 0f;
    private float nextCoinAppearTime;

    //Coin controller
    public bool coinController = false;

    


    // Start is called before the first frame update
    void Start()
    {
        if (coinController)
        {
            TimeforNextCoinAppear();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (coinController)
        {
            timer += Time.deltaTime;
            if (timer >= nextCoinAppearTime)
            {
                NextCoinAppear();
                timer = 0f;
                TimeforNextCoinAppear();
            }
        }
        else
        {
            MoveCoin();
        }


    }

    //Set time for next coin to appear
    void TimeforNextCoinAppear()
    {
        nextCoinAppearTime = Random.Range(coinAppearSoonest,coinAppearSlowest);
    }

    //Move coin
    void MoveCoin()
    {
        transform.Translate(Vector2.left * coinSpeed * Time.deltaTime);
    }

    //Call next coin to appear
    void NextCoinAppear()
    {
        //Initial position.x
        Camera mainCamera = Camera.main;
        float coinInitialPlace = mainCamera.ViewportPointToRay(new Vector3(1, 0, mainCamera.nearClipPlane)).origin.x + 1f;

        //Position.y
        float level = _ground.position.y + coinAppearLevel;
        Vector3 position = new Vector3(coinInitialPlace, level, 0);

        Coin newCoin = Instantiate(coinPrefab,position,transform.rotation);
        newCoin.CoinCountUI = CoinCountUI;
    }

    //Collision with player to add score
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && !coinController)
        {
            CoinCountUI.EatACoin();
            Destroy(gameObject);
        }
    }
}

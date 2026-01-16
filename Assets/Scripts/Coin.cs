using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    //[SerializeField] private float appear = 10f;
    [SerializeField] private int coinSpeed = 2;
    [SerializeField] private float disappear = -10f;
    [SerializeField] private Transform _bird;
    [SerializeField] private float groundLevel = 1f;
    [SerializeField] private float close = 1f;
    [SerializeField] private float far = 3f;
    [SerializeField] private float waitTill = 0.1f;
    private static float next = 10f;
    private bool appeared = false;
    private bool ready = false;
    private float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        if(appeared == false)
        {
            appeared = true;
            ready = true;
            timer = waitTill;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * coinSpeed * Time.deltaTime);
        if (ready)
        {
            timer -= Time.deltaTime;
            if (timer <= 0f)
            {
                NextAppear();
            }

        }
        if (transform.position.x < disappear)
        {
            Destroy(gameObject);
        }
    }

    void NextAppear()
    {
        next += Random.Range(close,far);
        float level = _bird.position.y + groundLevel;
        Vector3 position = new Vector3(next, level, 0);
        Instantiate(gameObject,position,transform.rotation);
        timer = waitTill;
    }
}

using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject[][] _gridContains;

    public Vector2 playerHeadPos;

    public Queue<Vector2> playerPos;

    public int _score = 0;
    public int _scoreMul = 100;

    public TMP_Text _livesText;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(this);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InitGrid();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InitGrid()
    {
        transform.position = new Vector3(0, 0, -1);
        transform.rotation = Quaternion.identity;
        transform.localScale = new Vector3(0.01f, 0.01f, 1);

        Image borderBG = gameObject.AddComponent<Image>();

        Texture2D boarderTex = DrawManager.SingleTex(Color.gray);


    }

    public void Move()
    {

    }

    public void AddScore(int score)
    {
        _score += score * _scoreMul;
    }

    public void TakeDamage()
    {
        Time.timeScale = 0;
    }
}

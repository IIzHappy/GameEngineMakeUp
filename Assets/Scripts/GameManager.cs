using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    GameObject[][] _grid = new GameObject;

    public int _score = 0;
    public int _lives = 3;
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

        DrawManager.instance
    }

    public void AddScore(int score)
    {
        _score += score * _scoreMul;
    }

    public void TakeDamage()
    {
        _lives -= 1;
        _livesText.text = "Lives: " + _lives.ToString();
        if (_lives <= 0)
        {
        }
    }
}

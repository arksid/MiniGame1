using UnityEngine;

public class Game : MonoBehaviour
{
    public string PlayerName;
    public int Score;
    public int HP;
    public float GameTimer;
    public bool IsPlay;


    public void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {
        if(!IsPlay)
        {
            Debug.Log("게임이 끝났습니다.");
            return;
        }
        GameTimer -= Time.deltaTime;
        if(GameTimer<0)
        {
            IsPlay = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
     
        bool isEnemy = other.gameObject.tag == "Enmey";
        bool isItem = other.gameObject.tag == "Item";

        if (isEnemy)
        {
            Debug.Log("Enemy Check");
            HP -= 1;
            if (HP <= 0)
            {
                IsPlay = false;
            }


        }

        if (isItem)
        {
            Debug.Log("Item Check");
            Score += 1;

        }
        Destroy(other.gameObject);
    }
}


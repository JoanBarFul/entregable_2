using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private bool isGameOver = false;

    private int playerhp = 100;

    public int damage = 30;

    // Start is called before the first frame update
    void Start()
    {
        playerhp = (playerhp - damage);
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver == false)
        {

            if (playerhp <= 0)
            { Debug.Log("Te has quedado sin vida… GAME OVER"); }
            else if (playerhp < 20)
            { Debug.Log("¡Tienes poca vida!"); }
            else
            { Debug.Log($"Vas bien de vida: tienes {playerhp} puntos de vida"); }
        }
        else
        { Debug.Log("GAME OVER"); }
    }
}

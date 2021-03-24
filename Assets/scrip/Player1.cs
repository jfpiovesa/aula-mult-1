using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;

public class Player1 : MonoBehaviour
{
    float frente;// valor movimentação frente
    float girar;// valor movimentaçao girar

    [Header("bullet")]
    public GameObject spawn;// spawn da bala
    public GameObject bullet;// bala

    [Header("life")]
    private float lifetanque = 100f;
    public Image lifefill;
    public float playerhealthCurrent = 0f;

    public KeyCode[] key;// para ficar mais facil modificar a movimentação do players

    public GameObject[] spawLoca;// local de spawn do player
    public GameObject spawPrefab;
   
    public int _valor1, _valor2;// valores de vitorias ou mortes de um player contra outro 


   
    void Start()
    {
        frente = 10;
        girar = 60;
     

        HealthManager(lifetanque);
    }


    void Update()
    {

       

        if (Input.GetKey(key[0]))
        {
            transform.Translate(0, 0, (frente * Time.deltaTime));
        }

        if (Input.GetKey(key[1]))
        {
            transform.Translate(0, 0, (-frente * Time.deltaTime));
        }

        if (Input.GetKey(key[2]))
        {
            transform.Rotate(0, (-girar * Time.deltaTime), 0);
        }
        if (Input.GetKey(key[3]))
        {
            transform.Rotate(0, (girar * Time.deltaTime), 0);
        }
        if (Input.GetKeyDown(key[4]))
        {
            Shoot();
        }
        Spawn(_valor1, _valor2);
       
    }
    void Shoot()//tira da bala instaciando ela
    {
        Instantiate(bullet, spawn.transform.position, spawn.transform.rotation);
    }
    public void HealthManager(float value)// valor vida do player 
    {

        playerhealthCurrent += value;
        lifefill.fillAmount = playerhealthCurrent / 100;

    }


    void Spawn(int valor1, int valor2)// spawn  do player se a vida ficar 0
    {
       
        
        if (lifefill.fillAmount <= 0f)
        {
            transform.position = spawLoca[Random.Range(0, spawLoca.Length)].transform.position;
            HealthManager(lifetanque);
            ManagerScor.managerScor.Score(valor1,valor2);
        }
    }
    
}

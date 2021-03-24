using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerScor : MonoBehaviour
{

    public Text[] scor;
    int valorscor1 = 0, valorscor2 = 0;

    public static ManagerScor managerScor;

    public GameObject vitoria1;
    public GameObject vitoria2;

    public GameObject Text1;
    private void Awake() // instatinado o script
    {
        if(managerScor == null)
        {
           managerScor = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // comversao de numeros pra letras 
        scor[0].text = valorscor1.ToString();
        scor[1].text = valorscor2.ToString();
        vitoria1.SetActive(false);
        vitoria2.SetActive(false);

        Destroy(Text1, 5f);

    }

    // Update is called once per frame
    void Update()
    {
        scor[0].text = valorscor1.ToString();
        scor[1].text = valorscor2.ToString();

        Victoria();

    }

    public void Score(int valuer1,int valuer2)
    {
        valorscor1 += valuer1;// valor do player 1 de quantas vezes matou o inimigo
        valorscor2 += valuer2;// valor do player 2 de quantas vezes matou o inimigo
    }

    void  Victoria()
    {

        if(valorscor1 >= 10)
        {
            vitoria1.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            vitoria1.SetActive(false);
            Time.timeScale = 1;
        }
        if(valorscor2 >= 10)
        {
            vitoria2.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            vitoria2.SetActive(false);
            Time.timeScale = 1;
        }
       
    }
  
}

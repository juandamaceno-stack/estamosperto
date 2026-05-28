using UnityEngine;
using TMPro;

public class Pontuação : MonoBehaviour
{
    public float Pontuacao;
    public float ValorDaMoeda;
    public float PontuaçãoPorTempo=1f;
    
    public GameObject TELADEMORTE;
    public TextMeshProUGUI textoDaPontuacao;

    void FixedUpdate()
    {
     if(TELADEMORTE.activeSelf == false)
        {
        Pontuacao=PontuaçãoPorTempo+Pontuacao;

        textoDaPontuacao.text = "Pontos: " + Pontuacao;
        }
        
    }

}

using UnityEngine;
using System.Collections;
public class Movimento : MonoBehaviour
{
  public SpriteRenderer spriteRenderer;

  public Sprite spriteNormal;
  public Sprite spriteCanudo;
  public Sprite spriteEscudo;
  public Sprite spriteBebida;

   public GameObject Canudo;
   public GameObject Bebida;
   public GameObject Escudo;

   public float Vida=1;
   private float VelocidadeMaxima;
   private float VelocidadeWS;
   private float VelocidadeAD;
   private float velocidadeNormal;

   public float VelocidadeFinal;
   public float TaxaDeAcerelacao=1.0005f;
   public float VelocidadeDeMovimentoArrasto=10f;
   public float VelocidadeDeMovimento=20f;

   private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        velocidadeNormal = VelocidadeDeMovimentoArrasto;
    }
    void Update()
   {
        if (Input.GetKeyDown(KeyCode.Q))
    {
        //if (Canudo.activeSelf)
       // {
       //  StartCoroutine(BuffVelocidade(60f, 3f));

       //     Canudo.SetActive(false);
      //  }
         if (Escudo.activeSelf)
        {
          spriteRenderer.sprite = spriteEscudo;
          Vida=2;
          Escudo.SetActive(false);
        }
        else if (Bebida.activeSelf)
        {
            StartCoroutine(BuffVelocidade(60f, 3f));
            spriteRenderer.sprite = spriteBebida;
            Bebida.SetActive(false);
        }
    }
   }

    void FixedUpdate()
    {

    float TaApertandoAOuDOuSetinha = 0f;
    float TaApertandoWOuSOuASetinha = 0f;

       if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) TaApertandoWOuSOuASetinha += 1f;
       if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) TaApertandoWOuSOuASetinha -= 1f;
       if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) TaApertandoAOuDOuSetinha += 1f;
       if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) TaApertandoAOuDOuSetinha -= 1f;

       if(VelocidadeDeMovimentoArrasto<100)
       {
        VelocidadeDeMovimentoArrasto = VelocidadeDeMovimentoArrasto*TaxaDeAcerelacao;
       } 


        VelocidadeWS = TaApertandoWOuSOuASetinha * VelocidadeDeMovimento;
        VelocidadeAD = TaApertandoAOuDOuSetinha * VelocidadeDeMovimento;
        Vector2 VelocidadeCombinada = new Vector2(VelocidadeAD, VelocidadeWS);
        Vector2 VelocidadeDeArrasto = new Vector2(-VelocidadeDeMovimentoArrasto, 0f);

          Vector2 VelocidadeFinal = VelocidadeCombinada + VelocidadeDeArrasto;
        
            rb.linearVelocity = VelocidadeFinal;

    }
     
     IEnumerator BuffVelocidade(float bonus, float duracao)
    {
   
        VelocidadeDeMovimentoArrasto += bonus;

        yield return new WaitForSeconds(duracao);

        VelocidadeDeMovimentoArrasto = VelocidadeDeMovimentoArrasto - bonus;
    }
}

using UnityEngine;

public class MovimentoCamera : MonoBehaviour
{
   private Rigidbody2D rb;
   private Movimento movimento;
   public GameObject TELADEMORTE;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       movimento = FindFirstObjectByType<Movimento>();
    }
    void FixedUpdate()
    {   
        if(TELADEMORTE.activeSelf == false)
        {
        Vector2 VelocidadeFinalCamera = new Vector2(-movimento.VelocidadeDeMovimentoArrasto,0f);
          rb.linearVelocity = VelocidadeFinalCamera;
        }
       else
       {
        Vector2 VelocidadeFinalCamera = new Vector2(0f,0f);
          rb.linearVelocity = VelocidadeFinalCamera;
       }
    }
}

using System.Collections.Generic;
using UnityEngine;

public class protagonista : MonoBehaviour {

    private Rigidbody2D body;
    private SpriteRenderer imagem;

    private SpriteRenderer foco;

    private float horizontal;
    private float vertical;

    private bool isAtirando = false;

    [SerializeField] private List<Sprite> sprites;

    [Range(0, 10.0f)][SerializeField] private float velocidade = 3.0f;

    void Start() {
        body = GetComponent<Rigidbody2D>(); 
        imagem = GetComponent<SpriteRenderer>();
        imagem.sprite = sprites[0];

        foco = transform.GetChild(1).GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate() {
        body.velocity = new Vector2(
            horizontal * ((isAtirando) ? velocidade/2 :velocidade),
            vertical * ((isAtirando) ? velocidade/2 :velocidade)
        );
        foco.enabled = isAtirando;
        imagem.sprite = sprites[(horizontal == 0) ? 0 : 1];
        imagem.flipX = horizontal == 1;
    }

    void Update() {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        isAtirando = Input.GetButton("Fire1");
        GetComponentInChildren<Atirador>().deveAtirar = isAtirando;
        GetComponentInChildren<Atirador>().deveEspecial = Input.GetButton("Fire2");
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        TiroBoomerang script = collision.GetComponent<TiroBoomerang>();
        if (script != null && script.isVoltando) {
            GetComponent<Stats>().addEspecial();
            Destroy(collision.gameObject);
        }
    }

}

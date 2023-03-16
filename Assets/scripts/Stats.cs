using UnityEngine;

public class Stats : MonoBehaviour {

    /// <summary>
    /// Pra protagonista vai de 0 a 99, 0 quer dizer q vc morreu :(
    /// </summary>
    [SerializeField] private int vida = 4;

    /// <summary>
    /// Pra protagonista vai de 0 a 99, pra add mais precisa mudar o jeito q esse valor é exibido na interface
    /// </summary>
    [SerializeField] private int especial = 2;

    [SerializeField] private TipoEntidade tipoEntidade;

    string tiroQMachuca;

    /// <summary>
    /// Usado pela protagonista pra sinalizar que a interface precisa ser atualizada com novos valores
    /// </summary>
    private bool mudarInterface = true;

    void Start() {
        tiroQMachuca = tipoEntidade.Equals(TipoEntidade.INIMIGO) ? "TiroBom" : "TiroRuim";
    }

    void Update() {
        if (vida <= 0) {
            if (tipoEntidade.Equals(TipoEntidade.INIMIGO)) {
                transform.GetComponent<inimigo>().dropaLoot();
            } else {
                //game over
            }
            Destroy(gameObject);
        }
            
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag.Equals(tiroQMachuca)) {
            rmvVida(collision.GetComponent<Tiro>().dano);
        } else if (collision.gameObject.tag.Equals("Poder") && tipoEntidade.Equals(TipoEntidade.PROTAGONISTA)) {
            collision.GetComponent<Poder>().coletar(this);
        }
    }

    public int getEspecial() {
        return especial;
    }

    public void addEspecial(int especial) {
        especial += especial;
        if (especial >= 99)
            especial = 99;
        if (tipoEntidade.Equals(TipoEntidade.PROTAGONISTA))
            mudarInterface = true;
    }

    public void rmvEspecial() {
        if (especial > 0)
            especial -= 1;
        if (tipoEntidade.Equals(TipoEntidade.PROTAGONISTA))
            mudarInterface = true;
    }

    public int getVida() {
        return vida;
    }

    public void addVida() {
        if (vida < 99)
            vida += 1;
        if (tipoEntidade.Equals(TipoEntidade.PROTAGONISTA))
            mudarInterface = true;
    }

    public void rmvVida(int vida) {
        this.vida -= vida;

        if (this.vida < 0)
            this.vida = 0;
        if (tipoEntidade.Equals(TipoEntidade.PROTAGONISTA))
            mudarInterface = true;
    }

    public bool deveMudarInterface() {
        return mudarInterface;
    }

    public void interfaceAtualizada() {
        mudarInterface = false;
    }
    
}

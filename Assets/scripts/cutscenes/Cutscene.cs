using UnityEngine;

public class Cutscene : MonoBehaviour {
    [SerializeField] private TMPro.TextMeshProUGUI caixaDialogos;

    private string[] falas = {};

    protected int i = 0;


    void Start() {
        caixaDialogos.SetText(falas[0]);
    }

    protected void setFalas(string[] falas) {
        this.falas = falas;
    }

    public void setProximaFala() {
        i++;
        caixaDialogos.SetText(falas[i%falas.Length]);
    }

}

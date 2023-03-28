using UnityEngine;

public class Cutscene001 : MonoBehaviour {

    private int i = 0;

    private string[] falas = {
        "Princesa! Finalmente te encontrei!!1!",
        "Aff, cara. Larga do meu pé.",
        "Mas Princesa, eu não sei escrever diálogos...",
        "Só coloca qualquer coisa, cara, ninguém vai ler.",
        "Eu preciso de sete linhas pra testar os diálogos, mas só tenho cinco até agora!",
        "Seis.",
        "Obrigado, princesa, só queria isso mesmo, até mais. Se cuida, queridona."
    };

    [SerializeField] private TMPro.TextMeshProUGUI caixaDialogos;

    void Start() {
        caixaDialogos.SetText(falas[0]);
    }

    void Update() {
        
    }

    public void setProximaFala() {
        i++;
        caixaDialogos.SetText(falas[i%falas.Length]);
    }

}

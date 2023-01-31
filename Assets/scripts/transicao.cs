using UnityEngine;
using UnityEngine.SceneManagement;

public class transicao : MonoBehaviour {

    [SerializeField]
    private string proximaCena;

    void Start() {
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Z))
            SceneManager.LoadScene(proximaCena);
    }
}

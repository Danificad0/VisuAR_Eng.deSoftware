using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    private Button button;
    public string sceneName;

    private void Start()
    {
        // Obtém o componente Button anexado ao mesmo objeto em que este script está
        button = GetComponent<Button>();

        // Adiciona um listener ao botão para chamar a função ChangeScene quando clicado
        button.onClick.AddListener(ChangeScene);
    }

    private void ChangeScene()
    {
        // Carrega a cena especificada pelo nome
        SceneManager.LoadScene(sceneName);
    }
}

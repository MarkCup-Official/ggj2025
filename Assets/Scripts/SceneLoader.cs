
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void Load(string id)
    {
        SceneManager.LoadScene(id);
    }
}

public class GameManager : MonoBehaviour
{
    // A instância estática do Singleton
    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        // Se já existe uma instância e não é esta, destrua o objeto para garantir que haja apenas uma instância
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            // Configura esta instância como a instância Singleton
            Instance = this;
            // Opcional: faz com que este objeto não seja destruído ao carregar uma nova cena
            DontDestroyOnLoad(gameObject);
        }
    }
}
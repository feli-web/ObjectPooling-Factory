using UnityEngine;
using UnityEngine.UI;

public class ObjectCreator : MonoBehaviour
{
    public GameObject arbustoPrefab;
    public GameObject rocaPrefab;
    public GameObject arbolPrefab;

    public Button arbustoButton;
    public Button rocaButton;
    public Button arbolButton;

    private Factory arbustoFactory;
    private Factory rocaFactory;
    private Factory arbolFactory;

    void Start()
    {
        arbustoFactory = new ArbustoFactory(arbustoPrefab);
        rocaFactory = new RocaFactory(rocaPrefab);
        arbolFactory = new ArbolFactory(arbolPrefab);

        arbustoButton.onClick.AddListener(CreateArbusto);
        rocaButton.onClick.AddListener(CreateRoca);
        arbolButton.onClick.AddListener(CreateArbol);
    }

    void CreateArbusto()
    {
        arbustoFactory.CreateObject();
    }

    void CreateRoca()
    {
        rocaFactory.CreateObject();
    }

    void CreateArbol()
    {
        arbolFactory.CreateObject();
    }
}


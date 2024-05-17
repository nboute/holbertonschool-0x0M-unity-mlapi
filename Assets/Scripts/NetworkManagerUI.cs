using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class NetworkManagerUI : MonoBehaviour
{
    [SerializeField] private Button hostButton;
    [SerializeField] private Button clientButton;
    [SerializeField] private Button serverButton;


    public void StartHost() {
        Debug.Log("Starting Host");
        NetworkManager.Singleton.StartHost();
    }
    public void StartClient() {
        Debug.Log("Starting Client");
        NetworkManager.Singleton.StartClient();
    }

    public void StartServer() {
        Debug.Log("Starting Server");
        NetworkManager.Singleton.StartServer();
    }
}

using Fusion;
using UnityEngine;

namespace Spherum
{
    public class EntryPoint : MonoBehaviour
    {
        [SerializeField] private NetworkRunner _networkRunner;
        [SerializeField] private NetworkSceneManagerDefault _networkScene;

        private async void Awake()
        {
            await _networkRunner.StartGame(new StartGameArgs()
            {
                GameMode = GameMode.Shared,
                SessionName = "Spherum",
                SceneManager = _networkScene
            });
        }
    }
}
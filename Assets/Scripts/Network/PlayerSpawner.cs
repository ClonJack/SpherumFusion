using Fusion;
using Unity.Mathematics;
using UnityEngine;

namespace Spherum.Network
{
    public class PlayerSpawner : SimulationBehaviour, IPlayerJoined
    {
        [SerializeField] private GameObject _playerPrefab;

        public void PlayerJoined(PlayerRef player)
        {
            if (player == Runner.LocalPlayer)
            {
                Runner.Spawn(_playerPrefab, new Vector3(0, 1, 0), quaternion.identity, player);
            }
        }
    }
}
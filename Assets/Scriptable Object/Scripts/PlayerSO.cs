using UnityEngine;

[CreateAssetMenu(fileName = "Player", menuName = "Character/Player")]
public class PlayerSO : ScriptableObject
{
    [field: SerializeField] public PlayerGroundData GroundedData { get; private set; }
    [field: SerializeField] public PlayerAirData AirData { get; private set; }
}

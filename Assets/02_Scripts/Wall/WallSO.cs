using UnityEngine;

[CreateAssetMenu(fileName = "WallData", menuName = "SO/WallData")]
public class WallSO : ScriptableObject
{
    public enum WallType { earth, wood, stone, ore, virtualMineral }


    public enum WallClass { first, second, third }

    public enum DestructionType { }

    public enum WallPrefabType { normal, boss }

    [Header("벽 설정")]
    public string wallName;
    public int maxHealth;    
    public WallPrefabType prefabType;
    public WallType wallType;
    public WallClass wallClass;
    public bool isBoss;

    [Header("벽 색상 / 텍스쳐 설정")]
    public Material wallMaterial;
    public Texture2D wallTexture;    

    [Header("보상 계수")]
    public int rewardCount; //보상은 나중에 다른데서 관리할수 있음
}

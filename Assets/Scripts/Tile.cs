using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Tile : MonoBehaviour
{
    public GameObject TileObject;
    public Image TileImage;
    public Text TileText;

    public uint TileValue;
    public Color Color;

}
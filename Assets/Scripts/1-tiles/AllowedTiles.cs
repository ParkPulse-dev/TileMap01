using System.Linq;
using UnityEngine;
using UnityEngine.Tilemaps;

/**
 * This component just keeps a list of allowed tiles.
 * Such a list is used both for pathfinding and for movement.
 */
public class AllowedTiles : MonoBehaviour
{
    [SerializeField] TileBase[] allowedTiles = null;



    public bool Contains(TileBase tile)
    {
        GameObject boat = GameObject.Find("boat");
        GameObject goat = GameObject.Find("goat");
        GameObject pick = GameObject.Find("pick");
        if (boat == null)
        {
            if (tile.ToString().Contains("sea"))
                return true;
        }
        if (goat == null || pick == null)
        {
            if (tile.ToString().Contains("mountains"))
                return true;
        }

        return allowedTiles.Contains(tile);
    }

    public void Set(TileBase[] new_tiles)
    {
        allowedTiles = new_tiles;
    }

    public TileBase[] Get() { return allowedTiles; }

}

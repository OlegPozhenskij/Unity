using UnityEngine;


[CreateAssetMenu(fileName = "ItemData", menuName = "Custom/Item")]
public class ItemProperties : ScriptableObject
{
    public Sprite itemSprite;
    public string countOfItems;
    
    public static PanelProperties Load(string name)
    {
        return Resources.Load("Data/Items/" + name) as PanelProperties;
    }
}

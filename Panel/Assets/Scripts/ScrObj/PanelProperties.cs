using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PanelData", menuName = "Custom/Panel")]
public class PanelProperties : ScriptableObject
{
    public string title;
    public string description;
    public List<ItemProperties> items;
    public string price;
    public string discount;
    public Sprite panelSprite;
    
    public static PanelProperties Load(string name)
    {
        return Resources.Load("Data/Panels/" + name) as PanelProperties;
    }
}

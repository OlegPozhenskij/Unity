using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Controller : MonoBehaviour
{
    [FormerlySerializedAs("window")] 
    [SerializeField] private DemoView contentWindow;
    
    private List<PanelProperties> _panelStorage = new List<PanelProperties>();
    
    private void Awake()
    {
        AddPanel(PanelProperties.Load("PanelWood"));
        AddPanel(PanelProperties.Load("StarterPackPanel"));
    }
    
    private void AddPanel(PanelProperties panel)
    {
        _panelStorage?.Add(panel);
    }
    
    private void Start()
    {
        foreach (var panelProperties in _panelStorage)
        {
            var panel = Instantiate(contentWindow.PanelPref, contentWindow.transform);
            Redraw(panelProperties, panel.GetComponent<View>());
        }
    }

    private void Redraw(PanelProperties panelProperties, View unityPanel)
    {
        unityPanel.Title.text = panelProperties.title;
        unityPanel.MainImg.sprite = panelProperties.panelSprite;
        unityPanel.Description.text = panelProperties.description;
        
        SetPriceButton(panelProperties.price, panelProperties.discount, unityPanel);

        SetItems(panelProperties.items, unityPanel);
    }

    private void SetPriceButton(string price, string discount, View unityPanel)
    {
        if (int.Parse(discount) == 0)
        {
            unityPanel.FixedPrice.gameObject.SetActive(false);
            unityPanel.DiscountImg.gameObject.SetActive(false);
            unityPanel.Price.text = $"{price}$";
        }
        else
        {
            string resultPrice = (float.Parse(price) * (float.Parse(discount) / 100)).ToString();
            unityPanel.Price.text = $"{resultPrice}$";
            unityPanel.Discount.text = $"-{discount}%";
            unityPanel.FixedPrice.text = $"{price}$";
        }
    }
    
    private void SetItems(List<ItemProperties> sprites, View unityPanel)
    {
        foreach (var sprite in sprites)
        { 
            var item = Instantiate(unityPanel.MainItem, unityPanel.Grid.transform);
            
            item.GetComponent<ItemScript>().ItemCount.text = sprite.countOfItems;
            item.GetComponent<SpriteRenderer>().sprite = sprite.itemSprite;
        }
    }
}

using UnityEngine;
using UnityEngine.UI;

public class View : MonoBehaviour
{
    [SerializeField] private Text title;
    [SerializeField] private Image mainImg;
    [SerializeField] private Text description;
    
    [SerializeField] private Text price;
    [SerializeField] private Text discount;
    [SerializeField] private Text fixedPrice;
    [SerializeField] private Image discountImg;
    
    [SerializeField] private GridLayoutGroup grid;
    [SerializeField] private GameObject mainItem;

    public Text Title => title;

    public Image MainImg => mainImg;

    public Text Description => description;

    public Text Price => price;

    public Text Discount => discount;

    public Text FixedPrice => fixedPrice;

    public Image DiscountImg => discountImg;

    public GridLayoutGroup Grid => grid;

    public GameObject MainItem => mainItem;
}

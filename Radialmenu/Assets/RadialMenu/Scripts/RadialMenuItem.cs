using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RadialMenuItem : MonoBehaviour
{
    public Image ItemBG;
    public Image ItemPic;
    public Sprite BgUnSelected;
    public Sprite BgSelected;

    public void OnUse()
    {
        Debug.Log("I'm used");
    }

    public void SetItemState(bool ItemState)
    {
        if (ItemState)
        {
            ItemBG.sprite = BgSelected;
        }
        else
        {
            ItemBG.sprite = BgUnSelected;
        }
    }
}

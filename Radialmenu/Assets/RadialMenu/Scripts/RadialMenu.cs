using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadialMenu : MonoBehaviour
{
    public GameObject[] RadialMenuItems;
    public AudioSource AudSourc;
    public AudioClip MovementClip;
    public AudioClip UseClip;
    Vector2 NormalizedMPose;
    float AngleOfMouse;
    int SelectedItem;

    int PrevItemID=5;
    void Update()
    {
        NormalizedMPose = new Vector2(Input.mousePosition.x - Screen.width / 2, Input.mousePosition.y - Screen.height / 2);
        AngleOfMouse = Mathf.Atan2(NormalizedMPose.y, NormalizedMPose.x) * Mathf.Rad2Deg;
        AngleOfMouse = (AngleOfMouse + 360)%360;
        SelectedItem =(int) AngleOfMouse / 45;

        if (PrevItemID != SelectedItem)
        {
            AudSourc.PlayOneShot(MovementClip);
            RadialMenuItems[SelectedItem].GetComponent<RadialMenuItem>().SetItemState(true);
            RadialMenuItems[PrevItemID].GetComponent<RadialMenuItem>().SetItemState(false);
        }

        if (Input.GetKeyDown(KeyCode.E)|| Input.GetMouseButtonDown(0))
        {
            AudSourc.PlayOneShot(UseClip);
            RadialMenuItems[SelectedItem].GetComponent<RadialMenuItem>().OnUse();
        }

        PrevItemID = SelectedItem;
     }
}

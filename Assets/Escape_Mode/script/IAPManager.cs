using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Purchasing;
using UnityEngine.UI;
public class IAPManager : MonoBehaviour
{
  /*  private string infiniteLevel = "com.hyperappsvp.escapepro.infinitelevel";
    //public GameObject PlayButton;
    // public GameObject BuyButton;
    [SerializeField] GameObject soundonIcon;
    [SerializeField] GameObject soundoffIcon;
    private bool muted = false;
    public void OnPurchaseComplete(Product product)
    {
        if(product.definition.id == infiniteLevel)
        {
            //PlayButton.SetActive(true);
            //BuyButton.SetActive(false);
            OnButtonPress();
        }
    }
   public void OnpurchaseFailed(Product product, PurchaseFailureReason failureReason)
    {
        Debug.Log(product.definition.id + "Failed Because" + failureReason);
    }
    private void Start()
    {
        if (!PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
            load();
        }
        else
        {
            load();
        }
        updateButtonIcon();
        // AudioListener.pause = muted;
    }
    public void OnButtonPress()
    {
        if (muted == false)
        {
            muted = true;
            //   AudioListener.pause = true;
        }
        else
        {
            muted = false;
            // AudioListener.pause = false;
        }
        save();
        updateButtonIcon();
    }
    private void updateButtonIcon()
    {
        if (muted == false)
        {
            soundonIcon.SetActive(true);
            soundoffIcon.SetActive(false);
        }
        else
        {
            soundoffIcon.SetActive(true);
            soundonIcon.SetActive(false);
        }
    }
    private void load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
    }
    private void save()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }
  */
}

using System.Collections;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.Purchasing;
using System.Collections.Generic;


[Serializable]
public class NonConsumableItem
{
    public string Name;
    public string Id;
    public string desc;
    public float price;
}
[Serializable]



public class Shop_Script : MonoBehaviour, IStoreListener
{
    IStoreController m_StoreContoller;
    public NonConsumableItem ncItem;
   
    public Data data;
    public Payload payload;
    public PayloadData payloadData;
    private void Start()
    {
        int coins = PlayerPrefs.GetInt("totalCoins");
       
        SetupBuilder();
    }

    #region setup and initialize
    void SetupBuilder()
    {

        var builder = ConfigurationBuilder.Instance(StandardPurchasingModule.Instance());

      
        builder.AddProduct(ncItem.Id, ProductType.NonConsumable);
     

        UnityPurchasing.Initialize(this, builder);
    }
    public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
    {
        print("Success");
        m_StoreContoller = controller;
        CheckNonConsumable(ncItem.Id);
        
    }
    #endregion


    #region button clicks 
  

    public void NonConsumable_Btn_Pressed()
    {
        //RemoveAds();
        m_StoreContoller.InitiatePurchase(ncItem.Id);

    }

   
    #endregion


    #region main
    //processing purchase
    public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs purchaseEvent)
    {
        //Retrive the purchased product
        var product = purchaseEvent.purchasedProduct;

        print("Purchase Complete" + product.definition.id);

        if (product.definition.id == ncItem.Id)//non consumable
        {
            RemoveAds();
        }
       

        return PurchaseProcessingResult.Complete;
    }
    #endregion




    void CheckNonConsumable(string id)
    {
        if (m_StoreContoller != null)
        {
            var product = m_StoreContoller.products.WithID(id);
            if (product != null)
            {
                if (product.hasReceipt)//purchased
                {
                    RemoveAds();
                }
                else
                {
                    ShowAds();
                }
            }
        }
    }

    #region error handeling
    public void OnInitializeFailed(InitializationFailureReason error)
    {
        print("failed" + error);
    }

    public void OnInitializeFailed(InitializationFailureReason error, string message)
    {
        print("initialize failed" + error + message);
    }



    public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
    {
        print("purchase failed" + failureReason);
    }

    #endregion


    #region extra 

    [Header("Non Consumable")]
   // public GameObject AdsPurchasedWindow;
    public GameObject adsBanner;
    void RemoveAds()
    {
        DisplayAds(false);
    }
    void ShowAds()
    {
        DisplayAds(true);

    }
    void DisplayAds(bool x)
    {
        if (!x)
        {
          //  AdsPurchasedWindow.SetActive(true);
            adsBanner.SetActive(false);
            
        }
        else
        {
         //   AdsPurchasedWindow.SetActive(false);
            adsBanner.SetActive(true);
        }
    }

  

    #endregion

}


[Serializable]
public class SkuDetails
{
    public string productId;
    public string type;
    public string title;
    public string name;
    public string iconUrl;
    public string description;
    public string price;
    public long price_amount_micros;
    public string price_currency_code;
    public string skuDetailsToken;
}

[Serializable]
public class PayloadData
{
    public string orderId;
    public string packageName;
    public string productId;
    public long purchaseTime;
    public int purchaseState;
    public string purchaseToken;
    public int quantity;
    public bool acknowledged;
}

[Serializable]
public class Payload
{
    public string json;
    public string signature;
    public List<SkuDetails> skuDetails;
    public PayloadData payloadData;
}

[Serializable]
public class Data
{
    public string Payload;
    public string Store;
    public string TransactionID;
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;

public class SkinsManager : MonoBehaviour
{
    private void OnEnable()
    {
        YG2.onPurchaseSuccess += SuccessPurchased;
        YG2.onPurchaseFailed += FailedPurchased;
    }

    private void OnDisable()
    {
        YG2.onPurchaseSuccess -= SuccessPurchased;
        YG2.onPurchaseFailed -= FailedPurchased;
    }
    private void SuccessPurchased(string id)
    {
        EventManager.ByuSkin0(id);
    }

    private void FailedPurchased(string id)
    {
    }

}

﻿using System;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GameModule
{
    [AssetAddress("UIADSCollectReward", "UIADSCollectRewardV")]
    public class UIADSCollectRewardPopup : Popup
    {
        [ComponentBinder("Root/BottomGroup/CollectButton")]
        public Button buttonCollect;

        [ComponentBinder("Root/IntegralGroup/IntegralText")]
        public TMP_Text tmpTextIntegral;

        private Action _onClick;

        public UIADSCollectRewardPopup(string address) : base(address) { }

        protected override void BindingComponent()
        {
            base.BindingComponent();
            if (buttonCollect != null)
            {
                buttonCollect.onClick.AddListener(OnClick);
            }
        }

        public async Task FlyCoins(ulong coin, string source)
        {
            await XUtility.FlyCoins(buttonCollect.transform, new EventBalanceUpdate(coin, source));
        }

        public void Set(ulong count, Action onClick)
        {
            if (tmpTextIntegral != null)
            {
                tmpTextIntegral.text = count.GetCommaFormat();
            }

            _onClick = onClick;

            buttonCollect.interactable = true;
        }

        private void OnClick()
        {
            _onClick?.Invoke();

            _onClick = null;
            
            buttonCollect.interactable = false;
        }
    }
}

// **********************************************
// Copyright(c) 2021 by com.ustar
// All right reserved
// 
// Author : Jian.Wang
// Date : 2022/03/14/15:20
// Ver : 1.0.0
// Description : AlbumModal.cs
// ChangeLog :
// **********************************************

using System.Collections.Generic;
using System.Threading.Tasks;
using DragonU3DSDK.Network.API;
using DragonU3DSDK.Network.API.ILProtocol;
using DragonU3DSDK.Network.API.Protocol;
using UnityEngine;

namespace GameModule
{
    public class AlbumModel:Model<SGetCardAlbumInfo>
    {
        public float lastUpdateRecycleCountDownData;
        public AlbumModel()
            : base(ModelType.TYPE_ALBUM_INFO)
        {
            
        }
        
        public override async Task FetchModalDataFromServerAsync()
        {
            CGetCardAlbumInfo cGetCardAlbumInfo = new CGetCardAlbumInfo();

            var response = await APIManagerGameModule.Instance.SendAsync<CGetCardAlbumInfo, SGetCardAlbumInfo>(cGetCardAlbumInfo);

            if (response.ErrorCode == ErrorCode.Success)
            {
                UpdateModelData(response.Response);
                
                lastUpdateRecycleCountDownData = Time.realtimeSinceStartup;
            }
        }
        
        public bool IsUnlocked()
        {
            if(modelData != null)
                return Client.Get<UserController>().GetUserLevel() >= modelData.UnlockLevel;
            return false;
        }

        public uint GetUnlockLevel()
        {
            return modelData.UnlockLevel;
        }

        public bool IsOpen()
        {
            return isModelDataInitialized && modelData != null &&
                   XUtility.ServerTimeIsInRange(modelData.SeasonStartAt * 1000, modelData.SeasonEndAt * 1000);
        }

        public float GetSeasonCountDown()
        {
            if (isModelDataInitialized)
            {
                if (modelData.SeasonCountDown == 0)
                {
                    XDebug.LogOnExceptionHandler("GetSeasonCountDown:SeasonCountDown == 0");
                    if (XUtility.ServerTimeIsInRange(modelData.SeasonStartAt * 1000, modelData.SeasonEndAt * 1000))
                    {
                        modelData.SeasonCountDown = (uint) XUtility.GetLeftTime(modelData.SeasonEndAt * 1000);
                    }
                }
                
                XDebug.LogOnExceptionHandler("GetSeasonCountDown:");
                return modelData.SeasonCountDown - TimeElapseSinceLastUpdate();
            }

            return 0;
        }

        public int GetCardSetCount()
        {
            if (isModelDataInitialized)
            {
                return modelData.CardSets.Count;
            }

            return 0;
        }

        public CardSet GetCardSetInfo(uint cardSetId)
        {
            var count = modelData.CardSets.Count;
            for (var i = 0; i < count; i++)
            {
                if (modelData.CardSets[i].SetId == cardSetId)
                {
                    return modelData.CardSets[i];
                }
            }

            return null;
        }

        public CardSet GetCardSetInfoByIndex(int setIndex)
        {
            var count = modelData.CardSets.Count;

            if (setIndex < count)
            {
                return modelData.CardSets[setIndex];
            }
            
            return null;
        }
        
        public bool IsFinalRewardClaimed()
        {
            return modelData.RewardForCollectAllStat == CardsRewardStat.Received;
        }

        public Reward GetAllSetCompleteReward()
        {
            return modelData.RewardForCollectAll;
        }
 
        public bool IsCardSetHasRewardToClaim(CardSet cardSet)
        {
            if (cardSet != null)
            {
                if (cardSet.RewardForCollectAllStat == CardsRewardStat.Received)
                {
                    return false;
                }

                if (cardSet.RewardForCollectAllStat == CardsRewardStat.CanReceive)
                {
                    return true;
                }

                for (var i = 0; i < cardSet.Cards.Count; i++)
                {
                    if (cardSet.Cards[i].Count <= 0)
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }
        
    }

    public class CardUpdateInfo
    {
        //????????????????????? 
       public List<Card> cardAcquired;

       public Item.Types.CardPackage.Types.CardPackageConfig packageConfig;
       public Item.Types.CardPackage.Types.CardPackageType packageType;
       //?????????????????????LuckySpin??????
       public uint luckySpinNewAddCount;
       //????????????LuckyChallenge????????????
       public LuckyChallengeUpdateInfo luckyChallengeUpdateInfo;
       //LuckySpin??????????????????
       public uint currentLuckySpinCount;
       //??????????????????????????????????????????????????????id
       public List<uint> finishCardSetIds;

       public CardUpdateInfo()
       {
           cardAcquired = new List<Card>();
           finishCardSetIds = new List<uint>();
       }
    }
    
    public class LuckyChallengeUpdateInfo {
        //LuckyChallenge?????????LuckySpin??????
        public uint rewardLuckySpinCount;
        //????????????LuckyChallenge????????????
        public uint newProgress;
        //????????????LuckyChallenge????????????
        public uint oldProgress;
    }
}
// **********************************************
// Copyright(c) 2021 by com.ustar
// All right reserved
// 
// Author : Jian.Wang
// Date :2021-07-05 12:15 PM
// Ver : 1.0.0
// Description : LogicProxyRoomSetUp.cs
// ChangeLog :
// **********************************************

using DragonU3DSDK.Network.API.ILProtocol;
using Google.ilruntime.Protobuf.Collections;
using UnityEngine;

namespace GameModule
{
    public class MachineSetUpProxy : LogicStepProxy
    {
        private bool needRecoverToLastState = false;

        protected LogicStepType logicStepToJump = LogicStepType.STEP_MACHINE_SETUP;
        
        public MachineSetUpProxy(MachineContext context)
            : base(context)
        {
            
        }
        
        protected override void HandleCommonLogic()
        {
            var gameEnterInfo = machineContext.serviceProvider.GetEnterGameInfo();
           
            PrepareElement(gameEnterInfo);
       
            UpdateStateWhenRoomSetUp(gameEnterInfo);

            SeekLogicTypeToJump();
            
            UpdateViewWhenRoomSetUp();
        }

        protected virtual void SeekLogicTypeToJump()
        {
            if (machineContext.state.Get<ExtraState>().HasSpecialBonus())
            {
                logicStepToJump = LogicStepType.STEP_SPECIAL_BONUS;
                return;
            }
            
            if (machineContext.state.Get<ExtraState>().HasBonusGame())
            {
                logicStepToJump = LogicStepType.STEP_BONUS;
                return;
            }
 
            var freeSpinState = machineContext.state.Get<FreeSpinState>();
            var reSpinState = machineContext.state.Get<ReSpinState>();
             
            if (reSpinState != null && (reSpinState.NextIsReSpin || reSpinState.ReSpinNeedSettle))
            {
                logicStepToJump = LogicStepType.STEP_RE_SPIN;
                return;
            }

            if (freeSpinState != null && (freeSpinState.NextIsFreeSpin || freeSpinState.FreeNeedSettle))
            {
                logicStepToJump = LogicStepType.STEP_FREE_GAME;
                return;
            }
        }
 
        protected override void HandleCustomLogic()
        {
            var freeSpinState = machineContext.state.Get<FreeSpinState>();
            //????????????Free?????????????????????Free?????????????????????????????????????????????Bonus???????????????bonus???????????????Bonus??????
            //???????????????????????????Free??????????????????FreeSpin
            
            if (freeSpinState != null && (freeSpinState.IsInFreeSpin || freeSpinState.FreeNeedSettle))
            { 
                FreeGameProxy proxy = machineContext.GetLogicStepProxy(LogicStepType.STEP_FREE_GAME) as FreeGameProxy;
                if (proxy != null)
                {
                    proxy.RecoverFreeSpinStateWhenRoomSetup();
                }
            }
 
            if (logicStepToJump != LogicStepType.STEP_MACHINE_SETUP)
            {
                RecoverBgMusic();

                if (logicStepToJump != LogicStepType.STEP_FREE_GAME)
                {
                    UpdateControlPanelState();
                }
                
                machineContext.JumpToLogicStep(logicStepToJump, LogicStepType.STEP_MACHINE_SETUP);
                return;
            }

            //Welcome????????????????????????????????????????????????????????????????????????trick
            //??????????????????????????????????????????????????????Welcome???????????????
            //?????????????????????????????????????????????Welcome
            //?????????????????????????????????????????????????????????????????????????????????????????????????????????Welcome???????????????handleEndCallback???
            //??????????????????????????????????????????Welcome?????????
            
            machineContext.WaitNFrame(2, () =>
            {
                if (machineContext.assetProvider.GetAsset<AudioClip>("Welcome"))
                {
                    EventBus.Dispatch(new EventCheckNeedDisableGameWelcome(), () =>
                    {
                        if(!machineContext.IsPaused)
                            AudioUtil.Instance.PlayAudioFx("Welcome");
                    });
                }
            });
          
            UpdateControlPanelState();
            
            base.HandleCustomLogic();
        }

        protected void UpdateStateWhenRoomSetUp(SEnterGame gameEnterInfo)
        {
            machineContext.state.UpdateStatePreRoomSetUp(gameEnterInfo);
            
            machineContext.state.Get<WheelsActiveState>().UpdateRunningWheelState(gameEnterInfo.GameResult);
            
            machineContext.state.UpdateStateOnRoomSetUp(gameEnterInfo);
        }

        protected virtual void UpdateViewWhenRoomSetUp()
        {
            UpdateRunningWheelElement();
            UpdateControlPanelBet();
      
            UpdateControlPanelWinChips();
            UpdateControlPanelState();
        }
        
        //??????????????????
        protected virtual void PrepareElement(SEnterGame gameEnterInfo)
        {
            var symbolConfig = GetElementConfigs(gameEnterInfo);
             
            machineContext.machineConfig.PrepareElementConfig(symbolConfig, machineContext.elementExtraInfoProvider);
            machineContext.machineConfig.GetElementConfigSet().SetUpElementConfig(machineContext.assetProvider);
            
            ConstructSequenceElement(gameEnterInfo);
        }

        protected virtual RepeatedField<SymbolConfig> GetElementConfigs(SEnterGame gameEnterInfo)
        {
            var symbolConfig = gameEnterInfo.GameConfigs[0].SymbolConfigs;
            return symbolConfig;
        }
        protected void ConstructSequenceElement(SEnterGame gameEnterInfo)
        {
            machineContext.sequenceElementConstructor.ConstructReelSequenceFromServerData(machineContext.machineConfig.GetElementConfigSet(), gameEnterInfo.GameConfigs[0].ReelsMap);
        }

        protected virtual void UpdateRunningWheelElement()
        {
            var wheelsRunningStatusState = machineContext.state.Get<WheelsActiveState>();
            wheelsRunningStatusState.SetSpinningOder(WheelSpinningOrder.SAME_TIME_START_ONE_BY_ONE_STOP);

            var wheels = wheelsRunningStatusState.GetRunningWheel();

            for (var i = 0; i < wheels.Count; i++)
            {
                wheels[i].ForceUpdateElementOnWheel();
            }
        }

        protected void UpdateControlPanelBet()
        {
            var controlPanel = machineContext.view.Get<ControlPanel>();
            var betState = machineContext.state.Get<BetState>();

            bool lockBet = false; //needRecoverToLastState;
            
            controlPanel.SetTotalBet(betState.totalBet,betState.IsMaxBet(), betState.IsMinBet(), betState.IsExtraBet(), false);

            if (logicStepToJump != LogicStepType.STEP_MACHINE_SETUP)
            {
                controlPanel.ShowSpinButton(false);
            }
        }
        
        protected void UpdateControlPanelState()
        {
            var controlPanel = machineContext.view.Get<ControlPanel>();
            var freeSpinState = machineContext.state.Get<FreeSpinState>();

            bool isAverage = false;
          
            FreeGameProxy proxy = machineContext.GetLogicStepProxy(LogicStepType.STEP_FREE_GAME) as FreeGameProxy;
           
            if (proxy != null && (freeSpinState.IsInFreeSpin || freeSpinState.FreeNeedSettle))
            {
                isAverage = proxy.UseAverageBet();
            }
            
            controlPanel.UpdateControlPanelState(freeSpinState.IsInFreeSpin, isAverage);

            if (freeSpinState.IsInFreeSpin)
            {
                if (logicStepToJump == LogicStepType.STEP_FREE_GAME)
                {
                    controlPanel.UpdateFreeSpinCountText(freeSpinState.CurrentCount, freeSpinState.TotalCount);
                }
                else
                {
                    //???freeGame?????????????????????Bonus??????????????????Bonus?????????????????????????????????????????????
                    //??????????????????????????????
                    controlPanel.UpdateFreeSpinCountText(freeSpinState.CurrentCount - 1, freeSpinState.TotalCount);
                }
            }
        }
        
        protected void UpdateControlPanelWinChips()
        {
            var controlPanel = machineContext.view.Get<ControlPanel>();
            var winState = machineContext.state.Get<WinState>();
            controlPanel.UpdateWinLabelChips((long) winState.displayTotalWin);
        }

        protected virtual void RecoverBgMusic()
        {
            if (machineContext.state.Get<ReSpinState>().NextIsReSpin)
            {
                AudioUtil.Instance.PlayMusic(machineContext.machineConfig.audioConfig.GetLinkBackgroundMusicName());
            }
            else if (machineContext.state.Get<FreeSpinState>().IsInFreeSpin)
            {
                AudioUtil.Instance.PlayMusic(machineContext.machineConfig.audioConfig.GetFreeBackgroundMusicName());
            }
            else
            {
                AudioUtil.Instance.PlayMusic(machineContext.machineConfig.audioConfig.GetBaseBackgroundMusicName());
            }
        }
    }
}
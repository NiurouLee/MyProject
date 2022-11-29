// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: fortune_x_loading.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.ilruntime.Protobuf;
using pbc = global::Google.ilruntime.Protobuf.Collections;
using scg = global::System.Collections.Generic;
namespace DragonU3DSDK.Network.API.ILProtocol {

  #region Messages
  /// <summary>
  /// PopupConfig
  /// </summary>
  public sealed class PopUpConfig : pb::IMessage {
    private static readonly pb::MessageParser<PopUpConfig> _parser = new pb::MessageParser<PopUpConfig>(() => new PopUpConfig());
    public static pb::MessageParser<PopUpConfig> Parser { get { return _parser; } }

    private static readonly pb::FieldCodec<global::DragonU3DSDK.Network.API.ILProtocol.PopUpConfig.Types.PopupConfigConf> _repeated_config_codec
        = pb::FieldCodec.ForMessage(10, global::DragonU3DSDK.Network.API.ILProtocol.PopUpConfig.Types.PopupConfigConf.Parser);
    private readonly pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.PopUpConfig.Types.PopupConfigConf> config_ = new pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.PopUpConfig.Types.PopupConfigConf>();
    public pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.PopUpConfig.Types.PopupConfigConf> Config {
      get { return config_; }
    }

    private static readonly pb::FieldCodec<global::DragonU3DSDK.Network.API.ILProtocol.PopUpConfig.Types.PopupConfigPool> _repeated_pool_codec
        = pb::FieldCodec.ForMessage(18, global::DragonU3DSDK.Network.API.ILProtocol.PopUpConfig.Types.PopupConfigPool.Parser);
    private readonly pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.PopUpConfig.Types.PopupConfigPool> pool_ = new pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.PopUpConfig.Types.PopupConfigPool>();
    public pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.PopUpConfig.Types.PopupConfigPool> Pool {
      get { return pool_; }
    }

    private static readonly pb::FieldCodec<global::DragonU3DSDK.Network.API.ILProtocol.PopUpConfig.Types.PopupConfigFilter> _repeated_filter_codec
        = pb::FieldCodec.ForMessage(26, global::DragonU3DSDK.Network.API.ILProtocol.PopUpConfig.Types.PopupConfigFilter.Parser);
    private readonly pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.PopUpConfig.Types.PopupConfigFilter> filter_ = new pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.PopUpConfig.Types.PopupConfigFilter>();
    public pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.PopUpConfig.Types.PopupConfigFilter> Filter {
      get { return filter_; }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      config_.WriteTo(output, _repeated_config_codec);
      pool_.WriteTo(output, _repeated_pool_codec);
      filter_.WriteTo(output, _repeated_filter_codec);
    }

    public int CalculateSize() {
      int size = 0;
      size += config_.CalculateSize(_repeated_config_codec);
      size += pool_.CalculateSize(_repeated_pool_codec);
      size += filter_.CalculateSize(_repeated_filter_codec);
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            config_.AddEntriesFrom(input, _repeated_config_codec);
            break;
          }
          case 18: {
            pool_.AddEntriesFrom(input, _repeated_pool_codec);
            break;
          }
          case 26: {
            filter_.AddEntriesFrom(input, _repeated_filter_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the PopUpConfig message type.</summary>
    public static class Types {
      public sealed class PopupConfigConf : pb::IMessage {
        private static readonly pb::MessageParser<PopupConfigConf> _parser = new pb::MessageParser<PopupConfigConf>(() => new PopupConfigConf());
        public static pb::MessageParser<PopupConfigConf> Parser { get { return _parser; } }

        private string id_ = "";
        public string Id {
          get { return id_; }
          set {
            id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        private string poolId_ = "";
        public string PoolId {
          get { return poolId_; }
          set {
            poolId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        public void WriteTo(pb::CodedOutputStream output) {
          if (Id.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Id);
          }
          if (PoolId.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(PoolId);
          }
        }

        public int CalculateSize() {
          int size = 0;
          if (Id.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
          }
          if (PoolId.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(PoolId);
          }
          return size;
        }

        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                input.SkipLastField();
                break;
              case 10: {
                Id = input.ReadString();
                break;
              }
              case 18: {
                PoolId = input.ReadString();
                break;
              }
            }
          }
        }

      }

      public sealed class PopupConfigPool : pb::IMessage {
        private static readonly pb::MessageParser<PopupConfigPool> _parser = new pb::MessageParser<PopupConfigPool>(() => new PopupConfigPool());
        public static pb::MessageParser<PopupConfigPool> Parser { get { return _parser; } }

        private string id_ = "";
        public string Id {
          get { return id_; }
          set {
            id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        private string popupName_ = "";
        public string PopupName {
          get { return popupName_; }
          set {
            popupName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        private string filter_ = "";
        public string Filter {
          get { return filter_; }
          set {
            filter_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        private string weight_ = "";
        public string Weight {
          get { return weight_; }
          set {
            weight_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        public void WriteTo(pb::CodedOutputStream output) {
          if (Id.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Id);
          }
          if (PopupName.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(PopupName);
          }
          if (Filter.Length != 0) {
            output.WriteRawTag(26);
            output.WriteString(Filter);
          }
          if (Weight.Length != 0) {
            output.WriteRawTag(34);
            output.WriteString(Weight);
          }
        }

        public int CalculateSize() {
          int size = 0;
          if (Id.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
          }
          if (PopupName.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(PopupName);
          }
          if (Filter.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Filter);
          }
          if (Weight.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Weight);
          }
          return size;
        }

        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                input.SkipLastField();
                break;
              case 10: {
                Id = input.ReadString();
                break;
              }
              case 18: {
                PopupName = input.ReadString();
                break;
              }
              case 26: {
                Filter = input.ReadString();
                break;
              }
              case 34: {
                Weight = input.ReadString();
                break;
              }
            }
          }
        }

      }

      public sealed class PopupConfigFilter : pb::IMessage {
        private static readonly pb::MessageParser<PopupConfigFilter> _parser = new pb::MessageParser<PopupConfigFilter>(() => new PopupConfigFilter());
        public static pb::MessageParser<PopupConfigFilter> Parser { get { return _parser; } }

        private uint id_;
        public uint Id {
          get { return id_; }
          set {
            id_ = value;
          }
        }

        private string filterType_ = "";
        public string FilterType {
          get { return filterType_; }
          set {
            filterType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        private string arg1_ = "";
        public string Arg1 {
          get { return arg1_; }
          set {
            arg1_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        public void WriteTo(pb::CodedOutputStream output) {
          if (Id != 0) {
            output.WriteRawTag(8);
            output.WriteUInt32(Id);
          }
          if (FilterType.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(FilterType);
          }
          if (Arg1.Length != 0) {
            output.WriteRawTag(26);
            output.WriteString(Arg1);
          }
        }

        public int CalculateSize() {
          int size = 0;
          if (Id != 0) {
            size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
          }
          if (FilterType.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(FilterType);
          }
          if (Arg1.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Arg1);
          }
          return size;
        }

        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                input.SkipLastField();
                break;
              case 8: {
                Id = input.ReadUInt32();
                break;
              }
              case 18: {
                FilterType = input.ReadString();
                break;
              }
              case 26: {
                Arg1 = input.ReadString();
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  /// <summary>
  /// 获取进入大厅之前的信息（汇总若干接口的返回数据)
  /// </summary>
  public sealed class CGetInfoBeforeEnterLobby : pb::IMessage {
    private static readonly pb::MessageParser<CGetInfoBeforeEnterLobby> _parser = new pb::MessageParser<CGetInfoBeforeEnterLobby>(() => new CGetInfoBeforeEnterLobby());
    public static pb::MessageParser<CGetInfoBeforeEnterLobby> Parser { get { return _parser; } }

    private string userGroup_ = "";
    public string UserGroup {
      get { return userGroup_; }
      set {
        userGroup_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (UserGroup.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(UserGroup);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (UserGroup.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserGroup);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            UserGroup = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed class SGetInfoBeforeEnterLobby : pb::IMessage {
    private static readonly pb::MessageParser<SGetInfoBeforeEnterLobby> _parser = new pb::MessageParser<SGetInfoBeforeEnterLobby>(() => new SGetInfoBeforeEnterLobby());
    public static pb::MessageParser<SGetInfoBeforeEnterLobby> Parser { get { return _parser; } }

    private global::DragonU3DSDK.Network.API.ILProtocol.PopUpConfig popUpConfig_;
    public global::DragonU3DSDK.Network.API.ILProtocol.PopUpConfig PopUpConfig {
      get { return popUpConfig_; }
      set {
        popUpConfig_ = value;
      }
    }

    private global::DragonU3DSDK.Network.API.ILProtocol.SGetRVAdvertisingConfig sGetRvAdvertisingConfig_;
    public global::DragonU3DSDK.Network.API.ILProtocol.SGetRVAdvertisingConfig SGetRvAdvertisingConfig {
      get { return sGetRvAdvertisingConfig_; }
      set {
        sGetRvAdvertisingConfig_ = value;
      }
    }

    private global::DragonU3DSDK.Network.API.ILProtocol.SGetBuff sGetBuff_;
    public global::DragonU3DSDK.Network.API.ILProtocol.SGetBuff SGetBuff {
      get { return sGetBuff_; }
      set {
        sGetBuff_ = value;
      }
    }

    private global::DragonU3DSDK.Network.API.ILProtocol.SGetPaymentBaseInfo sGetPaymentBaseInfo_;
    public global::DragonU3DSDK.Network.API.ILProtocol.SGetPaymentBaseInfo SGetPaymentBaseInfo {
      get { return sGetPaymentBaseInfo_; }
      set {
        sGetPaymentBaseInfo_ = value;
      }
    }

    private global::DragonU3DSDK.Network.API.ILProtocol.SGetAdvertisement sGetAdvertisement_;
    public global::DragonU3DSDK.Network.API.ILProtocol.SGetAdvertisement SGetAdvertisement {
      get { return sGetAdvertisement_; }
      set {
        sGetAdvertisement_ = value;
      }
    }

    private global::DragonU3DSDK.Network.API.ILProtocol.SGetVipInfo sGetVipInfo_;
    public global::DragonU3DSDK.Network.API.ILProtocol.SGetVipInfo SGetVipInfo {
      get { return sGetVipInfo_; }
      set {
        sGetVipInfo_ = value;
      }
    }

    private global::DragonU3DSDK.Network.API.ILProtocol.SListGame sListGame_;
    public global::DragonU3DSDK.Network.API.ILProtocol.SListGame SListGame {
      get { return sListGame_; }
      set {
        sListGame_ = value;
      }
    }

    private global::DragonU3DSDK.Network.API.ILProtocol.SGetUserCoupons sGetUserCoupons_;
    public global::DragonU3DSDK.Network.API.ILProtocol.SGetUserCoupons SGetUserCoupons {
      get { return sGetUserCoupons_; }
      set {
        sGetUserCoupons_ = value;
      }
    }

    private global::DragonU3DSDK.Network.API.ILProtocol.SGetDailyBonus sGetDailyBonus_;
    public global::DragonU3DSDK.Network.API.ILProtocol.SGetDailyBonus SGetDailyBonus {
      get { return sGetDailyBonus_; }
      set {
        sGetDailyBonus_ = value;
      }
    }

    private global::DragonU3DSDK.Network.API.ILProtocol.SGetEggInfo sGetEggInfo_;
    public global::DragonU3DSDK.Network.API.ILProtocol.SGetEggInfo SGetEggInfo {
      get { return sGetEggInfo_; }
      set {
        sGetEggInfo_ = value;
      }
    }

    private global::DragonU3DSDK.Network.API.ILProtocol.SGetDailyMission sGetDailyMission_;
    public global::DragonU3DSDK.Network.API.ILProtocol.SGetDailyMission SGetDailyMission {
      get { return sGetDailyMission_; }
      set {
        sGetDailyMission_ = value;
      }
    }

    private global::DragonU3DSDK.Network.API.ILProtocol.SGetMissionPass sGetMissionPass_;
    public global::DragonU3DSDK.Network.API.ILProtocol.SGetMissionPass SGetMissionPass {
      get { return sGetMissionPass_; }
      set {
        sGetMissionPass_ = value;
      }
    }

    private global::DragonU3DSDK.Network.API.ILProtocol.SGetGuide sGetGuide_;
    public global::DragonU3DSDK.Network.API.ILProtocol.SGetGuide SGetGuide {
      get { return sGetGuide_; }
      set {
        sGetGuide_ = value;
      }
    }

    private global::DragonU3DSDK.Network.API.ILProtocol.SRefreshWeekendVipMail sRefreshWeekendVipMail_;
    public global::DragonU3DSDK.Network.API.ILProtocol.SRefreshWeekendVipMail SRefreshWeekendVipMail {
      get { return sRefreshWeekendVipMail_; }
      set {
        sRefreshWeekendVipMail_ = value;
      }
    }

    private global::DragonU3DSDK.Network.API.ILProtocol.SGetNewbieQuest sGetNewbieQuest_;
    public global::DragonU3DSDK.Network.API.ILProtocol.SGetNewbieQuest SGetNewbieQuest {
      get { return sGetNewbieQuest_; }
      set {
        sGetNewbieQuest_ = value;
      }
    }

    private global::DragonU3DSDK.Network.API.ILProtocol.SGetPiggyBank sGetPiggyBank_;
    public global::DragonU3DSDK.Network.API.ILProtocol.SGetPiggyBank SGetPiggyBank {
      get { return sGetPiggyBank_; }
      set {
        sGetPiggyBank_ = value;
      }
    }

    private global::DragonU3DSDK.Network.API.ILProtocol.SGetSeasonQuest sGetSeasonQuest_;
    public global::DragonU3DSDK.Network.API.ILProtocol.SGetSeasonQuest SGetSeasonQuest {
      get { return sGetSeasonQuest_; }
      set {
        sGetSeasonQuest_ = value;
      }
    }

    private global::DragonU3DSDK.Network.API.ILProtocol.SGetTimerBonus sGetTimerBonus_;
    public global::DragonU3DSDK.Network.API.ILProtocol.SGetTimerBonus SGetTimerBonus {
      get { return sGetTimerBonus_; }
      set {
        sGetTimerBonus_ = value;
      }
    }

    private global::DragonU3DSDK.Network.API.ILProtocol.SGetCoinDashInfo sGetCoinDashInfo_;
    public global::DragonU3DSDK.Network.API.ILProtocol.SGetCoinDashInfo SGetCoinDashInfo {
      get { return sGetCoinDashInfo_; }
      set {
        sGetCoinDashInfo_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (popUpConfig_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(PopUpConfig);
      }
      if (sGetRvAdvertisingConfig_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(SGetRvAdvertisingConfig);
      }
      if (sGetBuff_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(SGetBuff);
      }
      if (sGetPaymentBaseInfo_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(SGetPaymentBaseInfo);
      }
      if (sGetAdvertisement_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(SGetAdvertisement);
      }
      if (sGetVipInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(SGetVipInfo);
      }
      if (sListGame_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(SListGame);
      }
      if (sGetUserCoupons_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(SGetUserCoupons);
      }
      if (sGetDailyBonus_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(SGetDailyBonus);
      }
      if (sGetEggInfo_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(SGetEggInfo);
      }
      if (sGetDailyMission_ != null) {
        output.WriteRawTag(90);
        output.WriteMessage(SGetDailyMission);
      }
      if (sGetMissionPass_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(SGetMissionPass);
      }
      if (sGetGuide_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(SGetGuide);
      }
      if (sRefreshWeekendVipMail_ != null) {
        output.WriteRawTag(114);
        output.WriteMessage(SRefreshWeekendVipMail);
      }
      if (sGetNewbieQuest_ != null) {
        output.WriteRawTag(122);
        output.WriteMessage(SGetNewbieQuest);
      }
      if (sGetPiggyBank_ != null) {
        output.WriteRawTag(130, 1);
        output.WriteMessage(SGetPiggyBank);
      }
      if (sGetSeasonQuest_ != null) {
        output.WriteRawTag(138, 1);
        output.WriteMessage(SGetSeasonQuest);
      }
      if (sGetTimerBonus_ != null) {
        output.WriteRawTag(146, 1);
        output.WriteMessage(SGetTimerBonus);
      }
      if (sGetCoinDashInfo_ != null) {
        output.WriteRawTag(154, 1);
        output.WriteMessage(SGetCoinDashInfo);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (popUpConfig_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PopUpConfig);
      }
      if (sGetRvAdvertisingConfig_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SGetRvAdvertisingConfig);
      }
      if (sGetBuff_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SGetBuff);
      }
      if (sGetPaymentBaseInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SGetPaymentBaseInfo);
      }
      if (sGetAdvertisement_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SGetAdvertisement);
      }
      if (sGetVipInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SGetVipInfo);
      }
      if (sListGame_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SListGame);
      }
      if (sGetUserCoupons_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SGetUserCoupons);
      }
      if (sGetDailyBonus_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SGetDailyBonus);
      }
      if (sGetEggInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SGetEggInfo);
      }
      if (sGetDailyMission_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SGetDailyMission);
      }
      if (sGetMissionPass_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SGetMissionPass);
      }
      if (sGetGuide_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SGetGuide);
      }
      if (sRefreshWeekendVipMail_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SRefreshWeekendVipMail);
      }
      if (sGetNewbieQuest_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SGetNewbieQuest);
      }
      if (sGetPiggyBank_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(SGetPiggyBank);
      }
      if (sGetSeasonQuest_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(SGetSeasonQuest);
      }
      if (sGetTimerBonus_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(SGetTimerBonus);
      }
      if (sGetCoinDashInfo_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(SGetCoinDashInfo);
      }
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (popUpConfig_ == null) {
              popUpConfig_ = new global::DragonU3DSDK.Network.API.ILProtocol.PopUpConfig();
            }
            input.ReadMessage(popUpConfig_);
            break;
          }
          case 18: {
            if (sGetRvAdvertisingConfig_ == null) {
              sGetRvAdvertisingConfig_ = new global::DragonU3DSDK.Network.API.ILProtocol.SGetRVAdvertisingConfig();
            }
            input.ReadMessage(sGetRvAdvertisingConfig_);
            break;
          }
          case 26: {
            if (sGetBuff_ == null) {
              sGetBuff_ = new global::DragonU3DSDK.Network.API.ILProtocol.SGetBuff();
            }
            input.ReadMessage(sGetBuff_);
            break;
          }
          case 34: {
            if (sGetPaymentBaseInfo_ == null) {
              sGetPaymentBaseInfo_ = new global::DragonU3DSDK.Network.API.ILProtocol.SGetPaymentBaseInfo();
            }
            input.ReadMessage(sGetPaymentBaseInfo_);
            break;
          }
          case 42: {
            if (sGetAdvertisement_ == null) {
              sGetAdvertisement_ = new global::DragonU3DSDK.Network.API.ILProtocol.SGetAdvertisement();
            }
            input.ReadMessage(sGetAdvertisement_);
            break;
          }
          case 50: {
            if (sGetVipInfo_ == null) {
              sGetVipInfo_ = new global::DragonU3DSDK.Network.API.ILProtocol.SGetVipInfo();
            }
            input.ReadMessage(sGetVipInfo_);
            break;
          }
          case 58: {
            if (sListGame_ == null) {
              sListGame_ = new global::DragonU3DSDK.Network.API.ILProtocol.SListGame();
            }
            input.ReadMessage(sListGame_);
            break;
          }
          case 66: {
            if (sGetUserCoupons_ == null) {
              sGetUserCoupons_ = new global::DragonU3DSDK.Network.API.ILProtocol.SGetUserCoupons();
            }
            input.ReadMessage(sGetUserCoupons_);
            break;
          }
          case 74: {
            if (sGetDailyBonus_ == null) {
              sGetDailyBonus_ = new global::DragonU3DSDK.Network.API.ILProtocol.SGetDailyBonus();
            }
            input.ReadMessage(sGetDailyBonus_);
            break;
          }
          case 82: {
            if (sGetEggInfo_ == null) {
              sGetEggInfo_ = new global::DragonU3DSDK.Network.API.ILProtocol.SGetEggInfo();
            }
            input.ReadMessage(sGetEggInfo_);
            break;
          }
          case 90: {
            if (sGetDailyMission_ == null) {
              sGetDailyMission_ = new global::DragonU3DSDK.Network.API.ILProtocol.SGetDailyMission();
            }
            input.ReadMessage(sGetDailyMission_);
            break;
          }
          case 98: {
            if (sGetMissionPass_ == null) {
              sGetMissionPass_ = new global::DragonU3DSDK.Network.API.ILProtocol.SGetMissionPass();
            }
            input.ReadMessage(sGetMissionPass_);
            break;
          }
          case 106: {
            if (sGetGuide_ == null) {
              sGetGuide_ = new global::DragonU3DSDK.Network.API.ILProtocol.SGetGuide();
            }
            input.ReadMessage(sGetGuide_);
            break;
          }
          case 114: {
            if (sRefreshWeekendVipMail_ == null) {
              sRefreshWeekendVipMail_ = new global::DragonU3DSDK.Network.API.ILProtocol.SRefreshWeekendVipMail();
            }
            input.ReadMessage(sRefreshWeekendVipMail_);
            break;
          }
          case 122: {
            if (sGetNewbieQuest_ == null) {
              sGetNewbieQuest_ = new global::DragonU3DSDK.Network.API.ILProtocol.SGetNewbieQuest();
            }
            input.ReadMessage(sGetNewbieQuest_);
            break;
          }
          case 130: {
            if (sGetPiggyBank_ == null) {
              sGetPiggyBank_ = new global::DragonU3DSDK.Network.API.ILProtocol.SGetPiggyBank();
            }
            input.ReadMessage(sGetPiggyBank_);
            break;
          }
          case 138: {
            if (sGetSeasonQuest_ == null) {
              sGetSeasonQuest_ = new global::DragonU3DSDK.Network.API.ILProtocol.SGetSeasonQuest();
            }
            input.ReadMessage(sGetSeasonQuest_);
            break;
          }
          case 146: {
            if (sGetTimerBonus_ == null) {
              sGetTimerBonus_ = new global::DragonU3DSDK.Network.API.ILProtocol.SGetTimerBonus();
            }
            input.ReadMessage(sGetTimerBonus_);
            break;
          }
          case 154: {
            if (sGetCoinDashInfo_ == null) {
              sGetCoinDashInfo_ = new global::DragonU3DSDK.Network.API.ILProtocol.SGetCoinDashInfo();
            }
            input.ReadMessage(sGetCoinDashInfo_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

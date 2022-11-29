// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: fortunex_mission_pass.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.ilruntime.Protobuf;
using pbc = global::Google.ilruntime.Protobuf.Collections;
using scg = global::System.Collections.Generic;
namespace DragonU3DSDK.Network.API.ILProtocol {

  #region Messages
  public sealed class MissionPass : pb::IMessage {
    private static readonly pb::MessageParser<MissionPass> _parser = new pb::MessageParser<MissionPass>(() => new MissionPass());
    public static pb::MessageParser<MissionPass> Parser { get { return _parser; } }

    private bool isLocked_;
    /// <summary>
    /// 本系统功能是否锁住
    /// </summary>
    public bool IsLocked {
      get { return isLocked_; }
      set {
        isLocked_ = value;
      }
    }

    private uint unlockLevel_;
    /// <summary>
    /// 开锁等级
    /// </summary>
    public uint UnlockLevel {
      get { return unlockLevel_; }
      set {
        unlockLevel_ = value;
      }
    }

    private uint season_;
    /// <summary>
    /// 赛季号
    /// </summary>
    public uint Season {
      get { return season_; }
      set {
        season_ = value;
      }
    }

    private ulong timestampLeft_;
    /// <summary>
    /// 赛季剩余时间
    /// </summary>
    public ulong TimestampLeft {
      get { return timestampLeft_; }
      set {
        timestampLeft_ = value;
      }
    }

    private uint level_;
    /// <summary>
    /// 等级
    /// </summary>
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    private uint exp_;
    /// <summary>
    /// 经验
    /// </summary>
    public uint Exp {
      get { return exp_; }
      set {
        exp_ = value;
      }
    }

    private bool paid_;
    /// <summary>
    /// 是否购买付费通行证
    /// </summary>
    public bool Paid {
      get { return paid_; }
      set {
        paid_ = value;
      }
    }

    private static readonly pb::FieldCodec<global::DragonU3DSDK.Network.API.ILProtocol.MissionPassReward> _repeated_freeRewards_codec
        = pb::FieldCodec.ForMessage(66, global::DragonU3DSDK.Network.API.ILProtocol.MissionPassReward.Parser);
    private readonly pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.MissionPassReward> freeRewards_ = new pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.MissionPassReward>();
    /// <summary>
    /// 免费等级奖励
    /// </summary>
    public pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.MissionPassReward> FreeRewards {
      get { return freeRewards_; }
    }

    private static readonly pb::FieldCodec<global::DragonU3DSDK.Network.API.ILProtocol.MissionPassReward> _repeated_freeTimedRewards_codec
        = pb::FieldCodec.ForMessage(74, global::DragonU3DSDK.Network.API.ILProtocol.MissionPassReward.Parser);
    private readonly pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.MissionPassReward> freeTimedRewards_ = new pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.MissionPassReward>();
    /// <summary>
    /// 免费限时等级奖励
    /// </summary>
    public pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.MissionPassReward> FreeTimedRewards {
      get { return freeTimedRewards_; }
    }

    private static readonly pb::FieldCodec<global::DragonU3DSDK.Network.API.ILProtocol.MissionPassReward> _repeated_paidRewards_codec
        = pb::FieldCodec.ForMessage(82, global::DragonU3DSDK.Network.API.ILProtocol.MissionPassReward.Parser);
    private readonly pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.MissionPassReward> paidRewards_ = new pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.MissionPassReward>();
    /// <summary>
    /// 付费等级奖励
    /// </summary>
    public pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.MissionPassReward> PaidRewards {
      get { return paidRewards_; }
    }

    private static readonly pb::FieldCodec<global::DragonU3DSDK.Network.API.ILProtocol.MissionPassReward> _repeated_paidTimedRewards_codec
        = pb::FieldCodec.ForMessage(90, global::DragonU3DSDK.Network.API.ILProtocol.MissionPassReward.Parser);
    private readonly pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.MissionPassReward> paidTimedRewards_ = new pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.MissionPassReward>();
    /// <summary>
    /// 付费限时等级奖励
    /// </summary>
    public pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.MissionPassReward> PaidTimedRewards {
      get { return paidTimedRewards_; }
    }

    private uint expTotal_;
    /// <summary>
    /// 经验分母
    /// </summary>
    public uint ExpTotal {
      get { return expTotal_; }
      set {
        expTotal_ = value;
      }
    }

    private global::DragonU3DSDK.Network.API.ILProtocol.Reward finalReward_;
    /// <summary>
    /// 终极奖励
    /// </summary>
    public global::DragonU3DSDK.Network.API.ILProtocol.Reward FinalReward {
      get { return finalReward_; }
      set {
        finalReward_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (IsLocked != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsLocked);
      }
      if (UnlockLevel != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(UnlockLevel);
      }
      if (Season != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(Season);
      }
      if (TimestampLeft != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(TimestampLeft);
      }
      if (Level != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(Level);
      }
      if (Exp != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(Exp);
      }
      if (Paid != false) {
        output.WriteRawTag(56);
        output.WriteBool(Paid);
      }
      freeRewards_.WriteTo(output, _repeated_freeRewards_codec);
      freeTimedRewards_.WriteTo(output, _repeated_freeTimedRewards_codec);
      paidRewards_.WriteTo(output, _repeated_paidRewards_codec);
      paidTimedRewards_.WriteTo(output, _repeated_paidTimedRewards_codec);
      if (ExpTotal != 0) {
        output.WriteRawTag(96);
        output.WriteUInt32(ExpTotal);
      }
      if (finalReward_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(FinalReward);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (IsLocked != false) {
        size += 1 + 1;
      }
      if (UnlockLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UnlockLevel);
      }
      if (Season != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Season);
      }
      if (TimestampLeft != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TimestampLeft);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (Exp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Exp);
      }
      if (Paid != false) {
        size += 1 + 1;
      }
      size += freeRewards_.CalculateSize(_repeated_freeRewards_codec);
      size += freeTimedRewards_.CalculateSize(_repeated_freeTimedRewards_codec);
      size += paidRewards_.CalculateSize(_repeated_paidRewards_codec);
      size += paidTimedRewards_.CalculateSize(_repeated_paidTimedRewards_codec);
      if (ExpTotal != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ExpTotal);
      }
      if (finalReward_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FinalReward);
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
            IsLocked = input.ReadBool();
            break;
          }
          case 16: {
            UnlockLevel = input.ReadUInt32();
            break;
          }
          case 24: {
            Season = input.ReadUInt32();
            break;
          }
          case 32: {
            TimestampLeft = input.ReadUInt64();
            break;
          }
          case 40: {
            Level = input.ReadUInt32();
            break;
          }
          case 48: {
            Exp = input.ReadUInt32();
            break;
          }
          case 56: {
            Paid = input.ReadBool();
            break;
          }
          case 66: {
            freeRewards_.AddEntriesFrom(input, _repeated_freeRewards_codec);
            break;
          }
          case 74: {
            freeTimedRewards_.AddEntriesFrom(input, _repeated_freeTimedRewards_codec);
            break;
          }
          case 82: {
            paidRewards_.AddEntriesFrom(input, _repeated_paidRewards_codec);
            break;
          }
          case 90: {
            paidTimedRewards_.AddEntriesFrom(input, _repeated_paidTimedRewards_codec);
            break;
          }
          case 96: {
            ExpTotal = input.ReadUInt32();
            break;
          }
          case 106: {
            if (finalReward_ == null) {
              finalReward_ = new global::DragonU3DSDK.Network.API.ILProtocol.Reward();
            }
            input.ReadMessage(finalReward_);
            break;
          }
        }
      }
    }

  }

  public sealed class MissionPassReward : pb::IMessage {
    private static readonly pb::MessageParser<MissionPassReward> _parser = new pb::MessageParser<MissionPassReward>(() => new MissionPassReward());
    public static pb::MessageParser<MissionPassReward> Parser { get { return _parser; } }

    private uint level_;
    /// <summary>
    /// 可领取的等级
    /// </summary>
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    private global::DragonU3DSDK.Network.API.ILProtocol.Reward reward_;
    /// <summary>
    /// 奖励
    /// </summary>
    public global::DragonU3DSDK.Network.API.ILProtocol.Reward Reward {
      get { return reward_; }
      set {
        reward_ = value;
      }
    }

    private bool collected_;
    /// <summary>
    /// 已经领取
    /// </summary>
    public bool Collected {
      get { return collected_; }
      set {
        collected_ = value;
      }
    }

    private bool timeOver_;
    /// <summary>
    /// 是否已经过期, 过期后无法领取
    /// </summary>
    public bool TimeOver {
      get { return timeOver_; }
      set {
        timeOver_ = value;
      }
    }

    private ulong timestampLeft_;
    /// <summary>
    /// 倒计时显示，仅限时类型奖励需要
    /// </summary>
    public ulong TimestampLeft {
      get { return timestampLeft_; }
      set {
        timestampLeft_ = value;
      }
    }

    private bool isTimed_;
    /// <summary>
    /// 是否是限时奖励
    /// </summary>
    public bool IsTimed {
      get { return isTimed_; }
      set {
        isTimed_ = value;
      }
    }

    private bool isElapsing_;
    /// <summary>
    /// 正在倒计时
    /// </summary>
    public bool IsElapsing {
      get { return isElapsing_; }
      set {
        isElapsing_ = value;
      }
    }

    private string desc_ = "";
    /// <summary>
    /// desc
    /// </summary>
    public string Desc {
      get { return desc_; }
      set {
        desc_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private uint particleAnima_;
    /// <summary>
    /// 重要道具 0 1
    /// </summary>
    public uint ParticleAnima {
      get { return particleAnima_; }
      set {
        particleAnima_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Level != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Level);
      }
      if (reward_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Reward);
      }
      if (Collected != false) {
        output.WriteRawTag(24);
        output.WriteBool(Collected);
      }
      if (TimeOver != false) {
        output.WriteRawTag(32);
        output.WriteBool(TimeOver);
      }
      if (TimestampLeft != 0UL) {
        output.WriteRawTag(40);
        output.WriteUInt64(TimestampLeft);
      }
      if (IsTimed != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsTimed);
      }
      if (IsElapsing != false) {
        output.WriteRawTag(56);
        output.WriteBool(IsElapsing);
      }
      if (Desc.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Desc);
      }
      if (ParticleAnima != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(ParticleAnima);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (reward_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Reward);
      }
      if (Collected != false) {
        size += 1 + 1;
      }
      if (TimeOver != false) {
        size += 1 + 1;
      }
      if (TimestampLeft != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TimestampLeft);
      }
      if (IsTimed != false) {
        size += 1 + 1;
      }
      if (IsElapsing != false) {
        size += 1 + 1;
      }
      if (Desc.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Desc);
      }
      if (ParticleAnima != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ParticleAnima);
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
            Level = input.ReadUInt32();
            break;
          }
          case 18: {
            if (reward_ == null) {
              reward_ = new global::DragonU3DSDK.Network.API.ILProtocol.Reward();
            }
            input.ReadMessage(reward_);
            break;
          }
          case 24: {
            Collected = input.ReadBool();
            break;
          }
          case 32: {
            TimeOver = input.ReadBool();
            break;
          }
          case 40: {
            TimestampLeft = input.ReadUInt64();
            break;
          }
          case 48: {
            IsTimed = input.ReadBool();
            break;
          }
          case 56: {
            IsElapsing = input.ReadBool();
            break;
          }
          case 66: {
            Desc = input.ReadString();
            break;
          }
          case 72: {
            ParticleAnima = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  public sealed class CGetMissionPassPaymentItems : pb::IMessage {
    private static readonly pb::MessageParser<CGetMissionPassPaymentItems> _parser = new pb::MessageParser<CGetMissionPassPaymentItems>(() => new CGetMissionPassPaymentItems());
    public static pb::MessageParser<CGetMissionPassPaymentItems> Parser { get { return _parser; } }

    public void WriteTo(pb::CodedOutputStream output) {
    }

    public int CalculateSize() {
      int size = 0;
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  public sealed class SGetMissionPassPaymentItems : pb::IMessage {
    private static readonly pb::MessageParser<SGetMissionPassPaymentItems> _parser = new pb::MessageParser<SGetMissionPassPaymentItems>(() => new SGetMissionPassPaymentItems());
    public static pb::MessageParser<SGetMissionPassPaymentItems> Parser { get { return _parser; } }

    private static readonly pb::FieldCodec<global::DragonU3DSDK.Network.API.ILProtocol.ShopItemConfig> _repeated_items_codec
        = pb::FieldCodec.ForMessage(10, global::DragonU3DSDK.Network.API.ILProtocol.ShopItemConfig.Parser);
    private readonly pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.ShopItemConfig> items_ = new pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.ShopItemConfig>();
    public pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.ShopItemConfig> Items {
      get { return items_; }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      items_.WriteTo(output, _repeated_items_codec);
    }

    public int CalculateSize() {
      int size = 0;
      size += items_.CalculateSize(_repeated_items_codec);
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
            items_.AddEntriesFrom(input, _repeated_items_codec);
            break;
          }
        }
      }
    }

  }

  public sealed class CGetMissionPass : pb::IMessage {
    private static readonly pb::MessageParser<CGetMissionPass> _parser = new pb::MessageParser<CGetMissionPass>(() => new CGetMissionPass());
    public static pb::MessageParser<CGetMissionPass> Parser { get { return _parser; } }

    public void WriteTo(pb::CodedOutputStream output) {
    }

    public int CalculateSize() {
      int size = 0;
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  public sealed class SGetMissionPass : pb::IMessage {
    private static readonly pb::MessageParser<SGetMissionPass> _parser = new pb::MessageParser<SGetMissionPass>(() => new SGetMissionPass());
    public static pb::MessageParser<SGetMissionPass> Parser { get { return _parser; } }

    private global::DragonU3DSDK.Network.API.ILProtocol.MissionPass missionPass_;
    public global::DragonU3DSDK.Network.API.ILProtocol.MissionPass MissionPass {
      get { return missionPass_; }
      set {
        missionPass_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (missionPass_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(MissionPass);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (missionPass_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MissionPass);
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
            if (missionPass_ == null) {
              missionPass_ = new global::DragonU3DSDK.Network.API.ILProtocol.MissionPass();
            }
            input.ReadMessage(missionPass_);
            break;
          }
        }
      }
    }

  }

  public sealed class CRefreshMissionPass : pb::IMessage {
    private static readonly pb::MessageParser<CRefreshMissionPass> _parser = new pb::MessageParser<CRefreshMissionPass>(() => new CRefreshMissionPass());
    public static pb::MessageParser<CRefreshMissionPass> Parser { get { return _parser; } }

    public void WriteTo(pb::CodedOutputStream output) {
    }

    public int CalculateSize() {
      int size = 0;
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  public sealed class SRefreshMissionPass : pb::IMessage {
    private static readonly pb::MessageParser<SRefreshMissionPass> _parser = new pb::MessageParser<SRefreshMissionPass>(() => new SRefreshMissionPass());
    public static pb::MessageParser<SRefreshMissionPass> Parser { get { return _parser; } }

    private global::DragonU3DSDK.Network.API.ILProtocol.MissionPass missionPass_;
    public global::DragonU3DSDK.Network.API.ILProtocol.MissionPass MissionPass {
      get { return missionPass_; }
      set {
        missionPass_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (missionPass_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(MissionPass);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (missionPass_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MissionPass);
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
            if (missionPass_ == null) {
              missionPass_ = new global::DragonU3DSDK.Network.API.ILProtocol.MissionPass();
            }
            input.ReadMessage(missionPass_);
            break;
          }
        }
      }
    }

  }

  public sealed class CCollectMissionPass : pb::IMessage {
    private static readonly pb::MessageParser<CCollectMissionPass> _parser = new pb::MessageParser<CCollectMissionPass>(() => new CCollectMissionPass());
    public static pb::MessageParser<CCollectMissionPass> Parser { get { return _parser; } }

    private uint level_;
    /// <summary>
    /// 领取奖励的等级
    /// </summary>
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    private bool isPaid_;
    /// <summary>
    /// 是否是付费奖励
    /// </summary>
    public bool IsPaid {
      get { return isPaid_; }
      set {
        isPaid_ = value;
      }
    }

    private bool isTimed_;
    /// <summary>
    /// 是否是限时奖励
    /// </summary>
    public bool IsTimed {
      get { return isTimed_; }
      set {
        isTimed_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Level != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Level);
      }
      if (IsPaid != false) {
        output.WriteRawTag(16);
        output.WriteBool(IsPaid);
      }
      if (IsTimed != false) {
        output.WriteRawTag(24);
        output.WriteBool(IsTimed);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (IsPaid != false) {
        size += 1 + 1;
      }
      if (IsTimed != false) {
        size += 1 + 1;
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
            Level = input.ReadUInt32();
            break;
          }
          case 16: {
            IsPaid = input.ReadBool();
            break;
          }
          case 24: {
            IsTimed = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed class SCollectMissionPass : pb::IMessage {
    private static readonly pb::MessageParser<SCollectMissionPass> _parser = new pb::MessageParser<SCollectMissionPass>(() => new SCollectMissionPass());
    public static pb::MessageParser<SCollectMissionPass> Parser { get { return _parser; } }

    private global::DragonU3DSDK.Network.API.ILProtocol.MissionPass missionPass_;
    public global::DragonU3DSDK.Network.API.ILProtocol.MissionPass MissionPass {
      get { return missionPass_; }
      set {
        missionPass_ = value;
      }
    }

    private global::DragonU3DSDK.Network.API.ILProtocol.UserProfile userProfile_;
    /// <summary>
    /// 用户数据
    /// </summary>
    public global::DragonU3DSDK.Network.API.ILProtocol.UserProfile UserProfile {
      get { return userProfile_; }
      set {
        userProfile_ = value;
      }
    }

    private static readonly pb::FieldCodec<global::DragonU3DSDK.Network.API.ILProtocol.Reward> _repeated_rewards_codec
        = pb::FieldCodec.ForMessage(26, global::DragonU3DSDK.Network.API.ILProtocol.Reward.Parser);
    private readonly pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Reward> rewards_ = new pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Reward>();
    /// <summary>
    /// 领取到的所有奖励
    /// </summary>
    public pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Reward> Rewards {
      get { return rewards_; }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (missionPass_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(MissionPass);
      }
      if (userProfile_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(UserProfile);
      }
      rewards_.WriteTo(output, _repeated_rewards_codec);
    }

    public int CalculateSize() {
      int size = 0;
      if (missionPass_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MissionPass);
      }
      if (userProfile_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UserProfile);
      }
      size += rewards_.CalculateSize(_repeated_rewards_codec);
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
            if (missionPass_ == null) {
              missionPass_ = new global::DragonU3DSDK.Network.API.ILProtocol.MissionPass();
            }
            input.ReadMessage(missionPass_);
            break;
          }
          case 18: {
            if (userProfile_ == null) {
              userProfile_ = new global::DragonU3DSDK.Network.API.ILProtocol.UserProfile();
            }
            input.ReadMessage(userProfile_);
            break;
          }
          case 26: {
            rewards_.AddEntriesFrom(input, _repeated_rewards_codec);
            break;
          }
        }
      }
    }

  }

  public sealed class CCollectAllMissionPass : pb::IMessage {
    private static readonly pb::MessageParser<CCollectAllMissionPass> _parser = new pb::MessageParser<CCollectAllMissionPass>(() => new CCollectAllMissionPass());
    public static pb::MessageParser<CCollectAllMissionPass> Parser { get { return _parser; } }

    public void WriteTo(pb::CodedOutputStream output) {
    }

    public int CalculateSize() {
      int size = 0;
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  public sealed class SCollectAllMissionPass : pb::IMessage {
    private static readonly pb::MessageParser<SCollectAllMissionPass> _parser = new pb::MessageParser<SCollectAllMissionPass>(() => new SCollectAllMissionPass());
    public static pb::MessageParser<SCollectAllMissionPass> Parser { get { return _parser; } }

    private global::DragonU3DSDK.Network.API.ILProtocol.MissionPass missionPass_;
    public global::DragonU3DSDK.Network.API.ILProtocol.MissionPass MissionPass {
      get { return missionPass_; }
      set {
        missionPass_ = value;
      }
    }

    private global::DragonU3DSDK.Network.API.ILProtocol.UserProfile userProfile_;
    /// <summary>
    /// 用户数据
    /// </summary>
    public global::DragonU3DSDK.Network.API.ILProtocol.UserProfile UserProfile {
      get { return userProfile_; }
      set {
        userProfile_ = value;
      }
    }

    private static readonly pb::FieldCodec<global::DragonU3DSDK.Network.API.ILProtocol.Reward> _repeated_rewards_codec
        = pb::FieldCodec.ForMessage(26, global::DragonU3DSDK.Network.API.ILProtocol.Reward.Parser);
    private readonly pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Reward> rewards_ = new pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Reward>();
    /// <summary>
    /// 领取到的所有奖励
    /// </summary>
    public pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Reward> Rewards {
      get { return rewards_; }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (missionPass_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(MissionPass);
      }
      if (userProfile_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(UserProfile);
      }
      rewards_.WriteTo(output, _repeated_rewards_codec);
    }

    public int CalculateSize() {
      int size = 0;
      if (missionPass_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MissionPass);
      }
      if (userProfile_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UserProfile);
      }
      size += rewards_.CalculateSize(_repeated_rewards_codec);
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
            if (missionPass_ == null) {
              missionPass_ = new global::DragonU3DSDK.Network.API.ILProtocol.MissionPass();
            }
            input.ReadMessage(missionPass_);
            break;
          }
          case 18: {
            if (userProfile_ == null) {
              userProfile_ = new global::DragonU3DSDK.Network.API.ILProtocol.UserProfile();
            }
            input.ReadMessage(userProfile_);
            break;
          }
          case 26: {
            rewards_.AddEntriesFrom(input, _repeated_rewards_codec);
            break;
          }
        }
      }
    }

  }

  public sealed class CDiamondBuyLevelMissionPass : pb::IMessage {
    private static readonly pb::MessageParser<CDiamondBuyLevelMissionPass> _parser = new pb::MessageParser<CDiamondBuyLevelMissionPass>(() => new CDiamondBuyLevelMissionPass());
    public static pb::MessageParser<CDiamondBuyLevelMissionPass> Parser { get { return _parser; } }

    public void WriteTo(pb::CodedOutputStream output) {
    }

    public int CalculateSize() {
      int size = 0;
      return size;
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  public sealed class SDiamondBuyLevelMissionPass : pb::IMessage {
    private static readonly pb::MessageParser<SDiamondBuyLevelMissionPass> _parser = new pb::MessageParser<SDiamondBuyLevelMissionPass>(() => new SDiamondBuyLevelMissionPass());
    public static pb::MessageParser<SDiamondBuyLevelMissionPass> Parser { get { return _parser; } }

    private global::DragonU3DSDK.Network.API.ILProtocol.MissionPass missionPass_;
    public global::DragonU3DSDK.Network.API.ILProtocol.MissionPass MissionPass {
      get { return missionPass_; }
      set {
        missionPass_ = value;
      }
    }

    private global::DragonU3DSDK.Network.API.ILProtocol.UserProfile userProfile_;
    /// <summary>
    /// 用户数据
    /// </summary>
    public global::DragonU3DSDK.Network.API.ILProtocol.UserProfile UserProfile {
      get { return userProfile_; }
      set {
        userProfile_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (missionPass_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(MissionPass);
      }
      if (userProfile_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(UserProfile);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (missionPass_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MissionPass);
      }
      if (userProfile_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UserProfile);
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
            if (missionPass_ == null) {
              missionPass_ = new global::DragonU3DSDK.Network.API.ILProtocol.MissionPass();
            }
            input.ReadMessage(missionPass_);
            break;
          }
          case 18: {
            if (userProfile_ == null) {
              userProfile_ = new global::DragonU3DSDK.Network.API.ILProtocol.UserProfile();
            }
            input.ReadMessage(userProfile_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

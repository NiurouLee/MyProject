// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: fortunex_daily_mission.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.ilruntime.Protobuf;
using pbc = global::Google.ilruntime.Protobuf.Collections;
using scg = global::System.Collections.Generic;
namespace DragonU3DSDK.Network.API.ILProtocol {

  #region Messages
  public sealed class DailyMission : pb::IMessage {
    private static readonly pb::MessageParser<DailyMission> _parser = new pb::MessageParser<DailyMission>(() => new DailyMission());
    public static pb::MessageParser<DailyMission> Parser { get { return _parser; } }

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

    private ulong normalTimestampLeft_;
    /// <summary>
    /// 普通任务计时
    /// </summary>
    public ulong NormalTimestampLeft {
      get { return normalTimestampLeft_; }
      set {
        normalTimestampLeft_ = value;
      }
    }

    private ulong honorTimestampLeft_;
    /// <summary>
    /// 荣誉任务计时
    /// </summary>
    public ulong HonorTimestampLeft {
      get { return honorTimestampLeft_; }
      set {
        honorTimestampLeft_ = value;
      }
    }

    private ulong stageTimestampLeft_;
    /// <summary>
    /// 累计奖励倒计时
    /// </summary>
    public ulong StageTimestampLeft {
      get { return stageTimestampLeft_; }
      set {
        stageTimestampLeft_ = value;
      }
    }

    private static readonly pb::FieldCodec<global::DragonU3DSDK.Network.API.ILProtocol.Mission> _repeated_normalMissions_codec
        = pb::FieldCodec.ForMessage(50, global::DragonU3DSDK.Network.API.ILProtocol.Mission.Parser);
    private readonly pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Mission> normalMissions_ = new pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Mission>();
    /// <summary>
    /// 普通任务列表，正常数量为3
    /// </summary>
    public pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Mission> NormalMissions {
      get { return normalMissions_; }
    }

    private static readonly pb::FieldCodec<global::DragonU3DSDK.Network.API.ILProtocol.Mission> _repeated_honorMissions_codec
        = pb::FieldCodec.ForMessage(58, global::DragonU3DSDK.Network.API.ILProtocol.Mission.Parser);
    private readonly pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Mission> honorMissions_ = new pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Mission>();
    /// <summary>
    /// 荣誉任务， 正常数量为1或2  最后一个是最新的， 领取时会用到旧的
    /// </summary>
    public pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Mission> HonorMissions {
      get { return honorMissions_; }
    }

    private uint stagePoint_;
    /// <summary>
    /// 累计奖励积分
    /// </summary>
    public uint StagePoint {
      get { return stagePoint_; }
      set {
        stagePoint_ = value;
      }
    }

    private uint stagePointTotal_;
    /// <summary>
    /// 累计奖励积分最大值
    /// </summary>
    public uint StagePointTotal {
      get { return stagePointTotal_; }
      set {
        stagePointTotal_ = value;
      }
    }

    private static readonly pb::FieldCodec<global::DragonU3DSDK.Network.API.ILProtocol.DailyMission.Types.Stage> _repeated_stages_codec
        = pb::FieldCodec.ForMessage(82, global::DragonU3DSDK.Network.API.ILProtocol.DailyMission.Types.Stage.Parser);
    private readonly pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.DailyMission.Types.Stage> stages_ = new pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.DailyMission.Types.Stage>();
    /// <summary>
    /// 累计奖励
    /// </summary>
    public pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.DailyMission.Types.Stage> Stages {
      get { return stages_; }
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
      if (NormalTimestampLeft != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(NormalTimestampLeft);
      }
      if (HonorTimestampLeft != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(HonorTimestampLeft);
      }
      if (StageTimestampLeft != 0UL) {
        output.WriteRawTag(40);
        output.WriteUInt64(StageTimestampLeft);
      }
      normalMissions_.WriteTo(output, _repeated_normalMissions_codec);
      honorMissions_.WriteTo(output, _repeated_honorMissions_codec);
      if (StagePoint != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(StagePoint);
      }
      if (StagePointTotal != 0) {
        output.WriteRawTag(72);
        output.WriteUInt32(StagePointTotal);
      }
      stages_.WriteTo(output, _repeated_stages_codec);
    }

    public int CalculateSize() {
      int size = 0;
      if (IsLocked != false) {
        size += 1 + 1;
      }
      if (UnlockLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(UnlockLevel);
      }
      if (NormalTimestampLeft != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(NormalTimestampLeft);
      }
      if (HonorTimestampLeft != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(HonorTimestampLeft);
      }
      if (StageTimestampLeft != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(StageTimestampLeft);
      }
      size += normalMissions_.CalculateSize(_repeated_normalMissions_codec);
      size += honorMissions_.CalculateSize(_repeated_honorMissions_codec);
      if (StagePoint != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StagePoint);
      }
      if (StagePointTotal != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(StagePointTotal);
      }
      size += stages_.CalculateSize(_repeated_stages_codec);
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
            NormalTimestampLeft = input.ReadUInt64();
            break;
          }
          case 32: {
            HonorTimestampLeft = input.ReadUInt64();
            break;
          }
          case 40: {
            StageTimestampLeft = input.ReadUInt64();
            break;
          }
          case 50: {
            normalMissions_.AddEntriesFrom(input, _repeated_normalMissions_codec);
            break;
          }
          case 58: {
            honorMissions_.AddEntriesFrom(input, _repeated_honorMissions_codec);
            break;
          }
          case 64: {
            StagePoint = input.ReadUInt32();
            break;
          }
          case 72: {
            StagePointTotal = input.ReadUInt32();
            break;
          }
          case 82: {
            stages_.AddEntriesFrom(input, _repeated_stages_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the DailyMission message type.</summary>
    public static class Types {
      public sealed class Stage : pb::IMessage {
        private static readonly pb::MessageParser<Stage> _parser = new pb::MessageParser<Stage>(() => new Stage());
        public static pb::MessageParser<Stage> Parser { get { return _parser; } }

        private uint point_;
        /// <summary>
        /// 领取积分
        /// </summary>
        public uint Point {
          get { return point_; }
          set {
            point_ = value;
          }
        }

        private static readonly pb::FieldCodec<global::DragonU3DSDK.Network.API.ILProtocol.Item> _repeated_items_codec
            = pb::FieldCodec.ForMessage(18, global::DragonU3DSDK.Network.API.ILProtocol.Item.Parser);
        private readonly pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Item> items_ = new pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Item>();
        /// <summary>
        /// 奖励
        /// </summary>
        public pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Item> Items {
          get { return items_; }
        }

        private string desc_ = "";
        /// <summary>
        /// 描述
        /// </summary>
        public string Desc {
          get { return desc_; }
          set {
            desc_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        public void WriteTo(pb::CodedOutputStream output) {
          if (Point != 0) {
            output.WriteRawTag(8);
            output.WriteUInt32(Point);
          }
          items_.WriteTo(output, _repeated_items_codec);
          if (Desc.Length != 0) {
            output.WriteRawTag(26);
            output.WriteString(Desc);
          }
        }

        public int CalculateSize() {
          int size = 0;
          if (Point != 0) {
            size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Point);
          }
          size += items_.CalculateSize(_repeated_items_codec);
          if (Desc.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Desc);
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
                Point = input.ReadUInt32();
                break;
              }
              case 18: {
                items_.AddEntriesFrom(input, _repeated_items_codec);
                break;
              }
              case 26: {
                Desc = input.ReadString();
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  public sealed class CGetDailyMission : pb::IMessage {
    private static readonly pb::MessageParser<CGetDailyMission> _parser = new pb::MessageParser<CGetDailyMission>(() => new CGetDailyMission());
    public static pb::MessageParser<CGetDailyMission> Parser { get { return _parser; } }

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

  public sealed class SGetDailyMission : pb::IMessage {
    private static readonly pb::MessageParser<SGetDailyMission> _parser = new pb::MessageParser<SGetDailyMission>(() => new SGetDailyMission());
    public static pb::MessageParser<SGetDailyMission> Parser { get { return _parser; } }

    private global::DragonU3DSDK.Network.API.ILProtocol.DailyMission dailyMission_;
    public global::DragonU3DSDK.Network.API.ILProtocol.DailyMission DailyMission {
      get { return dailyMission_; }
      set {
        dailyMission_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (dailyMission_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(DailyMission);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (dailyMission_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DailyMission);
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
            if (dailyMission_ == null) {
              dailyMission_ = new global::DragonU3DSDK.Network.API.ILProtocol.DailyMission();
            }
            input.ReadMessage(dailyMission_);
            break;
          }
        }
      }
    }

  }

  public sealed class CRefreshDailyMission : pb::IMessage {
    private static readonly pb::MessageParser<CRefreshDailyMission> _parser = new pb::MessageParser<CRefreshDailyMission>(() => new CRefreshDailyMission());
    public static pb::MessageParser<CRefreshDailyMission> Parser { get { return _parser; } }

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

  public sealed class SRefreshDailyMission : pb::IMessage {
    private static readonly pb::MessageParser<SRefreshDailyMission> _parser = new pb::MessageParser<SRefreshDailyMission>(() => new SRefreshDailyMission());
    public static pb::MessageParser<SRefreshDailyMission> Parser { get { return _parser; } }

    private global::DragonU3DSDK.Network.API.ILProtocol.DailyMission dailyMission_;
    public global::DragonU3DSDK.Network.API.ILProtocol.DailyMission DailyMission {
      get { return dailyMission_; }
      set {
        dailyMission_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (dailyMission_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(DailyMission);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (dailyMission_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DailyMission);
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
            if (dailyMission_ == null) {
              dailyMission_ = new global::DragonU3DSDK.Network.API.ILProtocol.DailyMission();
            }
            input.ReadMessage(dailyMission_);
            break;
          }
        }
      }
    }

  }

  public sealed class CCollectDailyMission : pb::IMessage {
    private static readonly pb::MessageParser<CCollectDailyMission> _parser = new pb::MessageParser<CCollectDailyMission>(() => new CCollectDailyMission());
    public static pb::MessageParser<CCollectDailyMission> Parser { get { return _parser; } }

    private bool isHonor_;
    public bool IsHonor {
      get { return isHonor_; }
      set {
        isHonor_ = value;
      }
    }

    private uint index_;
    public uint Index {
      get { return index_; }
      set {
        index_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (IsHonor != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsHonor);
      }
      if (Index != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Index);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (IsHonor != false) {
        size += 1 + 1;
      }
      if (Index != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Index);
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
            IsHonor = input.ReadBool();
            break;
          }
          case 16: {
            Index = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  public sealed class SCollectDailyMission : pb::IMessage {
    private static readonly pb::MessageParser<SCollectDailyMission> _parser = new pb::MessageParser<SCollectDailyMission>(() => new SCollectDailyMission());
    public static pb::MessageParser<SCollectDailyMission> Parser { get { return _parser; } }

    private global::DragonU3DSDK.Network.API.ILProtocol.DailyMission dailyMission_;
    /// <summary>
    /// 每日任务数据
    /// </summary>
    public global::DragonU3DSDK.Network.API.ILProtocol.DailyMission DailyMission {
      get { return dailyMission_; }
      set {
        dailyMission_ = value;
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

    private global::DragonU3DSDK.Network.API.ILProtocol.Reward missionReward_;
    /// <summary>
    /// 完成任务奖励
    /// </summary>
    public global::DragonU3DSDK.Network.API.ILProtocol.Reward MissionReward {
      get { return missionReward_; }
      set {
        missionReward_ = value;
      }
    }

    private static readonly pb::FieldCodec<global::DragonU3DSDK.Network.API.ILProtocol.Reward> _repeated_stageRewards_codec
        = pb::FieldCodec.ForMessage(34, global::DragonU3DSDK.Network.API.ILProtocol.Reward.Parser);
    private readonly pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Reward> stageRewards_ = new pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Reward>();
    /// <summary>
    /// 完成任务奖励
    /// </summary>
    public pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Reward> StageRewards {
      get { return stageRewards_; }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (dailyMission_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(DailyMission);
      }
      if (userProfile_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(UserProfile);
      }
      if (missionReward_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(MissionReward);
      }
      stageRewards_.WriteTo(output, _repeated_stageRewards_codec);
    }

    public int CalculateSize() {
      int size = 0;
      if (dailyMission_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DailyMission);
      }
      if (userProfile_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UserProfile);
      }
      if (missionReward_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MissionReward);
      }
      size += stageRewards_.CalculateSize(_repeated_stageRewards_codec);
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
            if (dailyMission_ == null) {
              dailyMission_ = new global::DragonU3DSDK.Network.API.ILProtocol.DailyMission();
            }
            input.ReadMessage(dailyMission_);
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
            if (missionReward_ == null) {
              missionReward_ = new global::DragonU3DSDK.Network.API.ILProtocol.Reward();
            }
            input.ReadMessage(missionReward_);
            break;
          }
          case 34: {
            stageRewards_.AddEntriesFrom(input, _repeated_stageRewards_codec);
            break;
          }
        }
      }
    }

  }

  public sealed class CCompleteNowDailyMission : pb::IMessage {
    private static readonly pb::MessageParser<CCompleteNowDailyMission> _parser = new pb::MessageParser<CCompleteNowDailyMission>(() => new CCompleteNowDailyMission());
    public static pb::MessageParser<CCompleteNowDailyMission> Parser { get { return _parser; } }

    private bool isHonor_;
    public bool IsHonor {
      get { return isHonor_; }
      set {
        isHonor_ = value;
      }
    }

    private uint index_;
    public uint Index {
      get { return index_; }
      set {
        index_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (IsHonor != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsHonor);
      }
      if (Index != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Index);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (IsHonor != false) {
        size += 1 + 1;
      }
      if (Index != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Index);
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
            IsHonor = input.ReadBool();
            break;
          }
          case 16: {
            Index = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  public sealed class SCompleteNowDailyMission : pb::IMessage {
    private static readonly pb::MessageParser<SCompleteNowDailyMission> _parser = new pb::MessageParser<SCompleteNowDailyMission>(() => new SCompleteNowDailyMission());
    public static pb::MessageParser<SCompleteNowDailyMission> Parser { get { return _parser; } }

    private global::DragonU3DSDK.Network.API.ILProtocol.DailyMission dailyMission_;
    /// <summary>
    /// 每日任务数据
    /// </summary>
    public global::DragonU3DSDK.Network.API.ILProtocol.DailyMission DailyMission {
      get { return dailyMission_; }
      set {
        dailyMission_ = value;
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

    private global::DragonU3DSDK.Network.API.ILProtocol.Reward missionReward_;
    /// <summary>
    /// 完成任务奖励
    /// </summary>
    public global::DragonU3DSDK.Network.API.ILProtocol.Reward MissionReward {
      get { return missionReward_; }
      set {
        missionReward_ = value;
      }
    }

    private static readonly pb::FieldCodec<global::DragonU3DSDK.Network.API.ILProtocol.Reward> _repeated_stageRewards_codec
        = pb::FieldCodec.ForMessage(34, global::DragonU3DSDK.Network.API.ILProtocol.Reward.Parser);
    private readonly pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Reward> stageRewards_ = new pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Reward>();
    /// <summary>
    /// 完成任务奖励
    /// </summary>
    public pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Reward> StageRewards {
      get { return stageRewards_; }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (dailyMission_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(DailyMission);
      }
      if (userProfile_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(UserProfile);
      }
      if (missionReward_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(MissionReward);
      }
      stageRewards_.WriteTo(output, _repeated_stageRewards_codec);
    }

    public int CalculateSize() {
      int size = 0;
      if (dailyMission_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DailyMission);
      }
      if (userProfile_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UserProfile);
      }
      if (missionReward_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MissionReward);
      }
      size += stageRewards_.CalculateSize(_repeated_stageRewards_codec);
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
            if (dailyMission_ == null) {
              dailyMission_ = new global::DragonU3DSDK.Network.API.ILProtocol.DailyMission();
            }
            input.ReadMessage(dailyMission_);
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
            if (missionReward_ == null) {
              missionReward_ = new global::DragonU3DSDK.Network.API.ILProtocol.Reward();
            }
            input.ReadMessage(missionReward_);
            break;
          }
          case 34: {
            stageRewards_.AddEntriesFrom(input, _repeated_stageRewards_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

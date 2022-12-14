// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: fortunex_vip.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.ilruntime.Protobuf;
using pbc = global::Google.ilruntime.Protobuf.Collections;
using scg = global::System.Collections.Generic;
namespace DragonU3DSDK.Network.API.ILProtocol {

  #region Messages
  public sealed class VipLevelConfig : pb::IMessage {
    private static readonly pb::MessageParser<VipLevelConfig> _parser = new pb::MessageParser<VipLevelConfig>(() => new VipLevelConfig());
    public static pb::MessageParser<VipLevelConfig> Parser { get { return _parser; } }

    private uint level_;
    /// <summary>
    /// vip等级
    /// </summary>
    public uint Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    private uint exp_;
    /// <summary>
    /// 到下一级经验
    /// </summary>
    public uint Exp {
      get { return exp_; }
      set {
        exp_ = value;
      }
    }

    private uint levelReward_;
    /// <summary>
    /// 升级奖励
    /// </summary>
    public uint LevelReward {
      get { return levelReward_; }
      set {
        levelReward_ = value;
      }
    }

    private string vipName_ = "";
    /// <summary>
    /// vip名称
    /// </summary>
    public string VipName {
      get { return vipName_; }
      set {
        vipName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private ulong systemDailyBonus_;
    /// <summary>
    /// dailybonus加成奖励(基数100)
    /// </summary>
    public ulong SystemDailyBonus {
      get { return systemDailyBonus_; }
      set {
        systemDailyBonus_ = value;
      }
    }

    private uint systemTimerBonus_;
    /// <summary>
    /// timerbonus加成奖励(基数100)
    /// </summary>
    public uint SystemTimerBonus {
      get { return systemTimerBonus_; }
      set {
        systemTimerBonus_ = value;
      }
    }

    private uint systemStore_;
    /// <summary>
    /// 商城加成(基数100)
    /// </summary>
    public uint SystemStore {
      get { return systemStore_; }
      set {
        systemStore_ = value;
      }
    }

    private uint systemVipPoints_;
    /// <summary>
    /// vippoints加成(基数100)
    /// </summary>
    public uint SystemVipPoints {
      get { return systemVipPoints_; }
      set {
        systemVipPoints_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Level != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Level);
      }
      if (Exp != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Exp);
      }
      if (LevelReward != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(LevelReward);
      }
      if (VipName.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(VipName);
      }
      if (SystemDailyBonus != 0UL) {
        output.WriteRawTag(40);
        output.WriteUInt64(SystemDailyBonus);
      }
      if (SystemTimerBonus != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(SystemTimerBonus);
      }
      if (SystemStore != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(SystemStore);
      }
      if (SystemVipPoints != 0) {
        output.WriteRawTag(64);
        output.WriteUInt32(SystemVipPoints);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Level);
      }
      if (Exp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Exp);
      }
      if (LevelReward != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(LevelReward);
      }
      if (VipName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(VipName);
      }
      if (SystemDailyBonus != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(SystemDailyBonus);
      }
      if (SystemTimerBonus != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SystemTimerBonus);
      }
      if (SystemStore != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SystemStore);
      }
      if (SystemVipPoints != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(SystemVipPoints);
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
            Exp = input.ReadUInt32();
            break;
          }
          case 24: {
            LevelReward = input.ReadUInt32();
            break;
          }
          case 34: {
            VipName = input.ReadString();
            break;
          }
          case 40: {
            SystemDailyBonus = input.ReadUInt64();
            break;
          }
          case 48: {
            SystemTimerBonus = input.ReadUInt32();
            break;
          }
          case 56: {
            SystemStore = input.ReadUInt32();
            break;
          }
          case 64: {
            SystemVipPoints = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// 客户端拉取VIP信息
  /// </summary>
  public sealed class CGetVipInfo : pb::IMessage {
    private static readonly pb::MessageParser<CGetVipInfo> _parser = new pb::MessageParser<CGetVipInfo>(() => new CGetVipInfo());
    public static pb::MessageParser<CGetVipInfo> Parser { get { return _parser; } }

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

  /// <summary>
  /// 服务器返回VIP信息
  /// </summary>
  public sealed class SGetVipInfo : pb::IMessage {
    private static readonly pb::MessageParser<SGetVipInfo> _parser = new pb::MessageParser<SGetVipInfo>(() => new SGetVipInfo());
    public static pb::MessageParser<SGetVipInfo> Parser { get { return _parser; } }

    private static readonly pb::FieldCodec<global::DragonU3DSDK.Network.API.ILProtocol.VipLevelConfig> _repeated_vipConfig_codec
        = pb::FieldCodec.ForMessage(10, global::DragonU3DSDK.Network.API.ILProtocol.VipLevelConfig.Parser);
    private readonly pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.VipLevelConfig> vipConfig_ = new pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.VipLevelConfig>();
    /// <summary>
    /// vip的配置信息
    /// </summary>
    public pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.VipLevelConfig> VipConfig {
      get { return vipConfig_; }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      vipConfig_.WriteTo(output, _repeated_vipConfig_codec);
    }

    public int CalculateSize() {
      int size = 0;
      size += vipConfig_.CalculateSize(_repeated_vipConfig_codec);
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
            vipConfig_.AddEntriesFrom(input, _repeated_vipConfig_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: fortunex_mail.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.ilruntime.Protobuf;
using pbc = global::Google.ilruntime.Protobuf.Collections;
using scg = global::System.Collections.Generic;
namespace DragonU3DSDK.Network.API.ILProtocol {

  #region Messages
  public sealed class LocaleMailInfo : pb::IMessage {
    private static readonly pb::MessageParser<LocaleMailInfo> _parser = new pb::MessageParser<LocaleMailInfo>(() => new LocaleMailInfo());
    public static pb::MessageParser<LocaleMailInfo> Parser { get { return _parser; } }

    private string title_ = "";
    public string Title {
      get { return title_; }
      set {
        title_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private string message_ = "";
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Title.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Title);
      }
      if (Message.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Message);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Title.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Title);
      }
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
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
            Title = input.ReadString();
            break;
          }
          case 18: {
            Message = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed class CommonReward : pb::IMessage {
    private static readonly pb::MessageParser<CommonReward> _parser = new pb::MessageParser<CommonReward>(() => new CommonReward());
    public static pb::MessageParser<CommonReward> Parser { get { return _parser; } }

    private uint rewardId_;
    /// <summary>
    /// ??????id
    /// </summary>
    public uint RewardId {
      get { return rewardId_; }
      set {
        rewardId_ = value;
      }
    }

    private string rewardType_ = "";
    /// <summary>
    /// ????????????
    /// </summary>
    public string RewardType {
      get { return rewardType_; }
      set {
        rewardType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private uint rewardValue_;
    /// <summary>
    /// ???????????????
    /// </summary>
    public uint RewardValue {
      get { return rewardValue_; }
      set {
        rewardValue_ = value;
      }
    }

    private string extra_ = "";
    /// <summary>
    /// ????????????
    /// </summary>
    public string Extra {
      get { return extra_; }
      set {
        extra_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (RewardType.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(RewardType);
      }
      if (RewardId != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(RewardId);
      }
      if (RewardValue != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(RewardValue);
      }
      if (Extra.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Extra);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RewardId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RewardId);
      }
      if (RewardType.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RewardType);
      }
      if (RewardValue != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(RewardValue);
      }
      if (Extra.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Extra);
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
            RewardType = input.ReadString();
            break;
          }
          case 16: {
            RewardId = input.ReadUInt32();
            break;
          }
          case 24: {
            RewardValue = input.ReadUInt32();
            break;
          }
          case 34: {
            Extra = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///??????????????????????????????
  /// </summary>
  public sealed class MailTemplateInfo : pb::IMessage {
    private static readonly pb::MessageParser<MailTemplateInfo> _parser = new pb::MessageParser<MailTemplateInfo>(() => new MailTemplateInfo());
    public static pb::MessageParser<MailTemplateInfo> Parser { get { return _parser; } }

    private global::DragonU3DSDK.Network.API.ILProtocol.LocaleMailInfo mailInfo_;
    public global::DragonU3DSDK.Network.API.ILProtocol.LocaleMailInfo MailInfo {
      get { return mailInfo_; }
      set {
        mailInfo_ = value;
      }
    }

    private static readonly pb::FieldCodec<global::DragonU3DSDK.Network.API.ILProtocol.CommonReward> _repeated_rewards_codec
        = pb::FieldCodec.ForMessage(18, global::DragonU3DSDK.Network.API.ILProtocol.CommonReward.Parser);
    private readonly pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.CommonReward> rewards_ = new pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.CommonReward>();
    public pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.CommonReward> Rewards {
      get { return rewards_; }
    }

    private static readonly pbc::MapField<string, global::DragonU3DSDK.Network.API.ILProtocol.LocaleMailInfo>.Codec _map_localeMailInfos_codec
        = new pbc::MapField<string, global::DragonU3DSDK.Network.API.ILProtocol.LocaleMailInfo>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForMessage(18, global::DragonU3DSDK.Network.API.ILProtocol.LocaleMailInfo.Parser), 26);
    private readonly pbc::MapField<string, global::DragonU3DSDK.Network.API.ILProtocol.LocaleMailInfo> localeMailInfos_ = new pbc::MapField<string, global::DragonU3DSDK.Network.API.ILProtocol.LocaleMailInfo>();
    public pbc::MapField<string, global::DragonU3DSDK.Network.API.ILProtocol.LocaleMailInfo> LocaleMailInfos {
      get { return localeMailInfos_; }
    }

    private uint mailSubType_;
    public uint MailSubType {
      get { return mailSubType_; }
      set {
        mailSubType_ = value;
      }
    }

    private string link_ = "";
    public string Link {
      get { return link_; }
      set {
        link_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private uint validTime_;
    public uint ValidTime {
      get { return validTime_; }
      set {
        validTime_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (mailInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(MailInfo);
      }
      rewards_.WriteTo(output, _repeated_rewards_codec);
      localeMailInfos_.WriteTo(output, _map_localeMailInfos_codec);
      if (MailSubType != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(MailSubType);
      }
      if (Link.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Link);
      }
      if (ValidTime != 0) {
        output.WriteRawTag(48);
        output.WriteUInt32(ValidTime);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (mailInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MailInfo);
      }
      size += rewards_.CalculateSize(_repeated_rewards_codec);
      size += localeMailInfos_.CalculateSize(_map_localeMailInfos_codec);
      if (MailSubType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(MailSubType);
      }
      if (Link.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Link);
      }
      if (ValidTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(ValidTime);
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
            if (mailInfo_ == null) {
              mailInfo_ = new global::DragonU3DSDK.Network.API.ILProtocol.LocaleMailInfo();
            }
            input.ReadMessage(mailInfo_);
            break;
          }
          case 18: {
            rewards_.AddEntriesFrom(input, _repeated_rewards_codec);
            break;
          }
          case 26: {
            localeMailInfos_.AddEntriesFrom(input, _map_localeMailInfos_codec);
            break;
          }
          case 32: {
            MailSubType = input.ReadUInt32();
            break;
          }
          case 42: {
            Link = input.ReadString();
            break;
          }
          case 48: {
            ValidTime = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///??????mail.itemList???
  /// </summary>
  public sealed class MailRewardsPB : pb::IMessage {
    private static readonly pb::MessageParser<MailRewardsPB> _parser = new pb::MessageParser<MailRewardsPB>(() => new MailRewardsPB());
    public static pb::MessageParser<MailRewardsPB> Parser { get { return _parser; } }

    private static readonly pb::FieldCodec<global::DragonU3DSDK.Network.API.ILProtocol.Reward> _repeated_rewards_codec
        = pb::FieldCodec.ForMessage(10, global::DragonU3DSDK.Network.API.ILProtocol.Reward.Parser);
    private readonly pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Reward> rewards_ = new pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Reward>();
    public pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Reward> Rewards {
      get { return rewards_; }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      rewards_.WriteTo(output, _repeated_rewards_codec);
    }

    public int CalculateSize() {
      int size = 0;
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
            rewards_.AddEntriesFrom(input, _repeated_rewards_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// ????????????????????????(?????????mail.proto???bytes?????????)
  /// </summary>
  public sealed class ClaimMailContentForProto : pb::IMessage {
    private static readonly pb::MessageParser<ClaimMailContentForProto> _parser = new pb::MessageParser<ClaimMailContentForProto>(() => new ClaimMailContentForProto());
    public static pb::MessageParser<ClaimMailContentForProto> Parser { get { return _parser; } }

    private static readonly pb::FieldCodec<global::DragonU3DSDK.Network.API.ILProtocol.Item> _repeated_item_codec
        = pb::FieldCodec.ForMessage(10, global::DragonU3DSDK.Network.API.ILProtocol.Item.Parser);
    private readonly pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Item> item_ = new pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Item>();
    public pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Item> Item {
      get { return item_; }
    }

    private global::DragonU3DSDK.Network.API.ILProtocol.UserProfile userProfile_;
    public global::DragonU3DSDK.Network.API.ILProtocol.UserProfile UserProfile {
      get { return userProfile_; }
      set {
        userProfile_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      item_.WriteTo(output, _repeated_item_codec);
      if (userProfile_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(UserProfile);
      }
    }

    public int CalculateSize() {
      int size = 0;
      size += item_.CalculateSize(_repeated_item_codec);
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
            item_.AddEntriesFrom(input, _repeated_item_codec);
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

  /// <summary>
  /// mail_sub_type = 1 ???type="MailSubTypeVipRewards"
  /// </summary>
  public sealed class PBMailVip : pb::IMessage {
    private static readonly pb::MessageParser<PBMailVip> _parser = new pb::MessageParser<PBMailVip>(() => new PBMailVip());
    public static pb::MessageParser<PBMailVip> Parser { get { return _parser; } }

    private static readonly pb::FieldCodec<global::DragonU3DSDK.Network.API.ILProtocol.Reward> _repeated_rewards_codec
        = pb::FieldCodec.ForMessage(10, global::DragonU3DSDK.Network.API.ILProtocol.Reward.Parser);
    private readonly pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Reward> rewards_ = new pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Reward>();
    public pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Reward> Rewards {
      get { return rewards_; }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      rewards_.WriteTo(output, _repeated_rewards_codec);
    }

    public int CalculateSize() {
      int size = 0;
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
            rewards_.AddEntriesFrom(input, _repeated_rewards_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// mail_sub_type = 2 ???type="MailSubTypeAdvertisement"
  /// </summary>
  public sealed class PBMailAdvertisement : pb::IMessage {
    private static readonly pb::MessageParser<PBMailAdvertisement> _parser = new pb::MessageParser<PBMailAdvertisement>(() => new PBMailAdvertisement());
    public static pb::MessageParser<PBMailAdvertisement> Parser { get { return _parser; } }

    private static readonly pb::FieldCodec<global::DragonU3DSDK.Network.API.ILProtocol.Reward> _repeated_rewards_codec
        = pb::FieldCodec.ForMessage(10, global::DragonU3DSDK.Network.API.ILProtocol.Reward.Parser);
    private readonly pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Reward> rewards_ = new pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Reward>();
    public pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Reward> Rewards {
      get { return rewards_; }
    }

    private string advertKey_ = "";
    /// <summary>
    /// ?????????????????????????????????????????????
    /// </summary>
    public string AdvertKey {
      get { return advertKey_; }
      set {
        advertKey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      rewards_.WriteTo(output, _repeated_rewards_codec);
      if (AdvertKey.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AdvertKey);
      }
    }

    public int CalculateSize() {
      int size = 0;
      size += rewards_.CalculateSize(_repeated_rewards_codec);
      if (AdvertKey.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AdvertKey);
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
            rewards_.AddEntriesFrom(input, _repeated_rewards_codec);
            break;
          }
          case 18: {
            AdvertKey = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// mail_sub_type = 3
  /// </summary>
  public sealed class PBMailSeasonEndReward : pb::IMessage {
    private static readonly pb::MessageParser<PBMailSeasonEndReward> _parser = new pb::MessageParser<PBMailSeasonEndReward>(() => new PBMailSeasonEndReward());
    public static pb::MessageParser<PBMailSeasonEndReward> Parser { get { return _parser; } }

    private static readonly pb::FieldCodec<global::DragonU3DSDK.Network.API.ILProtocol.Reward> _repeated_rewards_codec
        = pb::FieldCodec.ForMessage(10, global::DragonU3DSDK.Network.API.ILProtocol.Reward.Parser);
    private readonly pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Reward> rewards_ = new pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Reward>();
    public pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Reward> Rewards {
      get { return rewards_; }
    }

    private string seasonNum_ = "";
    /// <summary>
    /// season???????????? 1
    /// </summary>
    public string SeasonNum {
      get { return seasonNum_; }
      set {
        seasonNum_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      rewards_.WriteTo(output, _repeated_rewards_codec);
      if (SeasonNum.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(SeasonNum);
      }
    }

    public int CalculateSize() {
      int size = 0;
      size += rewards_.CalculateSize(_repeated_rewards_codec);
      if (SeasonNum.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SeasonNum);
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
            rewards_.AddEntriesFrom(input, _repeated_rewards_codec);
            break;
          }
          case 18: {
            SeasonNum = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// mail_sub_type = 5
  /// </summary>
  public sealed class PBMailSeasonLeaderboardReward : pb::IMessage {
    private static readonly pb::MessageParser<PBMailSeasonLeaderboardReward> _parser = new pb::MessageParser<PBMailSeasonLeaderboardReward>(() => new PBMailSeasonLeaderboardReward());
    public static pb::MessageParser<PBMailSeasonLeaderboardReward> Parser { get { return _parser; } }

    private static readonly pb::FieldCodec<global::DragonU3DSDK.Network.API.ILProtocol.Reward> _repeated_rewards_codec
        = pb::FieldCodec.ForMessage(10, global::DragonU3DSDK.Network.API.ILProtocol.Reward.Parser);
    private readonly pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Reward> rewards_ = new pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Reward>();
    public pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Reward> Rewards {
      get { return rewards_; }
    }

    private ulong rank_;
    /// <summary>
    /// ???????????? ??? 1 2 3 
    /// </summary>
    public ulong Rank {
      get { return rank_; }
      set {
        rank_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      rewards_.WriteTo(output, _repeated_rewards_codec);
      if (Rank != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(Rank);
      }
    }

    public int CalculateSize() {
      int size = 0;
      size += rewards_.CalculateSize(_repeated_rewards_codec);
      if (Rank != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Rank);
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
            rewards_.AddEntriesFrom(input, _repeated_rewards_codec);
            break;
          }
          case 16: {
            Rank = input.ReadUInt64();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// ?????????????????????????????????????????????;??????????????????weekendVipMailRefreshTime???????????????????????????
  /// </summary>
  public sealed class CRefreshWeekendVipMail : pb::IMessage {
    private static readonly pb::MessageParser<CRefreshWeekendVipMail> _parser = new pb::MessageParser<CRefreshWeekendVipMail>(() => new CRefreshWeekendVipMail());
    public static pb::MessageParser<CRefreshWeekendVipMail> Parser { get { return _parser; } }

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
  /// </summary>
  public sealed class SRefreshWeekendVipMail : pb::IMessage {
    private static readonly pb::MessageParser<SRefreshWeekendVipMail> _parser = new pb::MessageParser<SRefreshWeekendVipMail>(() => new SRefreshWeekendVipMail());
    public static pb::MessageParser<SRefreshWeekendVipMail> Parser { get { return _parser; } }

    private ulong mailCount_;
    public ulong MailCount {
      get { return mailCount_; }
      set {
        mailCount_ = value;
      }
    }

    private ulong weekendVipMailRefreshTime_;
    public ulong WeekendVipMailRefreshTime {
      get { return weekendVipMailRefreshTime_; }
      set {
        weekendVipMailRefreshTime_ = value;
      }
    }

    private ulong serverTime_;
    public ulong ServerTime {
      get { return serverTime_; }
      set {
        serverTime_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (MailCount != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(MailCount);
      }
      if (WeekendVipMailRefreshTime != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(WeekendVipMailRefreshTime);
      }
      if (ServerTime != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(ServerTime);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (MailCount != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(MailCount);
      }
      if (WeekendVipMailRefreshTime != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(WeekendVipMailRefreshTime);
      }
      if (ServerTime != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ServerTime);
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
            MailCount = input.ReadUInt64();
            break;
          }
          case 16: {
            WeekendVipMailRefreshTime = input.ReadUInt64();
            break;
          }
          case 24: {
            ServerTime = input.ReadUInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

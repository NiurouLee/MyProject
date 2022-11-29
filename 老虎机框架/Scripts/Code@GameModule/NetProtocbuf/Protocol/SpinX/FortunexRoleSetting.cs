// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: fortunex_role_setting.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.ilruntime.Protobuf;
using pbc = global::Google.ilruntime.Protobuf.Collections;
using scg = global::System.Collections.Generic;
namespace DragonU3DSDK.Network.API.ILProtocol {

  #region Messages
  /// <summary>
  /// profile基本信息
  /// </summary>
  public sealed class UserProfileInRole : pb::IMessage {
    private static readonly pb::MessageParser<UserProfileInRole> _parser = new pb::MessageParser<UserProfileInRole>(() => new UserProfileInRole());
    public static pb::MessageParser<UserProfileInRole> Parser { get { return _parser; } }

    private global::DragonU3DSDK.Network.API.ILProtocol.UserBasicInfo userBasicInfo_;
    /// <summary>
    /// 基础数据，名字，头像框，邮箱等在此
    /// </summary>
    public global::DragonU3DSDK.Network.API.ILProtocol.UserBasicInfo UserBasicInfo {
      get { return userBasicInfo_; }
      set {
        userBasicInfo_ = value;
      }
    }

    private ulong coins_;
    /// <summary>
    /// 金币
    /// </summary>
    public ulong Coins {
      get { return coins_; }
      set {
        coins_ = value;
      }
    }

    private ulong diamonds_;
    /// <summary>
    /// 钻石
    /// </summary>
    public ulong Diamonds {
      get { return diamonds_; }
      set {
        diamonds_ = value;
      }
    }

    private global::DragonU3DSDK.Network.API.ILProtocol.UserVipLevelInfo userVipLevelInfo_;
    /// <summary>
    /// vip相关
    /// </summary>
    public global::DragonU3DSDK.Network.API.ILProtocol.UserVipLevelInfo UserVipLevelInfo {
      get { return userVipLevelInfo_; }
      set {
        userVipLevelInfo_ = value;
      }
    }

    private ulong playerId_;
    /// <summary>
    ///用户ID
    /// </summary>
    public ulong PlayerId {
      get { return playerId_; }
      set {
        playerId_ = value;
      }
    }

    private global::DragonU3DSDK.Network.API.ILProtocol.UserLevelInfo userLevelInfo_;
    /// <summary>
    /// 用户等级结构
    /// </summary>
    public global::DragonU3DSDK.Network.API.ILProtocol.UserLevelInfo UserLevelInfo {
      get { return userLevelInfo_; }
      set {
        userLevelInfo_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Coins != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(Coins);
      }
      if (Diamonds != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(Diamonds);
      }
      if (userVipLevelInfo_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(UserVipLevelInfo);
      }
      if (userBasicInfo_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(UserBasicInfo);
      }
      if (PlayerId != 0UL) {
        output.WriteRawTag(48);
        output.WriteUInt64(PlayerId);
      }
      if (userLevelInfo_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(UserLevelInfo);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (userBasicInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UserBasicInfo);
      }
      if (Coins != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Coins);
      }
      if (Diamonds != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Diamonds);
      }
      if (userVipLevelInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UserVipLevelInfo);
      }
      if (PlayerId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(PlayerId);
      }
      if (userLevelInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UserLevelInfo);
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
            Coins = input.ReadUInt64();
            break;
          }
          case 16: {
            Diamonds = input.ReadUInt64();
            break;
          }
          case 34: {
            if (userVipLevelInfo_ == null) {
              userVipLevelInfo_ = new global::DragonU3DSDK.Network.API.ILProtocol.UserVipLevelInfo();
            }
            input.ReadMessage(userVipLevelInfo_);
            break;
          }
          case 42: {
            if (userBasicInfo_ == null) {
              userBasicInfo_ = new global::DragonU3DSDK.Network.API.ILProtocol.UserBasicInfo();
            }
            input.ReadMessage(userBasicInfo_);
            break;
          }
          case 48: {
            PlayerId = input.ReadUInt64();
            break;
          }
          case 58: {
            if (userLevelInfo_ == null) {
              userLevelInfo_ = new global::DragonU3DSDK.Network.API.ILProtocol.UserLevelInfo();
            }
            input.ReadMessage(userLevelInfo_);
            break;
          }
        }
      }
    }

  }

  public sealed class MostPlayedGame : pb::IMessage {
    private static readonly pb::MessageParser<MostPlayedGame> _parser = new pb::MessageParser<MostPlayedGame>(() => new MostPlayedGame());
    public static pb::MessageParser<MostPlayedGame> Parser { get { return _parser; } }

    private string gameId_ = "";
    public string GameId {
      get { return gameId_; }
      set {
        gameId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (GameId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(GameId);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (GameId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(GameId);
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
            GameId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// 用户games的统计信息
  /// </summary>
  public sealed class UserGamesInfoInRole : pb::IMessage {
    private static readonly pb::MessageParser<UserGamesInfoInRole> _parser = new pb::MessageParser<UserGamesInfoInRole>(() => new UserGamesInfoInRole());
    public static pb::MessageParser<UserGamesInfoInRole> Parser { get { return _parser; } }

    private ulong totalSpin_;
    /// <summary>
    /// 用户一共spin的次数
    /// </summary>
    public ulong TotalSpin {
      get { return totalSpin_; }
      set {
        totalSpin_ = value;
      }
    }

    private ulong totalWin_;
    /// <summary>
    /// 用户所有的赢钱
    /// </summary>
    public ulong TotalWin {
      get { return totalWin_; }
      set {
        totalWin_ = value;
      }
    }

    private ulong biggestWin_;
    /// <summary>
    /// 用户total win栏中出现过的最大赢钱数
    /// </summary>
    public ulong BiggestWin {
      get { return biggestWin_; }
      set {
        biggestWin_ = value;
      }
    }

    private ulong jackpotHit_;
    /// <summary>
    /// 用户jackpot 的次数
    /// </summary>
    public ulong JackpotHit {
      get { return jackpotHit_; }
      set {
        jackpotHit_ = value;
      }
    }

    private ulong bigWin_;
    /// <summary>
    /// 用户获得spicial win的次数
    /// </summary>
    public ulong BigWin {
      get { return bigWin_; }
      set {
        bigWin_ = value;
      }
    }

    private static readonly pb::FieldCodec<global::DragonU3DSDK.Network.API.ILProtocol.MostPlayedGame> _repeated_mostPlayed_codec
        = pb::FieldCodec.ForMessage(50, global::DragonU3DSDK.Network.API.ILProtocol.MostPlayedGame.Parser);
    private readonly pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.MostPlayedGame> mostPlayed_ = new pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.MostPlayedGame>();
    /// <summary>
    /// 用户消耗bet的spin次数最多的前三名
    /// </summary>
    public pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.MostPlayedGame> MostPlayed {
      get { return mostPlayed_; }
    }

    private string totalWinBigInt_ = "";
    /// <summary>
    /// 用户所有的赢钱-大数版本（数字字符串）
    /// </summary>
    public string TotalWinBigInt {
      get { return totalWinBigInt_; }
      set {
        totalWinBigInt_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (TotalSpin != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(TotalSpin);
      }
      if (TotalWin != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(TotalWin);
      }
      if (BiggestWin != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(BiggestWin);
      }
      if (JackpotHit != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(JackpotHit);
      }
      if (BigWin != 0UL) {
        output.WriteRawTag(40);
        output.WriteUInt64(BigWin);
      }
      mostPlayed_.WriteTo(output, _repeated_mostPlayed_codec);
      if (TotalWinBigInt.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(TotalWinBigInt);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (TotalSpin != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TotalSpin);
      }
      if (TotalWin != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TotalWin);
      }
      if (BiggestWin != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(BiggestWin);
      }
      if (JackpotHit != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(JackpotHit);
      }
      if (BigWin != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(BigWin);
      }
      size += mostPlayed_.CalculateSize(_repeated_mostPlayed_codec);
      if (TotalWinBigInt.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TotalWinBigInt);
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
            TotalSpin = input.ReadUInt64();
            break;
          }
          case 16: {
            TotalWin = input.ReadUInt64();
            break;
          }
          case 24: {
            BiggestWin = input.ReadUInt64();
            break;
          }
          case 32: {
            JackpotHit = input.ReadUInt64();
            break;
          }
          case 40: {
            BigWin = input.ReadUInt64();
            break;
          }
          case 50: {
            mostPlayed_.AddEntriesFrom(input, _repeated_mostPlayed_codec);
            break;
          }
          case 58: {
            TotalWinBigInt = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed class UserRoleInfo : pb::IMessage {
    private static readonly pb::MessageParser<UserRoleInfo> _parser = new pb::MessageParser<UserRoleInfo>(() => new UserRoleInfo());
    public static pb::MessageParser<UserRoleInfo> Parser { get { return _parser; } }

    private global::DragonU3DSDK.Network.API.ILProtocol.UserProfileInRole userBaseInfo_;
    /// <summary>
    /// profile信息
    /// </summary>
    public global::DragonU3DSDK.Network.API.ILProtocol.UserProfileInRole UserBaseInfo {
      get { return userBaseInfo_; }
      set {
        userBaseInfo_ = value;
      }
    }

    private global::DragonU3DSDK.Network.API.ILProtocol.UserGamesInfoInRole gameStatInfo_;
    /// <summary>
    /// games统计信息
    /// </summary>
    public global::DragonU3DSDK.Network.API.ILProtocol.UserGamesInfoInRole GameStatInfo {
      get { return gameStatInfo_; }
      set {
        gameStatInfo_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (userBaseInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(UserBaseInfo);
      }
      if (gameStatInfo_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(GameStatInfo);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (userBaseInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UserBaseInfo);
      }
      if (gameStatInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GameStatInfo);
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
            if (userBaseInfo_ == null) {
              userBaseInfo_ = new global::DragonU3DSDK.Network.API.ILProtocol.UserProfileInRole();
            }
            input.ReadMessage(userBaseInfo_);
            break;
          }
          case 18: {
            if (gameStatInfo_ == null) {
              gameStatInfo_ = new global::DragonU3DSDK.Network.API.ILProtocol.UserGamesInfoInRole();
            }
            input.ReadMessage(gameStatInfo_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///客户端发起：获取用户角色面板的信息
  /// </summary>
  public sealed class CGetUserProfileInRole : pb::IMessage {
    private static readonly pb::MessageParser<CGetUserProfileInRole> _parser = new pb::MessageParser<CGetUserProfileInRole>(() => new CGetUserProfileInRole());
    public static pb::MessageParser<CGetUserProfileInRole> Parser { get { return _parser; } }

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
  ///服务端返回角色面板的信息
  /// </summary>
  public sealed class SGetUserProfileInRole : pb::IMessage {
    private static readonly pb::MessageParser<SGetUserProfileInRole> _parser = new pb::MessageParser<SGetUserProfileInRole>(() => new SGetUserProfileInRole());
    public static pb::MessageParser<SGetUserProfileInRole> Parser { get { return _parser; } }

    private global::DragonU3DSDK.Network.API.ILProtocol.UserRoleInfo roleInfo_;
    public global::DragonU3DSDK.Network.API.ILProtocol.UserRoleInfo RoleInfo {
      get { return roleInfo_; }
      set {
        roleInfo_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (roleInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(RoleInfo);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (roleInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RoleInfo);
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
            if (roleInfo_ == null) {
              roleInfo_ = new global::DragonU3DSDK.Network.API.ILProtocol.UserRoleInfo();
            }
            input.ReadMessage(roleInfo_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// 获取facebook绑定奖励
  /// </summary>
  public sealed class CClaimFacebookBindingReward : pb::IMessage {
    private static readonly pb::MessageParser<CClaimFacebookBindingReward> _parser = new pb::MessageParser<CClaimFacebookBindingReward>(() => new CClaimFacebookBindingReward());
    public static pb::MessageParser<CClaimFacebookBindingReward> Parser { get { return _parser; } }

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

  public sealed class SClaimFacebookBindingReward : pb::IMessage {
    private static readonly pb::MessageParser<SClaimFacebookBindingReward> _parser = new pb::MessageParser<SClaimFacebookBindingReward>(() => new SClaimFacebookBindingReward());
    public static pb::MessageParser<SClaimFacebookBindingReward> Parser { get { return _parser; } }

    private static readonly pb::FieldCodec<global::DragonU3DSDK.Network.API.ILProtocol.Reward> _repeated_rewards_codec
        = pb::FieldCodec.ForMessage(10, global::DragonU3DSDK.Network.API.ILProtocol.Reward.Parser);
    private readonly pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Reward> rewards_ = new pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Reward>();
    /// <summary>
    /// 奖励列表
    /// </summary>
    public pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Reward> Rewards {
      get { return rewards_; }
    }

    private global::DragonU3DSDK.Network.API.ILProtocol.UserProfile userProfile_;
    /// <summary>
    /// userProfile信息
    /// </summary>
    public global::DragonU3DSDK.Network.API.ILProtocol.UserProfile UserProfile {
      get { return userProfile_; }
      set {
        userProfile_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      rewards_.WriteTo(output, _repeated_rewards_codec);
      if (userProfile_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(UserProfile);
      }
    }

    public int CalculateSize() {
      int size = 0;
      size += rewards_.CalculateSize(_repeated_rewards_codec);
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
            rewards_.AddEntriesFrom(input, _repeated_rewards_codec);
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
  /// 获取apple绑定奖励
  /// </summary>
  public sealed class CClaimAppleBindingReward : pb::IMessage {
    private static readonly pb::MessageParser<CClaimAppleBindingReward> _parser = new pb::MessageParser<CClaimAppleBindingReward>(() => new CClaimAppleBindingReward());
    public static pb::MessageParser<CClaimAppleBindingReward> Parser { get { return _parser; } }

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

  public sealed class SClaimAppleBindingReward : pb::IMessage {
    private static readonly pb::MessageParser<SClaimAppleBindingReward> _parser = new pb::MessageParser<SClaimAppleBindingReward>(() => new SClaimAppleBindingReward());
    public static pb::MessageParser<SClaimAppleBindingReward> Parser { get { return _parser; } }

    private static readonly pb::FieldCodec<global::DragonU3DSDK.Network.API.ILProtocol.Reward> _repeated_rewards_codec
        = pb::FieldCodec.ForMessage(10, global::DragonU3DSDK.Network.API.ILProtocol.Reward.Parser);
    private readonly pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Reward> rewards_ = new pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Reward>();
    /// <summary>
    /// 奖励列表
    /// </summary>
    public pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Reward> Rewards {
      get { return rewards_; }
    }

    private global::DragonU3DSDK.Network.API.ILProtocol.UserProfile userProfile_;
    /// <summary>
    /// userProfile信息
    /// </summary>
    public global::DragonU3DSDK.Network.API.ILProtocol.UserProfile UserProfile {
      get { return userProfile_; }
      set {
        userProfile_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      rewards_.WriteTo(output, _repeated_rewards_codec);
      if (userProfile_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(UserProfile);
      }
    }

    public int CalculateSize() {
      int size = 0;
      size += rewards_.CalculateSize(_repeated_rewards_codec);
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
            rewards_.AddEntriesFrom(input, _repeated_rewards_codec);
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

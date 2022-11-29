// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: spinx_common.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.ilruntime.Protobuf;
using pbc = global::Google.ilruntime.Protobuf.Collections;
using scg = global::System.Collections.Generic;
namespace DragonU3DSDK.Network.API.ILProtocol {

  #region Enums
  public enum WinLevel {
    Invalid = 0,
    Small = 1,
    Middle = 2,
    Big = 3,
    Huge = 4,
    Massive = 5,
    Epic = 6,
    Colossal = 7,
  }

  /// <summary>
  /// 阵营枚举
  /// </summary>
  public enum GameRoomCampType {
    /// <summary>
    /// 红方
    /// </summary>
    CampRed = 0,
    /// <summary>
    /// 蓝方
    /// </summary>
    CampBlue = 1,
    CampMax = 2,
  }

  #endregion

  #region Messages
  /// <summary>
  /// 任意类型
  /// </summary>
  public sealed class AnyStruct : pb::IMessage {
    private static readonly pb::MessageParser<AnyStruct> _parser = new pb::MessageParser<AnyStruct>(() => new AnyStruct());
    public static pb::MessageParser<AnyStruct> Parser { get { return _parser; } }

    private string type_ = "";
    /// <summary>
    /// 结构类型
    /// </summary>
    public string Type {
      get { return type_; }
      set {
        type_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private pb::ByteString data_ = pb::ByteString.Empty;
    /// <summary>
    /// pb格式数据
    /// </summary>
    public pb::ByteString Data {
      get { return data_; }
      set {
        data_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Type.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Type);
      }
      if (Data.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(Data);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Type.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Type);
      }
      if (Data.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Data);
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
            Type = input.ReadString();
            break;
          }
          case 18: {
            Data = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// 房间成员信息
  /// </summary>
  public sealed class GameRoomMemberInfo : pb::IMessage {
    private static readonly pb::MessageParser<GameRoomMemberInfo> _parser = new pb::MessageParser<GameRoomMemberInfo>(() => new GameRoomMemberInfo());
    public static pb::MessageParser<GameRoomMemberInfo> Parser { get { return _parser; } }

    private uint playerId_;
    /// <summary>
    /// 玩家id
    /// </summary>
    public uint PlayerId {
      get { return playerId_; }
      set {
        playerId_ = value;
      }
    }

    private string avatarId_ = "";
    /// <summary>
    /// 玩家头像id
    /// </summary>
    public string AvatarId {
      get { return avatarId_; }
      set {
        avatarId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private string avatarFrameId_ = "";
    /// <summary>
    /// 头像框id
    /// </summary>
    public string AvatarFrameId {
      get { return avatarFrameId_; }
      set {
        avatarFrameId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private int camp_;
    /// <summary>
    /// 所在阵营id
    /// </summary>
    public int Camp {
      get { return camp_; }
      set {
        camp_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (PlayerId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(PlayerId);
      }
      if (AvatarId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AvatarId);
      }
      if (AvatarFrameId.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(AvatarFrameId);
      }
      if (Camp != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Camp);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (PlayerId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PlayerId);
      }
      if (AvatarId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AvatarId);
      }
      if (AvatarFrameId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AvatarFrameId);
      }
      if (Camp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Camp);
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
            PlayerId = input.ReadUInt32();
            break;
          }
          case 18: {
            AvatarId = input.ReadString();
            break;
          }
          case 26: {
            AvatarFrameId = input.ReadString();
            break;
          }
          case 32: {
            Camp = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// 房间信息
  /// </summary>
  public sealed class GameRoomInfo : pb::IMessage {
    private static readonly pb::MessageParser<GameRoomInfo> _parser = new pb::MessageParser<GameRoomInfo>(() => new GameRoomInfo());
    public static pb::MessageParser<GameRoomInfo> Parser { get { return _parser; } }

    private string roomId_ = "";
    /// <summary>
    /// 房间id
    /// </summary>
    public string RoomId {
      get { return roomId_; }
      set {
        roomId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private string gameId_ = "";
    /// <summary>
    /// 房间对应的机台id
    /// </summary>
    public string GameId {
      get { return gameId_; }
      set {
        gameId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private static readonly pb::FieldCodec<global::DragonU3DSDK.Network.API.ILProtocol.GameRoomMemberInfo> _repeated_players_codec
        = pb::FieldCodec.ForMessage(26, global::DragonU3DSDK.Network.API.ILProtocol.GameRoomMemberInfo.Parser);
    private readonly pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.GameRoomMemberInfo> players_ = new pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.GameRoomMemberInfo>();
    /// <summary>
    /// 房间里的玩家列表
    /// </summary>
    public pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.GameRoomMemberInfo> Players {
      get { return players_; }
    }

    private uint campRedPlayerCount_;
    /// <summary>
    /// 红方玩家数量
    /// </summary>
    public uint CampRedPlayerCount {
      get { return campRedPlayerCount_; }
      set {
        campRedPlayerCount_ = value;
      }
    }

    private uint campBluePlayerCount_;
    /// <summary>
    /// 蓝方玩家数量
    /// </summary>
    public uint CampBluePlayerCount {
      get { return campBluePlayerCount_; }
      set {
        campBluePlayerCount_ = value;
      }
    }

    private global::DragonU3DSDK.Network.API.ILProtocol.AnyStruct extraInfo_;
    /// <summary>
    /// 房间扩展信息
    /// </summary>
    public global::DragonU3DSDK.Network.API.ILProtocol.AnyStruct ExtraInfo {
      get { return extraInfo_; }
      set {
        extraInfo_ = value;
      }
    }

    private uint status_;
    /// <summary>
    /// 房间状态，0 正常，1中了bonus，2删除
    /// </summary>
    public uint Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    private ulong expire_;
    /// <summary>
    /// 房间过期时间
    /// </summary>
    public ulong Expire {
      get { return expire_; }
      set {
        expire_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (RoomId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(RoomId);
      }
      if (GameId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(GameId);
      }
      players_.WriteTo(output, _repeated_players_codec);
      if (CampRedPlayerCount != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(CampRedPlayerCount);
      }
      if (CampBluePlayerCount != 0) {
        output.WriteRawTag(40);
        output.WriteUInt32(CampBluePlayerCount);
      }
      if (extraInfo_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(ExtraInfo);
      }
      if (Status != 0) {
        output.WriteRawTag(56);
        output.WriteUInt32(Status);
      }
      if (Expire != 0UL) {
        output.WriteRawTag(64);
        output.WriteUInt64(Expire);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (RoomId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RoomId);
      }
      if (GameId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(GameId);
      }
      size += players_.CalculateSize(_repeated_players_codec);
      if (CampRedPlayerCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CampRedPlayerCount);
      }
      if (CampBluePlayerCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CampBluePlayerCount);
      }
      if (extraInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ExtraInfo);
      }
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Status);
      }
      if (Expire != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Expire);
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
            RoomId = input.ReadString();
            break;
          }
          case 18: {
            GameId = input.ReadString();
            break;
          }
          case 26: {
            players_.AddEntriesFrom(input, _repeated_players_codec);
            break;
          }
          case 32: {
            CampRedPlayerCount = input.ReadUInt32();
            break;
          }
          case 40: {
            CampBluePlayerCount = input.ReadUInt32();
            break;
          }
          case 50: {
            if (extraInfo_ == null) {
              extraInfo_ = new global::DragonU3DSDK.Network.API.ILProtocol.AnyStruct();
            }
            input.ReadMessage(extraInfo_);
            break;
          }
          case 56: {
            Status = input.ReadUInt32();
            break;
          }
          case 64: {
            Expire = input.ReadUInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

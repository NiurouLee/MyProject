// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: fortunex_shop.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.ilruntime.Protobuf;
using pbc = global::Google.ilruntime.Protobuf.Collections;
using scg = global::System.Collections.Generic;
namespace DragonU3DSDK.Network.API.ILProtocol {

  #region Messages
  /// <summary>
  /// payment内容
  /// </summary>
  public sealed class PaymentInfo : pb::IMessage {
    private static readonly pb::MessageParser<PaymentInfo> _parser = new pb::MessageParser<PaymentInfo>(() => new PaymentInfo());
    public static pb::MessageParser<PaymentInfo> Parser { get { return _parser; } }

    private uint paymentId_;
    /// <summary>
    /// 商品id
    /// </summary>
    public uint PaymentId {
      get { return paymentId_; }
      set {
        paymentId_ = value;
      }
    }

    private string productIdAndroid_ = "";
    /// <summary>
    /// 商品在GooglePlay对应的id
    /// </summary>
    public string ProductIdAndroid {
      get { return productIdAndroid_; }
      set {
        productIdAndroid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    private string productIdIos_ = "";
    /// <summary>
    /// 商品在IOS对应的id
    /// </summary>
    public string ProductIdIos {
      get { return productIdIos_; }
      set {
        productIdIos_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (PaymentId != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(PaymentId);
      }
      if (ProductIdAndroid.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ProductIdAndroid);
      }
      if (ProductIdIos.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ProductIdIos);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (PaymentId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PaymentId);
      }
      if (ProductIdAndroid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProductIdAndroid);
      }
      if (ProductIdIos.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProductIdIos);
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
            PaymentId = input.ReadUInt32();
            break;
          }
          case 18: {
            ProductIdAndroid = input.ReadString();
            break;
          }
          case 26: {
            ProductIdIos = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// StoreBonus内容
  /// </summary>
  public sealed class StoreBonus : pb::IMessage {
    private static readonly pb::MessageParser<StoreBonus> _parser = new pb::MessageParser<StoreBonus>(() => new StoreBonus());
    public static pb::MessageParser<StoreBonus> Parser { get { return _parser; } }

    private bool canGet_;
    /// <summary>
    /// 是否可以领取
    /// </summary>
    public bool CanGet {
      get { return canGet_; }
      set {
        canGet_ = value;
      }
    }

    private uint countdownTime_;
    /// <summary>
    /// 领取倒计时(秒)
    /// </summary>
    public uint CountdownTime {
      get { return countdownTime_; }
      set {
        countdownTime_ = value;
      }
    }

    private ulong coins_;
    /// <summary>
    /// 可领取的金币(可以领取的时候展示)
    /// </summary>
    public ulong Coins {
      get { return coins_; }
      set {
        coins_ = value;
      }
    }

    private string description_ = "";
    /// <summary>
    /// 描述
    /// </summary>
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (CanGet != false) {
        output.WriteRawTag(8);
        output.WriteBool(CanGet);
      }
      if (CountdownTime != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CountdownTime);
      }
      if (Coins != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(Coins);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Description);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (CanGet != false) {
        size += 1 + 1;
      }
      if (CountdownTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CountdownTime);
      }
      if (Coins != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Coins);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
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
            CanGet = input.ReadBool();
            break;
          }
          case 16: {
            CountdownTime = input.ReadUInt32();
            break;
          }
          case 24: {
            Coins = input.ReadUInt64();
            break;
          }
          case 34: {
            Description = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// 支付相关内容基本信息
  /// </summary>
  public sealed class PaymentBaseInfo : pb::IMessage {
    private static readonly pb::MessageParser<PaymentBaseInfo> _parser = new pb::MessageParser<PaymentBaseInfo>(() => new PaymentBaseInfo());
    public static pb::MessageParser<PaymentBaseInfo> Parser { get { return _parser; } }

    private static readonly pb::FieldCodec<global::DragonU3DSDK.Network.API.ILProtocol.PaymentInfo> _repeated_itemList_codec
        = pb::FieldCodec.ForMessage(10, global::DragonU3DSDK.Network.API.ILProtocol.PaymentInfo.Parser);
    private readonly pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.PaymentInfo> itemList_ = new pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.PaymentInfo>();
    /// <summary>
    /// 所有的商品payment信息
    /// </summary>
    public pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.PaymentInfo> ItemList {
      get { return itemList_; }
    }

    private global::DragonU3DSDK.Network.API.ILProtocol.StoreBonus storeBonus_;
    /// <summary>
    /// storeBonus内容
    /// </summary>
    public global::DragonU3DSDK.Network.API.ILProtocol.StoreBonus StoreBonus {
      get { return storeBonus_; }
      set {
        storeBonus_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      itemList_.WriteTo(output, _repeated_itemList_codec);
      if (storeBonus_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(StoreBonus);
      }
    }

    public int CalculateSize() {
      int size = 0;
      size += itemList_.CalculateSize(_repeated_itemList_codec);
      if (storeBonus_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StoreBonus);
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
            itemList_.AddEntriesFrom(input, _repeated_itemList_codec);
            break;
          }
          case 18: {
            if (storeBonus_ == null) {
              storeBonus_ = new global::DragonU3DSDK.Network.API.ILProtocol.StoreBonus();
            }
            input.ReadMessage(storeBonus_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// 客户端获取商店信息
  /// </summary>
  public sealed class CGetShop : pb::IMessage {
    private static readonly pb::MessageParser<CGetShop> _parser = new pb::MessageParser<CGetShop>(() => new CGetShop());
    public static pb::MessageParser<CGetShop> Parser { get { return _parser; } }

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
  /// 服务器返回商店信息
  /// </summary>
  public sealed class SGetShop : pb::IMessage {
    private static readonly pb::MessageParser<SGetShop> _parser = new pb::MessageParser<SGetShop>(() => new SGetShop());
    public static pb::MessageParser<SGetShop> Parser { get { return _parser; } }

    private static readonly pb::FieldCodec<string> _repeated_adContent_codec
        = pb::FieldCodec.ForString(10);
    private readonly pbc::RepeatedField<string> adContent_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// 广告语
    /// </summary>
    public pbc::RepeatedField<string> AdContent {
      get { return adContent_; }
    }

    private uint vipLevel_;
    /// <summary>
    /// vip等级
    /// </summary>
    public uint VipLevel {
      get { return vipLevel_; }
      set {
        vipLevel_ = value;
      }
    }

    private float vipCoinAddition_;
    /// <summary>
    /// vip金币加成
    /// </summary>
    public float VipCoinAddition {
      get { return vipCoinAddition_; }
      set {
        vipCoinAddition_ = value;
      }
    }

    private static readonly pb::FieldCodec<global::DragonU3DSDK.Network.API.ILProtocol.ShopItemConfig> _repeated_itemList_codec
        = pb::FieldCodec.ForMessage(34, global::DragonU3DSDK.Network.API.ILProtocol.ShopItemConfig.Parser);
    private readonly pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.ShopItemConfig> itemList_ = new pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.ShopItemConfig>();
    /// <summary>
    /// 商品列表
    /// </summary>
    public pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.ShopItemConfig> ItemList {
      get { return itemList_; }
    }

    private global::DragonU3DSDK.Network.API.ILProtocol.GiftBox giftBox_;
    /// <summary>
    /// giftBox内容
    /// </summary>
    public global::DragonU3DSDK.Network.API.ILProtocol.GiftBox GiftBox {
      get { return giftBox_; }
      set {
        giftBox_ = value;
      }
    }

    private global::DragonU3DSDK.Network.API.ILProtocol.StoreBonus storeBonus_;
    /// <summary>
    /// storeBonus内容
    /// </summary>
    public global::DragonU3DSDK.Network.API.ILProtocol.StoreBonus StoreBonus {
      get { return storeBonus_; }
      set {
        storeBonus_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      adContent_.WriteTo(output, _repeated_adContent_codec);
      if (VipLevel != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(VipLevel);
      }
      if (VipCoinAddition != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(VipCoinAddition);
      }
      itemList_.WriteTo(output, _repeated_itemList_codec);
      if (giftBox_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(GiftBox);
      }
      if (storeBonus_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(StoreBonus);
      }
    }

    public int CalculateSize() {
      int size = 0;
      size += adContent_.CalculateSize(_repeated_adContent_codec);
      if (VipLevel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(VipLevel);
      }
      if (VipCoinAddition != 0F) {
        size += 1 + 4;
      }
      size += itemList_.CalculateSize(_repeated_itemList_codec);
      if (giftBox_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(GiftBox);
      }
      if (storeBonus_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StoreBonus);
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
            adContent_.AddEntriesFrom(input, _repeated_adContent_codec);
            break;
          }
          case 16: {
            VipLevel = input.ReadUInt32();
            break;
          }
          case 29: {
            VipCoinAddition = input.ReadFloat();
            break;
          }
          case 34: {
            itemList_.AddEntriesFrom(input, _repeated_itemList_codec);
            break;
          }
          case 42: {
            if (giftBox_ == null) {
              giftBox_ = new global::DragonU3DSDK.Network.API.ILProtocol.GiftBox();
            }
            input.ReadMessage(giftBox_);
            break;
          }
          case 50: {
            if (storeBonus_ == null) {
              storeBonus_ = new global::DragonU3DSDK.Network.API.ILProtocol.StoreBonus();
            }
            input.ReadMessage(storeBonus_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// 客户端领取storeBonus奖励
  /// </summary>
  public sealed class CGetStoreBonus : pb::IMessage {
    private static readonly pb::MessageParser<CGetStoreBonus> _parser = new pb::MessageParser<CGetStoreBonus>(() => new CGetStoreBonus());
    public static pb::MessageParser<CGetStoreBonus> Parser { get { return _parser; } }

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
  /// 服务器返回StoreBonus领取结果
  /// </summary>
  public sealed class SGetStoreBonus : pb::IMessage {
    private static readonly pb::MessageParser<SGetStoreBonus> _parser = new pb::MessageParser<SGetStoreBonus>(() => new SGetStoreBonus());
    public static pb::MessageParser<SGetStoreBonus> Parser { get { return _parser; } }

    private ulong addCoins_;
    /// <summary>
    /// 奖励的coin数量
    /// </summary>
    public ulong AddCoins {
      get { return addCoins_; }
      set {
        addCoins_ = value;
      }
    }

    private uint countdownTime_;
    /// <summary>
    /// 到下次能领取的倒计时(秒)
    /// </summary>
    public uint CountdownTime {
      get { return countdownTime_; }
      set {
        countdownTime_ = value;
      }
    }

    private global::DragonU3DSDK.Network.API.ILProtocol.UserProfile userProfile_;
    /// <summary>
    /// 用户信息
    /// </summary>
    public global::DragonU3DSDK.Network.API.ILProtocol.UserProfile UserProfile {
      get { return userProfile_; }
      set {
        userProfile_ = value;
      }
    }

    private static readonly pb::FieldCodec<global::DragonU3DSDK.Network.API.ILProtocol.Reward> _repeated_extraRewards_codec
        = pb::FieldCodec.ForMessage(34, global::DragonU3DSDK.Network.API.ILProtocol.Reward.Parser);
    private readonly pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Reward> extraRewards_ = new pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Reward>();
    /// <summary>
    /// 额外奖励reward
    /// </summary>
    public pbc::RepeatedField<global::DragonU3DSDK.Network.API.ILProtocol.Reward> ExtraRewards {
      get { return extraRewards_; }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (AddCoins != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(AddCoins);
      }
      if (CountdownTime != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(CountdownTime);
      }
      if (userProfile_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(UserProfile);
      }
      extraRewards_.WriteTo(output, _repeated_extraRewards_codec);
    }

    public int CalculateSize() {
      int size = 0;
      if (AddCoins != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(AddCoins);
      }
      if (CountdownTime != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(CountdownTime);
      }
      if (userProfile_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(UserProfile);
      }
      size += extraRewards_.CalculateSize(_repeated_extraRewards_codec);
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
            AddCoins = input.ReadUInt64();
            break;
          }
          case 16: {
            CountdownTime = input.ReadUInt32();
            break;
          }
          case 26: {
            if (userProfile_ == null) {
              userProfile_ = new global::DragonU3DSDK.Network.API.ILProtocol.UserProfile();
            }
            input.ReadMessage(userProfile_);
            break;
          }
          case 34: {
            extraRewards_.AddEntriesFrom(input, _repeated_extraRewards_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// 客户端领取giftBox奖励
  /// </summary>
  public sealed class CGetGiftBox : pb::IMessage {
    private static readonly pb::MessageParser<CGetGiftBox> _parser = new pb::MessageParser<CGetGiftBox>(() => new CGetGiftBox());
    public static pb::MessageParser<CGetGiftBox> Parser { get { return _parser; } }

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
  /// 服务器返回giftBox领取结果
  /// </summary>
  public sealed class SGetGiftBox : pb::IMessage {
    private static readonly pb::MessageParser<SGetGiftBox> _parser = new pb::MessageParser<SGetGiftBox>(() => new SGetGiftBox());
    public static pb::MessageParser<SGetGiftBox> Parser { get { return _parser; } }

    private ulong addCoins_;
    /// <summary>
    /// 奖励的coin数量
    /// </summary>
    public ulong AddCoins {
      get { return addCoins_; }
      set {
        addCoins_ = value;
      }
    }

    private global::DragonU3DSDK.Network.API.ILProtocol.UserProfile userProfile_;
    /// <summary>
    /// 用户信息
    /// </summary>
    public global::DragonU3DSDK.Network.API.ILProtocol.UserProfile UserProfile {
      get { return userProfile_; }
      set {
        userProfile_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (AddCoins != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(AddCoins);
      }
      if (userProfile_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(UserProfile);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (AddCoins != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(AddCoins);
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
          case 8: {
            AddCoins = input.ReadUInt64();
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
  /// 客户端拉取支付相关内容基本信息(大厅展示内容相关)
  /// </summary>
  public sealed class CGetPaymentBaseInfo : pb::IMessage {
    private static readonly pb::MessageParser<CGetPaymentBaseInfo> _parser = new pb::MessageParser<CGetPaymentBaseInfo>(() => new CGetPaymentBaseInfo());
    public static pb::MessageParser<CGetPaymentBaseInfo> Parser { get { return _parser; } }

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
  /// 服务器返回支付相关内容基本信息
  /// </summary>
  public sealed class SGetPaymentBaseInfo : pb::IMessage {
    private static readonly pb::MessageParser<SGetPaymentBaseInfo> _parser = new pb::MessageParser<SGetPaymentBaseInfo>(() => new SGetPaymentBaseInfo());
    public static pb::MessageParser<SGetPaymentBaseInfo> Parser { get { return _parser; } }

    private global::DragonU3DSDK.Network.API.ILProtocol.PaymentBaseInfo baseInfo_;
    /// <summary>
    /// 基本信息
    /// </summary>
    public global::DragonU3DSDK.Network.API.ILProtocol.PaymentBaseInfo BaseInfo {
      get { return baseInfo_; }
      set {
        baseInfo_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (baseInfo_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(BaseInfo);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (baseInfo_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BaseInfo);
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
            if (baseInfo_ == null) {
              baseInfo_ = new global::DragonU3DSDK.Network.API.ILProtocol.PaymentBaseInfo();
            }
            input.ReadMessage(baseInfo_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

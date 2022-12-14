// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: fortune_x_super_spin.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.ilruntime.Protobuf;
using pbc = global::Google.ilruntime.Protobuf.Collections;
using scg = global::System.Collections.Generic;
namespace DragonU3DSDK.Network.API.ILProtocol {

  #region Messages
  /// <summary>
  /// 获取superspin系统的支付项信息
  /// </summary>
  public sealed class CGetSuperSpinPaymentInfo : pb::IMessage {
    private static readonly pb::MessageParser<CGetSuperSpinPaymentInfo> _parser = new pb::MessageParser<CGetSuperSpinPaymentInfo>(() => new CGetSuperSpinPaymentInfo());
    public static pb::MessageParser<CGetSuperSpinPaymentInfo> Parser { get { return _parser; } }

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

  public sealed class SGetSuperSpinPaymentInfo : pb::IMessage {
    private static readonly pb::MessageParser<SGetSuperSpinPaymentInfo> _parser = new pb::MessageParser<SGetSuperSpinPaymentInfo>(() => new SGetSuperSpinPaymentInfo());
    public static pb::MessageParser<SGetSuperSpinPaymentInfo> Parser { get { return _parser; } }

    private bool canBuy_;
    /// <summary>
    /// 是否可以买
    /// </summary>
    public bool CanBuy {
      get { return canBuy_; }
      set {
        canBuy_ = value;
      }
    }

    private global::DragonU3DSDK.Network.API.ILProtocol.ShopItemConfig shopItem_;
    /// <summary>
    /// 支付项信息，仅can_buy = true时读取该字段
    /// </summary>
    public global::DragonU3DSDK.Network.API.ILProtocol.ShopItemConfig ShopItem {
      get { return shopItem_; }
      set {
        shopItem_ = value;
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (CanBuy != false) {
        output.WriteRawTag(8);
        output.WriteBool(CanBuy);
      }
      if (shopItem_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ShopItem);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (CanBuy != false) {
        size += 1 + 1;
      }
      if (shopItem_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ShopItem);
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
            CanBuy = input.ReadBool();
            break;
          }
          case 18: {
            if (shopItem_ == null) {
              shopItem_ = new global::DragonU3DSDK.Network.API.ILProtocol.ShopItemConfig();
            }
            input.ReadMessage(shopItem_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

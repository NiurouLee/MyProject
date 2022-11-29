// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: fortune_x_coupon.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.ilruntime.Protobuf;
using pbc = global::Google.ilruntime.Protobuf.Collections;
using scg = global::System.Collections.Generic;
namespace DragonU3DSDK.Network.API.ILProtocol {

  #region Messages
  /// <summary>
  /// 兑换码领奖
  /// </summary>
  public sealed class CReceiveRewardsInCoupon : pb::IMessage {
    private static readonly pb::MessageParser<CReceiveRewardsInCoupon> _parser = new pb::MessageParser<CReceiveRewardsInCoupon>(() => new CReceiveRewardsInCoupon());
    public static pb::MessageParser<CReceiveRewardsInCoupon> Parser { get { return _parser; } }

    private string couponId_ = "";
    public string CouponId {
      get { return couponId_; }
      set {
        couponId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (CouponId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CouponId);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (CouponId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CouponId);
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
            CouponId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed class SReceiveRewardsInCoupon : pb::IMessage {
    private static readonly pb::MessageParser<SReceiveRewardsInCoupon> _parser = new pb::MessageParser<SReceiveRewardsInCoupon>(() => new SReceiveRewardsInCoupon());
    public static pb::MessageParser<SReceiveRewardsInCoupon> Parser { get { return _parser; } }

    private bool success_;
    public bool Success {
      get { return success_; }
      set {
        success_ = value;
      }
    }

    private string mailId_ = "";
    /// <summary>
    /// 邮件ID
    /// </summary>
    public string MailId {
      get { return mailId_; }
      set {
        mailId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Success != false) {
        output.WriteRawTag(8);
        output.WriteBool(Success);
      }
      if (MailId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(MailId);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Success != false) {
        size += 1 + 1;
      }
      if (MailId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MailId);
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
            Success = input.ReadBool();
            break;
          }
          case 18: {
            MailId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

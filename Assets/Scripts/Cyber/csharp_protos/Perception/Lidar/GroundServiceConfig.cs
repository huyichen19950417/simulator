// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: modules/perception/lidar/lib/scene_manager/ground_service/proto/ground_service_config.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Apollo.Perception.Lidar {

  /// <summary>Holder for reflection information generated from modules/perception/lidar/lib/scene_manager/ground_service/proto/ground_service_config.proto</summary>
  public static partial class GroundServiceConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for modules/perception/lidar/lib/scene_manager/ground_service/proto/ground_service_config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GroundServiceConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Clttb2R1bGVzL3BlcmNlcHRpb24vbGlkYXIvbGliL3NjZW5lX21hbmFnZXIv",
            "Z3JvdW5kX3NlcnZpY2UvcHJvdG8vZ3JvdW5kX3NlcnZpY2VfY29uZmlnLnBy",
            "b3RvEhdhcG9sbG8ucGVyY2VwdGlvbi5saWRhciJOChNHcm91bmRTZXJ2aWNl",
            "Q29uZmlnEhEKCXJvaV9yYWRfeBgBIAEoARIRCglyb2lfcmFkX3kYAiABKAES",
            "EQoJZ3JpZF9zaXplGAMgASgNYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Perception.Lidar.GroundServiceConfig), global::Apollo.Perception.Lidar.GroundServiceConfig.Parser, new[]{ "RoiRadX", "RoiRadY", "GridSize" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GroundServiceConfig : pb::IMessage<GroundServiceConfig> {
    private static readonly pb::MessageParser<GroundServiceConfig> _parser = new pb::MessageParser<GroundServiceConfig>(() => new GroundServiceConfig());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GroundServiceConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Perception.Lidar.GroundServiceConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GroundServiceConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GroundServiceConfig(GroundServiceConfig other) : this() {
      roiRadX_ = other.roiRadX_;
      roiRadY_ = other.roiRadY_;
      gridSize_ = other.gridSize_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GroundServiceConfig Clone() {
      return new GroundServiceConfig(this);
    }

    /// <summary>Field number for the "roi_rad_x" field.</summary>
    public const int RoiRadXFieldNumber = 1;
    private double roiRadX_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double RoiRadX {
      get { return roiRadX_; }
      set {
        roiRadX_ = value;
      }
    }

    /// <summary>Field number for the "roi_rad_y" field.</summary>
    public const int RoiRadYFieldNumber = 2;
    private double roiRadY_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double RoiRadY {
      get { return roiRadY_; }
      set {
        roiRadY_ = value;
      }
    }

    /// <summary>Field number for the "grid_size" field.</summary>
    public const int GridSizeFieldNumber = 3;
    private uint gridSize_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint GridSize {
      get { return gridSize_; }
      set {
        gridSize_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GroundServiceConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GroundServiceConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RoiRadX != other.RoiRadX) return false;
      if (RoiRadY != other.RoiRadY) return false;
      if (GridSize != other.GridSize) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RoiRadX != 0D) hash ^= RoiRadX.GetHashCode();
      if (RoiRadY != 0D) hash ^= RoiRadY.GetHashCode();
      if (GridSize != 0) hash ^= GridSize.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (RoiRadX != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(RoiRadX);
      }
      if (RoiRadY != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(RoiRadY);
      }
      if (GridSize != 0) {
        output.WriteRawTag(24);
        output.WriteUInt32(GridSize);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (RoiRadX != 0D) {
        size += 1 + 8;
      }
      if (RoiRadY != 0D) {
        size += 1 + 8;
      }
      if (GridSize != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(GridSize);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GroundServiceConfig other) {
      if (other == null) {
        return;
      }
      if (other.RoiRadX != 0D) {
        RoiRadX = other.RoiRadX;
      }
      if (other.RoiRadY != 0D) {
        RoiRadY = other.RoiRadY;
      }
      if (other.GridSize != 0) {
        GridSize = other.GridSize;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 9: {
            RoiRadX = input.ReadDouble();
            break;
          }
          case 17: {
            RoiRadY = input.ReadDouble();
            break;
          }
          case 24: {
            GridSize = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

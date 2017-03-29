// automatically generated by the FlatBuffers compiler, do not modify

namespace InWorldz.Arbiter.Serialization
{

using System;
using FlatBuffers;

public struct HalcyonPrimitive : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static HalcyonPrimitive GetRootAsHalcyonPrimitive(ByteBuffer _bb) { return GetRootAsHalcyonPrimitive(_bb, new HalcyonPrimitive()); }
  public static HalcyonPrimitive GetRootAsHalcyonPrimitive(ByteBuffer _bb, HalcyonPrimitive obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public HalcyonPrimitive __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public byte Id(int j) { int o = __p.__offset(4); return o != 0 ? __p.bb.Get(__p.__vector(o) + j * 1) : (byte)0; }
  public int IdLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ArraySegment<byte>? GetIdBytes() { return __p.__vector_as_arraysegment(4); }
  public string Name { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(6); }
  public string Description { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
  public ArraySegment<byte>? GetDescriptionBytes() { return __p.__vector_as_arraysegment(8); }
  public byte Sound(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.Get(__p.__vector(o) + j * 1) : (byte)0; }
  public int SoundLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ArraySegment<byte>? GetSoundBytes() { return __p.__vector_as_arraysegment(10); }
  public byte SoundFlags { get { int o = __p.__offset(12); return o != 0 ? __p.bb.Get(o + __p.bb_pos) : (byte)0; } }
  public float SoundGain { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float SoundRadius { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public byte CreatorId(int j) { int o = __p.__offset(18); return o != 0 ? __p.bb.Get(__p.__vector(o) + j * 1) : (byte)0; }
  public int CreatorIdLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ArraySegment<byte>? GetCreatorIdBytes() { return __p.__vector_as_arraysegment(18); }
  public uint ObjectFlags { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public uint LocalId { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public byte TextureAnimation(int j) { int o = __p.__offset(24); return o != 0 ? __p.bb.Get(__p.__vector(o) + j * 1) : (byte)0; }
  public int TextureAnimationLength { get { int o = __p.__offset(24); return o != 0 ? __p.__vector_len(o) : 0; } }
  public ArraySegment<byte>? GetTextureAnimationBytes() { return __p.__vector_as_arraysegment(24); }
  public InWorldz.Arbiter.Serialization.Vector3? GroupPosition { get { int o = __p.__offset(26); return o != 0 ? (InWorldz.Arbiter.Serialization.Vector3?)(new InWorldz.Arbiter.Serialization.Vector3()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public InWorldz.Arbiter.Serialization.Vector3? OffsetPosition { get { int o = __p.__offset(28); return o != 0 ? (InWorldz.Arbiter.Serialization.Vector3?)(new InWorldz.Arbiter.Serialization.Vector3()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public InWorldz.Arbiter.Serialization.Quaternion? RotationOffset { get { int o = __p.__offset(30); return o != 0 ? (InWorldz.Arbiter.Serialization.Quaternion?)(new InWorldz.Arbiter.Serialization.Quaternion()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public InWorldz.Arbiter.Serialization.Vector3? Velocity { get { int o = __p.__offset(32); return o != 0 ? (InWorldz.Arbiter.Serialization.Vector3?)(new InWorldz.Arbiter.Serialization.Vector3()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public InWorldz.Arbiter.Serialization.Vector3? AngularVelocityTarget { get { int o = __p.__offset(34); return o != 0 ? (InWorldz.Arbiter.Serialization.Vector3?)(new InWorldz.Arbiter.Serialization.Vector3()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public InWorldz.Arbiter.Serialization.Vector3? AngularVelocity { get { int o = __p.__offset(36); return o != 0 ? (InWorldz.Arbiter.Serialization.Vector3?)(new InWorldz.Arbiter.Serialization.Vector3()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public int LinkNumber { get { int o = __p.__offset(38); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public uint ParentId { get { int o = __p.__offset(40); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public InWorldz.Arbiter.Serialization.Vector3? Scale { get { int o = __p.__offset(42); return o != 0 ? (InWorldz.Arbiter.Serialization.Vector3?)(new InWorldz.Arbiter.Serialization.Vector3()).__assign(o + __p.bb_pos, __p.bb) : null; } }
  public InWorldz.Arbiter.Serialization.HalcyonPrimitiveBaseShape? Shape { get { int o = __p.__offset(44); return o != 0 ? (InWorldz.Arbiter.Serialization.HalcyonPrimitiveBaseShape?)(new InWorldz.Arbiter.Serialization.HalcyonPrimitiveBaseShape()).__assign(__p.__indirect(o + __p.bb_pos), __p.bb) : null; } }

  public static void StartHalcyonPrimitive(FlatBufferBuilder builder) { builder.StartObject(21); }
  public static void AddId(FlatBufferBuilder builder, VectorOffset idOffset) { builder.AddOffset(0, idOffset.Value, 0); }
  public static VectorOffset CreateIdVector(FlatBufferBuilder builder, byte[] data) { builder.StartVector(1, data.Length, 1); for (int i = data.Length - 1; i >= 0; i--) builder.AddByte(data[i]); return builder.EndVector(); }
  public static void StartIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(1, numElems, 1); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(1, nameOffset.Value, 0); }
  public static void AddDescription(FlatBufferBuilder builder, StringOffset descriptionOffset) { builder.AddOffset(2, descriptionOffset.Value, 0); }
  public static void AddSound(FlatBufferBuilder builder, VectorOffset soundOffset) { builder.AddOffset(3, soundOffset.Value, 0); }
  public static VectorOffset CreateSoundVector(FlatBufferBuilder builder, byte[] data) { builder.StartVector(1, data.Length, 1); for (int i = data.Length - 1; i >= 0; i--) builder.AddByte(data[i]); return builder.EndVector(); }
  public static void StartSoundVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(1, numElems, 1); }
  public static void AddSoundFlags(FlatBufferBuilder builder, byte soundFlags) { builder.AddByte(4, soundFlags, 0); }
  public static void AddSoundGain(FlatBufferBuilder builder, float soundGain) { builder.AddFloat(5, soundGain, 0.0f); }
  public static void AddSoundRadius(FlatBufferBuilder builder, float soundRadius) { builder.AddFloat(6, soundRadius, 0.0f); }
  public static void AddCreatorId(FlatBufferBuilder builder, VectorOffset creatorIdOffset) { builder.AddOffset(7, creatorIdOffset.Value, 0); }
  public static VectorOffset CreateCreatorIdVector(FlatBufferBuilder builder, byte[] data) { builder.StartVector(1, data.Length, 1); for (int i = data.Length - 1; i >= 0; i--) builder.AddByte(data[i]); return builder.EndVector(); }
  public static void StartCreatorIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(1, numElems, 1); }
  public static void AddObjectFlags(FlatBufferBuilder builder, uint objectFlags) { builder.AddUint(8, objectFlags, 0); }
  public static void AddLocalId(FlatBufferBuilder builder, uint localId) { builder.AddUint(9, localId, 0); }
  public static void AddTextureAnimation(FlatBufferBuilder builder, VectorOffset textureAnimationOffset) { builder.AddOffset(10, textureAnimationOffset.Value, 0); }
  public static VectorOffset CreateTextureAnimationVector(FlatBufferBuilder builder, byte[] data) { builder.StartVector(1, data.Length, 1); for (int i = data.Length - 1; i >= 0; i--) builder.AddByte(data[i]); return builder.EndVector(); }
  public static void StartTextureAnimationVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(1, numElems, 1); }
  public static void AddGroupPosition(FlatBufferBuilder builder, Offset<InWorldz.Arbiter.Serialization.Vector3> groupPositionOffset) { builder.AddStruct(11, groupPositionOffset.Value, 0); }
  public static void AddOffsetPosition(FlatBufferBuilder builder, Offset<InWorldz.Arbiter.Serialization.Vector3> offsetPositionOffset) { builder.AddStruct(12, offsetPositionOffset.Value, 0); }
  public static void AddRotationOffset(FlatBufferBuilder builder, Offset<InWorldz.Arbiter.Serialization.Quaternion> rotationOffsetOffset) { builder.AddStruct(13, rotationOffsetOffset.Value, 0); }
  public static void AddVelocity(FlatBufferBuilder builder, Offset<InWorldz.Arbiter.Serialization.Vector3> velocityOffset) { builder.AddStruct(14, velocityOffset.Value, 0); }
  public static void AddAngularVelocityTarget(FlatBufferBuilder builder, Offset<InWorldz.Arbiter.Serialization.Vector3> angularVelocityTargetOffset) { builder.AddStruct(15, angularVelocityTargetOffset.Value, 0); }
  public static void AddAngularVelocity(FlatBufferBuilder builder, Offset<InWorldz.Arbiter.Serialization.Vector3> angularVelocityOffset) { builder.AddStruct(16, angularVelocityOffset.Value, 0); }
  public static void AddLinkNumber(FlatBufferBuilder builder, int linkNumber) { builder.AddInt(17, linkNumber, 0); }
  public static void AddParentId(FlatBufferBuilder builder, uint parentId) { builder.AddUint(18, parentId, 0); }
  public static void AddScale(FlatBufferBuilder builder, Offset<InWorldz.Arbiter.Serialization.Vector3> scaleOffset) { builder.AddStruct(19, scaleOffset.Value, 0); }
  public static void AddShape(FlatBufferBuilder builder, Offset<InWorldz.Arbiter.Serialization.HalcyonPrimitiveBaseShape> shapeOffset) { builder.AddOffset(20, shapeOffset.Value, 0); }
  public static Offset<HalcyonPrimitive> EndHalcyonPrimitive(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<HalcyonPrimitive>(o);
  }
  public static void FinishHalcyonPrimitiveBuffer(FlatBufferBuilder builder, Offset<HalcyonPrimitive> offset) { builder.Finish(offset.Value); }
};


}
// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace MyGame
{

using global::System;
using global::FlatBuffers;

public struct InParentNamespace : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static InParentNamespace GetRootAsInParentNamespace(ByteBuffer _bb) { return GetRootAsInParentNamespace(_bb, new InParentNamespace()); }
  public static InParentNamespace GetRootAsInParentNamespace(ByteBuffer _bb, InParentNamespace obj) { FlatBufferConstants.FLATBUFFERS_1_11_1(); return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public InParentNamespace __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }


  public static void StartInParentNamespace(FlatBufferBuilder builder) { builder.StartTable(0); }
  public static Offset<InParentNamespace> EndInParentNamespace(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<InParentNamespace>(o);
  }
};


}

// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace MyGame.Example
{

using global::System;
using global::FlatBuffers;

internal partial struct TestSimpleTableWithEnum : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static TestSimpleTableWithEnum GetRootAsTestSimpleTableWithEnum(ByteBuffer _bb) { return GetRootAsTestSimpleTableWithEnum(_bb, new TestSimpleTableWithEnum()); }
  public static TestSimpleTableWithEnum GetRootAsTestSimpleTableWithEnum(ByteBuffer _bb, TestSimpleTableWithEnum obj) { FlatBufferConstants.FLATBUFFERS_1_11_1(); return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public TestSimpleTableWithEnum __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public Color Color { get { int o = __p.__offset(4); return o != 0 ? (Color)__p.bb.Get(o + __p.bb_pos) : Color.Green; } }
  public bool MutateColor(Color color) { int o = __p.__offset(4); if (o != 0) { __p.bb.Put(o + __p.bb_pos, (byte)color); return true; } else { return false; } }

  public static Offset<TestSimpleTableWithEnum> CreateTestSimpleTableWithEnum(FlatBufferBuilder builder,
      Color color = Color.Green) {
    builder.StartTable(1);
    TestSimpleTableWithEnum.AddColor(builder, color);
    return TestSimpleTableWithEnum.EndTestSimpleTableWithEnum(builder);
  }

  public static void StartTestSimpleTableWithEnum(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddColor(FlatBufferBuilder builder, Color color) { builder.AddByte(0, (byte)color, 2); }
  public static Offset<TestSimpleTableWithEnum> EndTestSimpleTableWithEnum(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<TestSimpleTableWithEnum>(o);
  }
};


}

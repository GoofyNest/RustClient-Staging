public struct Span<T> // TypeDefIndex: 120
{	// Fields
	private readonly Pinnable<T> _pinnable; // 0x0
	private readonly IntPtr _byteOffset; // 0x0
	private readonly int _length; // 0x0

	// Properties
	public int Length { get; }
	public T Item { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3C20 Offset: 0x1E3020 VA: 0x1801E3C20
	|-Span<byte>..ctor
	|
	|-RVA: 0x1E3AB0 Offset: 0x1E2EB0 VA: 0x1801E3AB0
	|-Span<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF3EB0 Offset: 0xF32B0 VA: 0x1800F3EB0
	|-Span<byte>.get_Length
	|-Span<object>.get_Length
	*/

	// RVA: -1 Offset: -1
	public ref T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3C40 Offset: 0x1E3040 VA: 0x1801E3C40
	|-Span<byte>.get_Item
	|-Span<object>.get_Item
	*/

	[ObsoleteAttribute] // RVA: 0xE9630 Offset: 0xE8A30 VA: 0x1800E9630
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3650 Offset: 0x1E2A50 VA: 0x1801E3650
	|-Span<byte>.Equals
	|
	|-RVA: 0x1E3620 Offset: 0x1E2A20 VA: 0x1801E3620
	|-Span<object>.Equals
	*/

	[ObsoleteAttribute] // RVA: 0xE96C0 Offset: 0xE8AC0 VA: 0x1800E96C0
	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E36B0 Offset: 0x1E2AB0 VA: 0x1801E36B0
	|-Span<byte>.GetHashCode
	|
	|-RVA: 0x1E3680 Offset: 0x1E2A80 VA: 0x1801E3680
	|-Span<object>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public static Span<T> op_Implicit(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13687D0 Offset: 0x1366DD0 VA: 0x1813687D0
	|-Span<byte>.op_Implicit
	|
	|-RVA: 0x1368AA0 Offset: 0x13670A0 VA: 0x181368AA0
	|-Span<object>.op_Implicit
	*/

}

internal static class SpanHelpers // TypeDefIndex: 122
{
// Namespace: System
[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
internal static class SpanHelpers // TypeDefIndex: 122
	// Methods

	// RVA: -1 Offset: -1
	public static bool IsReferenceOrContainsReferences<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF45B0 Offset: 0xBF2BB0 VA: 0x180BF45B0
	|-SpanHelpers.IsReferenceOrContainsReferences<byte>
	|-SpanHelpers.IsReferenceOrContainsReferences<char>
	|-SpanHelpers.IsReferenceOrContainsReferences<object>
	*/

	// RVA: 0x18AFDD0 Offset: 0x18AE3D0 VA: 0x1818AFDD0
	private static bool IsReferenceOrContainsReferencesCore(Type type) { }

}

public static class SpanHelpers.PerTypeValues<T> // TypeDefIndex: 123
{	// Fields
	public static readonly bool IsReferenceOrContainsReferences; // 0x0
	public static readonly T[] EmptyArray; // 0x0
	public static readonly IntPtr ArrayAdjustment; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static IntPtr MeasureArrayAdjustment() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1365D60 Offset: 0x1364360 VA: 0x181365D60
	|-SpanHelpers.PerTypeValues<byte>.MeasureArrayAdjustment
	|-SpanHelpers.PerTypeValues<char>.MeasureArrayAdjustment
	|-SpanHelpers.PerTypeValues<object>.MeasureArrayAdjustment
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1366070 Offset: 0x1364670 VA: 0x181366070
	|-SpanHelpers.PerTypeValues<byte>..cctor
	|
	|-RVA: 0x1365E90 Offset: 0x1364490 VA: 0x181365E90
	|-SpanHelpers.PerTypeValues<char>..cctor
	|
	|-RVA: 0x13667F0 Offset: 0x1364DF0 VA: 0x1813667F0
	|-SpanHelpers.PerTypeValues<object>..cctor
	*/

}

public class SpanningTree<T> // TypeDefIndex: 4813
{	// Fields
	private List<SpanningTree.Node<T>> nodes; // 0x0
	private List<SpanningTree.Edge<T>> edges; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public int AddNode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD62FF0 Offset: 0xD615F0 VA: 0x180D62FF0
	|-SpanningTree<object>.AddNode
	*/

	// RVA: -1 Offset: -1
	public void AddEdge(int a_idx, int b_idx, int cost, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD62ED0 Offset: 0xD614D0 VA: 0x180D62ED0
	|-SpanningTree<object>.AddEdge
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD63770 Offset: 0xD61D70 VA: 0x180D63770
	|-SpanningTree<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD639E0 Offset: 0xD61FE0 VA: 0x180D639E0
	|-SpanningTree<object>.Reset
	*/

	// RVA: -1 Offset: -1
	public void CalculateMin() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD630B0 Offset: 0xD616B0 VA: 0x180D630B0
	|-SpanningTree<object>.CalculateMin
	*/

	// RVA: -1 Offset: -1
	public void ForEach(Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD637D0 Offset: 0xD61DD0 VA: 0x180D637D0
	|-SpanningTree<object>.ForEach
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD63C00 Offset: 0xD62200 VA: 0x180D63C00
	|-SpanningTree<object>..ctor
	*/

}

private class SpanningTree.Node<T> // TypeDefIndex: 4814
{	// Fields
	public List<SpanningTree.Edge<T>> edges; // 0x0
	public bool connected; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD599C0 Offset: 0xD57FC0 VA: 0x180D599C0
	|-SpanningTree.Node<object>..ctor
	*/

}

private class SpanningTree.Edge<T> : IMinHeapNode<SpanningTree.Edge<T>> // TypeDefIndex: 4815
{	// Fields
	public SpanningTree.Node<T> source; // 0x0
	public SpanningTree.Node<T> target; // 0x0
	public T value; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <order>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SpanningTree.Edge<T> <child>k__BackingField; // 0x0

	// Properties
	public int order { get; set; }
	public SpanningTree.Edge<T> child { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 6
	public int get_order() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	|-SpanningTree.Edge<object>.get_order
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	private void set_order(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7D0D60 Offset: 0x7CF360 VA: 0x1807D0D60
	|-SpanningTree.Edge<object>.set_order
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 4
	public SpanningTree.Edge<T> get_child() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	|-SpanningTree.Edge<object>.get_child
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1 Slot: 5
	public void set_child(SpanningTree.Edge<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A6080 Offset: 0x4A4680 VA: 0x1804A6080
	|-SpanningTree.Edge<object>.set_child
	*/

	// RVA: -1 Offset: -1
	public void .ctor(SpanningTree.Node<T> source, SpanningTree.Node<T> target, int order, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD53220 Offset: 0xD51820 VA: 0x180D53220
	|-SpanningTree.Edge<object>..ctor
	*/

}

public struct Span<T> // TypeDefIndex: 6729
{	// Fields
	private readonly Pinnable<T> _pinnable; // 0x0
	private readonly IntPtr _byteOffset; // 0x0
	private readonly int _length; // 0x0

	// Properties
	public int Length { get; }
	public T Item { get; }
	internal Pinnable<T> Pinnable { get; }
	internal IntPtr ByteOffset { get; }

	// Methods

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF3EB0 Offset: 0xF32B0 VA: 0x1800F3EB0
	|-Span<byte>.get_Length
	|-Span<short>.get_Length
	|-Span<object>.get_Length
	*/

	[ObsoleteAttribute] // RVA: 0xC9A50 Offset: 0xC8E50 VA: 0x1800C9A50
	[EditorBrowsableAttribute] // RVA: 0xC9A50 Offset: 0xC8E50 VA: 0x1800C9A50
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3640 Offset: 0x1E2A40 VA: 0x1801E3640
	|-Span<byte>.Equals
	|
	|-RVA: 0x1E3630 Offset: 0x1E2A30 VA: 0x1801E3630
	|-Span<short>.Equals
	|
	|-RVA: 0x1E3660 Offset: 0x1E2A60 VA: 0x1801E3660
	|-Span<object>.Equals
	*/

	[ObsoleteAttribute] // RVA: 0xC9B90 Offset: 0xC8F90 VA: 0x1800C9B90
	[EditorBrowsableAttribute] // RVA: 0xC9B90 Offset: 0xC8F90 VA: 0x1800C9B90
	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3670 Offset: 0x1E2A70 VA: 0x1801E3670
	|-Span<byte>.GetHashCode
	|
	|-RVA: 0x1E3690 Offset: 0x1E2A90 VA: 0x1801E3690
	|-Span<short>.GetHashCode
	|
	|-RVA: 0x1E36A0 Offset: 0x1E2AA0 VA: 0x1801E36A0
	|-Span<object>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public static Span<T> op_Implicit(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1368770 Offset: 0x1366D70 VA: 0x181368770
	|-Span<byte>.op_Implicit
	|
	|-RVA: 0x1368830 Offset: 0x1366E30 VA: 0x181368830
	|-Span<short>.op_Implicit
	|
	|-RVA: 0x1368B00 Offset: 0x1367100 VA: 0x181368B00
	|-Span<object>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static Span<T> op_Implicit(ArraySegment<T> segment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13689F0 Offset: 0x1366FF0 VA: 0x1813689F0
	|-Span<byte>.op_Implicit
	|
	|-RVA: 0x1368890 Offset: 0x1366E90 VA: 0x181368890
	|-Span<short>.op_Implicit
	|
	|-RVA: 0x1368940 Offset: 0x1366F40 VA: 0x181368940
	|-Span<object>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3980 Offset: 0x1E2D80 VA: 0x1801E3980
	|-Span<byte>..ctor
	|
	|-RVA: 0x1E3AD0 Offset: 0x1E2ED0 VA: 0x1801E3AD0
	|-Span<short>..ctor
	|
	|-RVA: 0x1E3820 Offset: 0x1E2C20 VA: 0x1801E3820
	|-Span<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3AC0 Offset: 0x1E2EC0 VA: 0x1801E3AC0
	|-Span<byte>..ctor
	|
	|-RVA: 0x1E3C10 Offset: 0x1E3010 VA: 0x1801E3C10
	|-Span<short>..ctor
	|
	|-RVA: 0x1E3C00 Offset: 0x1E3000 VA: 0x1801E3C00
	|-Span<object>..ctor
	*/

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	// RVA: -1 Offset: -1
	public void .ctor(void* pointer, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3990 Offset: 0x1E2D90 VA: 0x1801E3990
	|-Span<byte>..ctor
	|
	|-RVA: 0x1E3AE0 Offset: 0x1E2EE0 VA: 0x1801E3AE0
	|-Span<short>..ctor
	|
	|-RVA: 0x1E3860 Offset: 0x1E2C60 VA: 0x1801E3860
	|-Span<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(Pinnable<T> pinnable, IntPtr byteOffset, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3830 Offset: 0x1E2C30 VA: 0x1801E3830
	|-Span<byte>..ctor
	|-Span<short>..ctor
	|-Span<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public ref T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3C30 Offset: 0x1E3030 VA: 0x1801E3C30
	|-Span<byte>.get_Item
	|-Span<short>.get_Item
	|-Span<object>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(Span<T> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E35A0 Offset: 0x1E29A0 VA: 0x1801E35A0
	|-Span<byte>.CopyTo
	|-Span<short>.CopyTo
	|-Span<object>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public bool TryCopyTo(Span<T> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E37F0 Offset: 0x1E2BF0 VA: 0x1801E37F0
	|-Span<byte>.TryCopyTo
	|-Span<short>.TryCopyTo
	|-Span<object>.TryCopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E37C0 Offset: 0x1E2BC0 VA: 0x1801E37C0
	|-Span<byte>.ToString
	|
	|-RVA: 0x1E37D0 Offset: 0x1E2BD0 VA: 0x1801E37D0
	|-Span<short>.ToString
	|
	|-RVA: 0x1E37E0 Offset: 0x1E2BE0 VA: 0x1801E37E0
	|-Span<object>.ToString
	*/

	// RVA: -1 Offset: -1
	public Span<T> Slice(int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E36C0 Offset: 0x1E2AC0 VA: 0x1801E36C0
	|-Span<byte>.Slice
	|-Span<short>.Slice
	|-Span<object>.Slice
	*/

	[EditorBrowsableAttribute] // RVA: 0x7D7C0 Offset: 0x7CBC0 VA: 0x18007D7C0
	// RVA: -1 Offset: -1
	internal ref T DangerousGetPinnableReference() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3610 Offset: 0x1E2A10 VA: 0x1801E3610
	|-Span<byte>.DangerousGetPinnableReference
	|-Span<short>.DangerousGetPinnableReference
	|-Span<object>.DangerousGetPinnableReference
	*/

	// RVA: -1 Offset: -1
	internal Pinnable<T> get_Pinnable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	|-Span<byte>.get_Pinnable
	|-Span<short>.get_Pinnable
	|-Span<object>.get_Pinnable
	*/

	// RVA: -1 Offset: -1
	internal IntPtr get_ByteOffset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF3EC0 Offset: 0xF32C0 VA: 0x1800F3EC0
	|-Span<byte>.get_ByteOffset
	|-Span<short>.get_ByteOffset
	|-Span<object>.get_ByteOffset
	*/

}

internal static class SpanHelpers // TypeDefIndex: 6731
{
// Namespace: System
[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
internal static class SpanHelpers // TypeDefIndex: 6731
	// Methods

	// RVA: -1 Offset: -1
	public static void CopyTo<T>(ref T dst, int dstLength, ref T src, int srcLength) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF08C30 Offset: 0xF07230 VA: 0x180F08C30
	|-SpanHelpers.CopyTo<byte>
	|
	|-RVA: 0xF09180 Offset: 0xF07780 VA: 0x180F09180
	|-SpanHelpers.CopyTo<short>
	|
	|-RVA: 0xF096E0 Offset: 0xF07CE0 VA: 0x180F096E0
	|-SpanHelpers.CopyTo<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: -1 Offset: -1
	public static IntPtr Add<T>(IntPtr start, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED8670 Offset: 0xED6C70 VA: 0x180ED8670
	|-SpanHelpers.Add<byte>
	|-SpanHelpers.Add<short>
	|-SpanHelpers.Add<object>
	*/

	// RVA: -1 Offset: -1
	public static bool IsReferenceOrContainsReferences<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF45B0 Offset: 0xBF2BB0 VA: 0x180BF45B0
	|-SpanHelpers.IsReferenceOrContainsReferences<byte>
	|-SpanHelpers.IsReferenceOrContainsReferences<short>
	|-SpanHelpers.IsReferenceOrContainsReferences<object>
	*/

	// RVA: 0x231B1E0 Offset: 0x23197E0 VA: 0x18231B1E0
	private static bool IsReferenceOrContainsReferencesCore(Type type) { }

}

public static class SpanHelpers.PerTypeValues<T> // TypeDefIndex: 6732
{	// Fields
	public static readonly bool IsReferenceOrContainsReferences; // 0x0
	public static readonly T[] EmptyArray; // 0x0
	public static readonly IntPtr ArrayAdjustment; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static IntPtr MeasureArrayAdjustment() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1365D60 Offset: 0x1364360 VA: 0x181365D60
	|-SpanHelpers.PerTypeValues<byte>.MeasureArrayAdjustment
	|-SpanHelpers.PerTypeValues<short>.MeasureArrayAdjustment
	|-SpanHelpers.PerTypeValues<object>.MeasureArrayAdjustment
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1366430 Offset: 0x1364A30 VA: 0x181366430
	|-SpanHelpers.PerTypeValues<byte>..cctor
	|
	|-RVA: 0x1366250 Offset: 0x1364850 VA: 0x181366250
	|-SpanHelpers.PerTypeValues<short>..cctor
	|
	|-RVA: 0x1366610 Offset: 0x1364C10 VA: 0x181366610
	|-SpanHelpers.PerTypeValues<object>..cctor
	*/

}

internal struct SpanWriter // TypeDefIndex: 6924
{	// Fields
	private readonly Span<byte> _data; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <Length>k__BackingField; // 0x18

	// Properties
	public int Length { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1EF0A0 Offset: 0x1EE4A0 VA: 0x1801EF0A0
	public int get_Length() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xFC8F0 Offset: 0xFBCF0 VA: 0x1800FC8F0
	private void set_Length(int value) { }

	// RVA: 0x2373A0 Offset: 0x2367A0 VA: 0x1802373A0
	public void .ctor(Span<byte> data) { }

	// RVA: -1 Offset: -1
	public void Write<T>(T value, bool reverse = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F38D0 Offset: 0x1F2CD0 VA: 0x1801F38D0
	|-SpanWriter.Write<byte>
	|
	|-RVA: 0x1F3A40 Offset: 0x1F2E40 VA: 0x1801F3A40
	|-SpanWriter.Write<ushort>
	|
	|-RVA: 0x1F3BB0 Offset: 0x1F2FB0 VA: 0x1801F3BB0
	|-SpanWriter.Write<ulong>
	*/

	// RVA: -1 Offset: -1
	public void Write<T>(Span<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F37A0 Offset: 0x1F2BA0 VA: 0x1801F37A0
	|-SpanWriter.Write<byte>
	*/

}


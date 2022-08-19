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
	|-RVA: 0x1E3CA0 Offset: 0x1E30A0 VA: 0x1801E3CA0
	|-Span<byte>..ctor
	|
	|-RVA: 0x1E3B30 Offset: 0x1E2F30 VA: 0x1801E3B30
	|-Span<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF3F30 Offset: 0xF3330 VA: 0x1800F3F30
	|-Span<byte>.get_Length
	|-Span<object>.get_Length
	*/

	// RVA: -1 Offset: -1
	public ref T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3CC0 Offset: 0x1E30C0 VA: 0x1801E3CC0
	|-Span<byte>.get_Item
	|-Span<object>.get_Item
	*/

	[ObsoleteAttribute] // RVA: 0xE9650 Offset: 0xE8A50 VA: 0x1800E9650
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E36D0 Offset: 0x1E2AD0 VA: 0x1801E36D0
	|-Span<byte>.Equals
	|
	|-RVA: 0x1E36A0 Offset: 0x1E2AA0 VA: 0x1801E36A0
	|-Span<object>.Equals
	*/

	[ObsoleteAttribute] // RVA: 0xE9830 Offset: 0xE8C30 VA: 0x1800E9830
	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3730 Offset: 0x1E2B30 VA: 0x1801E3730
	|-Span<byte>.GetHashCode
	|
	|-RVA: 0x1E3700 Offset: 0x1E2B00 VA: 0x1801E3700
	|-Span<object>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public static Span<T> op_Implicit(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1368510 Offset: 0x1366B10 VA: 0x181368510
	|-Span<byte>.op_Implicit
	|
	|-RVA: 0x13687E0 Offset: 0x1366DE0 VA: 0x1813687E0
	|-Span<object>.op_Implicit
	*/

}

internal static class SpanHelpers // TypeDefIndex: 122
{
// Namespace: System
[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
internal static class SpanHelpers // TypeDefIndex: 122
	// Methods

	// RVA: -1 Offset: -1
	public static bool IsReferenceOrContainsReferences<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF42F0 Offset: 0xBF28F0 VA: 0x180BF42F0
	|-SpanHelpers.IsReferenceOrContainsReferences<byte>
	|-SpanHelpers.IsReferenceOrContainsReferences<char>
	|-SpanHelpers.IsReferenceOrContainsReferences<object>
	*/

	// RVA: 0x18AFB50 Offset: 0x18AE150 VA: 0x1818AFB50
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
	|-RVA: 0x1365AA0 Offset: 0x13640A0 VA: 0x181365AA0
	|-SpanHelpers.PerTypeValues<byte>.MeasureArrayAdjustment
	|-SpanHelpers.PerTypeValues<char>.MeasureArrayAdjustment
	|-SpanHelpers.PerTypeValues<object>.MeasureArrayAdjustment
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1365DB0 Offset: 0x13643B0 VA: 0x181365DB0
	|-SpanHelpers.PerTypeValues<byte>..cctor
	|
	|-RVA: 0x1365BD0 Offset: 0x13641D0 VA: 0x181365BD0
	|-SpanHelpers.PerTypeValues<char>..cctor
	|
	|-RVA: 0x1366530 Offset: 0x1364B30 VA: 0x181366530
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
	|-RVA: 0xD62D30 Offset: 0xD61330 VA: 0x180D62D30
	|-SpanningTree<object>.AddNode
	*/

	// RVA: -1 Offset: -1
	public void AddEdge(int a_idx, int b_idx, int cost, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD62C10 Offset: 0xD61210 VA: 0x180D62C10
	|-SpanningTree<object>.AddEdge
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD634B0 Offset: 0xD61AB0 VA: 0x180D634B0
	|-SpanningTree<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD63720 Offset: 0xD61D20 VA: 0x180D63720
	|-SpanningTree<object>.Reset
	*/

	// RVA: -1 Offset: -1
	public void CalculateMin() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD62DF0 Offset: 0xD613F0 VA: 0x180D62DF0
	|-SpanningTree<object>.CalculateMin
	*/

	// RVA: -1 Offset: -1
	public void ForEach(Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD63510 Offset: 0xD61B10 VA: 0x180D63510
	|-SpanningTree<object>.ForEach
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD63940 Offset: 0xD61F40 VA: 0x180D63940
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
	|-RVA: 0xD59700 Offset: 0xD57D00 VA: 0x180D59700
	|-SpanningTree.Node<object>..ctor
	*/

}

private class SpanningTree.Edge<T> : IMinHeapNode<SpanningTree.Edge<T>> // TypeDefIndex: 4815
{	// Fields
	public SpanningTree.Node<T> source; // 0x0
	public SpanningTree.Node<T> target; // 0x0
	public T value; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int <order>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private SpanningTree.Edge<T> <child>k__BackingField; // 0x0

	// Properties
	public int order { get; set; }
	public SpanningTree.Edge<T> child { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1 Slot: 6
	public int get_order() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600
	|-SpanningTree.Edge<object>.get_order
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	private void set_order(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x7D0C50 Offset: 0x7CF250 VA: 0x1807D0C50
	|-SpanningTree.Edge<object>.set_order
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1 Slot: 4
	public SpanningTree.Edge<T> get_child() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	|-SpanningTree.Edge<object>.get_child
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
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
	|-RVA: 0xD52F60 Offset: 0xD51560 VA: 0x180D52F60
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
	|-RVA: 0xF3F30 Offset: 0xF3330 VA: 0x1800F3F30
	|-Span<byte>.get_Length
	|-Span<short>.get_Length
	|-Span<object>.get_Length
	*/

	[ObsoleteAttribute] // RVA: 0xC99C0 Offset: 0xC8DC0 VA: 0x1800C99C0
	[EditorBrowsableAttribute] // RVA: 0xC99C0 Offset: 0xC8DC0 VA: 0x1800C99C0
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E36C0 Offset: 0x1E2AC0 VA: 0x1801E36C0
	|-Span<byte>.Equals
	|
	|-RVA: 0x1E36B0 Offset: 0x1E2AB0 VA: 0x1801E36B0
	|-Span<short>.Equals
	|
	|-RVA: 0x1E36E0 Offset: 0x1E2AE0 VA: 0x1801E36E0
	|-Span<object>.Equals
	*/

	[ObsoleteAttribute] // RVA: 0xC9B50 Offset: 0xC8F50 VA: 0x1800C9B50
	[EditorBrowsableAttribute] // RVA: 0xC9B50 Offset: 0xC8F50 VA: 0x1800C9B50
	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E36F0 Offset: 0x1E2AF0 VA: 0x1801E36F0
	|-Span<byte>.GetHashCode
	|
	|-RVA: 0x1E3710 Offset: 0x1E2B10 VA: 0x1801E3710
	|-Span<short>.GetHashCode
	|
	|-RVA: 0x1E3720 Offset: 0x1E2B20 VA: 0x1801E3720
	|-Span<object>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public static Span<T> op_Implicit(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13684B0 Offset: 0x1366AB0 VA: 0x1813684B0
	|-Span<byte>.op_Implicit
	|
	|-RVA: 0x1368570 Offset: 0x1366B70 VA: 0x181368570
	|-Span<short>.op_Implicit
	|
	|-RVA: 0x1368840 Offset: 0x1366E40 VA: 0x181368840
	|-Span<object>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public static Span<T> op_Implicit(ArraySegment<T> segment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1368730 Offset: 0x1366D30 VA: 0x181368730
	|-Span<byte>.op_Implicit
	|
	|-RVA: 0x13685D0 Offset: 0x1366BD0 VA: 0x1813685D0
	|-Span<short>.op_Implicit
	|
	|-RVA: 0x1368680 Offset: 0x1366C80 VA: 0x181368680
	|-Span<object>.op_Implicit
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3A00 Offset: 0x1E2E00 VA: 0x1801E3A00
	|-Span<byte>..ctor
	|
	|-RVA: 0x1E3B50 Offset: 0x1E2F50 VA: 0x1801E3B50
	|-Span<short>..ctor
	|
	|-RVA: 0x1E38A0 Offset: 0x1E2CA0 VA: 0x1801E38A0
	|-Span<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3B40 Offset: 0x1E2F40 VA: 0x1801E3B40
	|-Span<byte>..ctor
	|
	|-RVA: 0x1E3C90 Offset: 0x1E3090 VA: 0x1801E3C90
	|-Span<short>..ctor
	|
	|-RVA: 0x1E3C80 Offset: 0x1E3080 VA: 0x1801E3C80
	|-Span<object>..ctor
	*/

	[CLSCompliantAttribute] // RVA: 0x6F3E0 Offset: 0x6E7E0 VA: 0x18006F3E0
	// RVA: -1 Offset: -1
	public void .ctor(void* pointer, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3A10 Offset: 0x1E2E10 VA: 0x1801E3A10
	|-Span<byte>..ctor
	|
	|-RVA: 0x1E3B60 Offset: 0x1E2F60 VA: 0x1801E3B60
	|-Span<short>..ctor
	|
	|-RVA: 0x1E38E0 Offset: 0x1E2CE0 VA: 0x1801E38E0
	|-Span<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(Pinnable<T> pinnable, IntPtr byteOffset, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E38B0 Offset: 0x1E2CB0 VA: 0x1801E38B0
	|-Span<byte>..ctor
	|-Span<short>..ctor
	|-Span<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public ref T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3CB0 Offset: 0x1E30B0 VA: 0x1801E3CB0
	|-Span<byte>.get_Item
	|-Span<short>.get_Item
	|-Span<object>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(Span<T> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3620 Offset: 0x1E2A20 VA: 0x1801E3620
	|-Span<byte>.CopyTo
	|-Span<short>.CopyTo
	|-Span<object>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public bool TryCopyTo(Span<T> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3870 Offset: 0x1E2C70 VA: 0x1801E3870
	|-Span<byte>.TryCopyTo
	|-Span<short>.TryCopyTo
	|-Span<object>.TryCopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3840 Offset: 0x1E2C40 VA: 0x1801E3840
	|-Span<byte>.ToString
	|
	|-RVA: 0x1E3850 Offset: 0x1E2C50 VA: 0x1801E3850
	|-Span<short>.ToString
	|
	|-RVA: 0x1E3860 Offset: 0x1E2C60 VA: 0x1801E3860
	|-Span<object>.ToString
	*/

	// RVA: -1 Offset: -1
	public Span<T> Slice(int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3740 Offset: 0x1E2B40 VA: 0x1801E3740
	|-Span<byte>.Slice
	|-Span<short>.Slice
	|-Span<object>.Slice
	*/

	[EditorBrowsableAttribute] // RVA: 0x7D6F0 Offset: 0x7CAF0 VA: 0x18007D6F0
	// RVA: -1 Offset: -1
	internal ref T DangerousGetPinnableReference() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3690 Offset: 0x1E2A90 VA: 0x1801E3690
	|-Span<byte>.DangerousGetPinnableReference
	|-Span<short>.DangerousGetPinnableReference
	|-Span<object>.DangerousGetPinnableReference
	*/

	// RVA: -1 Offset: -1
	internal Pinnable<T> get_Pinnable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC8C0 Offset: 0xFBCC0 VA: 0x1800FC8C0
	|-Span<byte>.get_Pinnable
	|-Span<short>.get_Pinnable
	|-Span<object>.get_Pinnable
	*/

	// RVA: -1 Offset: -1
	internal IntPtr get_ByteOffset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF3F40 Offset: 0xF3340 VA: 0x1800F3F40
	|-Span<byte>.get_ByteOffset
	|-Span<short>.get_ByteOffset
	|-Span<object>.get_ByteOffset
	*/

}

internal static class SpanHelpers // TypeDefIndex: 6731
{
// Namespace: System
[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
internal static class SpanHelpers // TypeDefIndex: 6731
	// Methods

	// RVA: -1 Offset: -1
	public static void CopyTo<T>(ref T dst, int dstLength, ref T src, int srcLength) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF08970 Offset: 0xF06F70 VA: 0x180F08970
	|-SpanHelpers.CopyTo<byte>
	|
	|-RVA: 0xF08EC0 Offset: 0xF074C0 VA: 0x180F08EC0
	|-SpanHelpers.CopyTo<short>
	|
	|-RVA: 0xF09420 Offset: 0xF07A20 VA: 0x180F09420
	|-SpanHelpers.CopyTo<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: -1 Offset: -1
	public static IntPtr Add<T>(IntPtr start, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED83B0 Offset: 0xED69B0 VA: 0x180ED83B0
	|-SpanHelpers.Add<byte>
	|-SpanHelpers.Add<short>
	|-SpanHelpers.Add<object>
	*/

	// RVA: -1 Offset: -1
	public static bool IsReferenceOrContainsReferences<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF42F0 Offset: 0xBF28F0 VA: 0x180BF42F0
	|-SpanHelpers.IsReferenceOrContainsReferences<byte>
	|-SpanHelpers.IsReferenceOrContainsReferences<short>
	|-SpanHelpers.IsReferenceOrContainsReferences<object>
	*/

	// RVA: 0x231B0E0 Offset: 0x23196E0 VA: 0x18231B0E0
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
	|-RVA: 0x1365AA0 Offset: 0x13640A0 VA: 0x181365AA0
	|-SpanHelpers.PerTypeValues<byte>.MeasureArrayAdjustment
	|-SpanHelpers.PerTypeValues<short>.MeasureArrayAdjustment
	|-SpanHelpers.PerTypeValues<object>.MeasureArrayAdjustment
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1366170 Offset: 0x1364770 VA: 0x181366170
	|-SpanHelpers.PerTypeValues<byte>..cctor
	|
	|-RVA: 0x1365F90 Offset: 0x1364590 VA: 0x181365F90
	|-SpanHelpers.PerTypeValues<short>..cctor
	|
	|-RVA: 0x1366350 Offset: 0x1364950 VA: 0x181366350
	|-SpanHelpers.PerTypeValues<object>..cctor
	*/

}

internal struct SpanWriter // TypeDefIndex: 6924
{	// Fields
	private readonly Span<byte> _data; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private int <Length>k__BackingField; // 0x18

	// Properties
	public int Length { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x1EF120 Offset: 0x1EE520 VA: 0x1801EF120
	public int get_Length() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xFC970 Offset: 0xFBD70 VA: 0x1800FC970
	private void set_Length(int value) { }

	// RVA: 0x237420 Offset: 0x236820 VA: 0x180237420
	public void .ctor(Span<byte> data) { }

	// RVA: -1 Offset: -1
	public void Write<T>(T value, bool reverse = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F3950 Offset: 0x1F2D50 VA: 0x1801F3950
	|-SpanWriter.Write<byte>
	|
	|-RVA: 0x1F3AC0 Offset: 0x1F2EC0 VA: 0x1801F3AC0
	|-SpanWriter.Write<ushort>
	|
	|-RVA: 0x1F3C30 Offset: 0x1F3030 VA: 0x1801F3C30
	|-SpanWriter.Write<ulong>
	*/

	// RVA: -1 Offset: -1
	public void Write<T>(Span<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F3820 Offset: 0x1F2C20 VA: 0x1801F3820
	|-SpanWriter.Write<byte>
	*/

}


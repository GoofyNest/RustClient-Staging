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
[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	// RVA: 0x18AFB10 Offset: 0x18AE110 VA: 0x1818AFB10
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
	|-RVA: 0x7D0C50 Offset: 0x7CF250 VA: 0x1807D0C50
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
	|-RVA: 0xF08970 Offset: 0xF06F70 VA: 0x180F08970
	|-SpanHelpers.CopyTo<byte>
	|
	|-RVA: 0xF08EC0 Offset: 0xF074C0 VA: 0x180F08EC0
	|-SpanHelpers.CopyTo<short>
	|
	|-RVA: 0xF09420 Offset: 0xF07A20 VA: 0x180F09420
	|-SpanHelpers.CopyTo<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	// RVA: 0x231AF20 Offset: 0x2319520 VA: 0x18231AF20
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


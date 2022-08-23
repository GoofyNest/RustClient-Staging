public struct Span<T> // TypeDefIndex: 120
{	private readonly Pinnable<T> _pinnable; // 0x0
	private readonly IntPtr _byteOffset; // 0x0
	private readonly int _length; // 0x0

	public int Length { get; }
	public T Item { get; }


	public void .ctor(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E4040 Offset: 0x1E3440 VA: 0x1801E4040
	|-Span<byte>..ctor
	|
	|-RVA: 0x1E3ED0 Offset: 0x1E32D0 VA: 0x1801E3ED0
	|-Span<object>..ctor
	*/

	public int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF3EB0 Offset: 0xF32B0 VA: 0x1800F3EB0
	|-Span<byte>.get_Length
	|-Span<object>.get_Length
	*/

	public ref T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E4060 Offset: 0x1E3460 VA: 0x1801E4060
	|-Span<byte>.get_Item
	|-Span<object>.get_Item
	*/

	[ObsoleteAttribute] // RVA: 0xE9630 Offset: 0xE8A30 VA: 0x1800E9630
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3A70 Offset: 0x1E2E70 VA: 0x1801E3A70
	|-Span<byte>.Equals
	|
	|-RVA: 0x1E3A40 Offset: 0x1E2E40 VA: 0x1801E3A40
	|-Span<object>.Equals
	*/

	[ObsoleteAttribute] // RVA: 0xE96C0 Offset: 0xE8AC0 VA: 0x1800E96C0
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3AD0 Offset: 0x1E2ED0 VA: 0x1801E3AD0
	|-Span<byte>.GetHashCode
	|
	|-RVA: 0x1E3AA0 Offset: 0x1E2EA0 VA: 0x1801E3AA0
	|-Span<object>.GetHashCode
	*/

	public static Span<T> op_Implicit(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1367910 Offset: 0x1365F10 VA: 0x181367910
	|-Span<byte>.op_Implicit
	|
	|-RVA: 0x1367BE0 Offset: 0x13661E0 VA: 0x181367BE0
	|-Span<object>.op_Implicit
	*/

}

internal static class SpanHelpers // TypeDefIndex: 122
{
[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
internal static class SpanHelpers // TypeDefIndex: 122

	public static bool IsReferenceOrContainsReferences<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF4BC0 Offset: 0xBF31C0 VA: 0x180BF4BC0
	|-SpanHelpers.IsReferenceOrContainsReferences<byte>
	|-SpanHelpers.IsReferenceOrContainsReferences<char>
	|-SpanHelpers.IsReferenceOrContainsReferences<object>
	*/

	private static bool IsReferenceOrContainsReferencesCore(Type type) { }

}

public static class SpanHelpers.PerTypeValues<T> // TypeDefIndex: 123
{	public static readonly bool IsReferenceOrContainsReferences; // 0x0
	public static readonly T[] EmptyArray; // 0x0
	public static readonly IntPtr ArrayAdjustment; // 0x0


	private static IntPtr MeasureArrayAdjustment() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1364EA0 Offset: 0x13634A0 VA: 0x181364EA0
	|-SpanHelpers.PerTypeValues<byte>.MeasureArrayAdjustment
	|-SpanHelpers.PerTypeValues<char>.MeasureArrayAdjustment
	|-SpanHelpers.PerTypeValues<object>.MeasureArrayAdjustment
	*/

	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13651B0 Offset: 0x13637B0 VA: 0x1813651B0
	|-SpanHelpers.PerTypeValues<byte>..cctor
	|
	|-RVA: 0x1364FD0 Offset: 0x13635D0 VA: 0x181364FD0
	|-SpanHelpers.PerTypeValues<char>..cctor
	|
	|-RVA: 0x1365930 Offset: 0x1363F30 VA: 0x181365930
	|-SpanHelpers.PerTypeValues<object>..cctor
	*/

}

public class SpanningTree<T> // TypeDefIndex: 4813
{	private List<SpanningTree.Node<T>> nodes; // 0x0
	private List<SpanningTree.Edge<T>> edges; // 0x0


	public int AddNode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD63AE0 Offset: 0xD620E0 VA: 0x180D63AE0
	|-SpanningTree<object>.AddNode
	*/

	public void AddEdge(int a_idx, int b_idx, int cost, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD639C0 Offset: 0xD61FC0 VA: 0x180D639C0
	|-SpanningTree<object>.AddEdge
	*/

	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD64260 Offset: 0xD62860 VA: 0x180D64260
	|-SpanningTree<object>.Clear
	*/

	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD644D0 Offset: 0xD62AD0 VA: 0x180D644D0
	|-SpanningTree<object>.Reset
	*/

	public void CalculateMin() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD63BA0 Offset: 0xD621A0 VA: 0x180D63BA0
	|-SpanningTree<object>.CalculateMin
	*/

	public void ForEach(Action<T> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD642C0 Offset: 0xD628C0 VA: 0x180D642C0
	|-SpanningTree<object>.ForEach
	*/

	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD646F0 Offset: 0xD62CF0 VA: 0x180D646F0
	|-SpanningTree<object>..ctor
	*/

}

private class SpanningTree.Node<T> // TypeDefIndex: 4814
{	public List<SpanningTree.Edge<T>> edges; // 0x0
	public bool connected; // 0x0


	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD5A530 Offset: 0xD58B30 VA: 0x180D5A530
	|-SpanningTree.Node<object>..ctor
	*/

}

private class SpanningTree.Edge<T> : IMinHeapNode<SpanningTree.Edge<T>> // TypeDefIndex: 4815
{	public SpanningTree.Node<T> source; // 0x0
	public SpanningTree.Node<T> target; // 0x0
	public T value; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <order>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private SpanningTree.Edge<T> <child>k__BackingField; // 0x0

	public int order { get; set; }
	public SpanningTree.Edge<T> child { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_order() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4BE590 Offset: 0x4BCB90 VA: 0x1804BE590
	|-SpanningTree.Edge<object>.get_order
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_order(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x79C760 Offset: 0x79AD60 VA: 0x18079C760
	|-SpanningTree.Edge<object>.set_order
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public SpanningTree.Edge<T> get_child() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	|-SpanningTree.Edge<object>.get_child
	*/

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void set_child(SpanningTree.Edge<T> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4A6010 Offset: 0x4A4610 VA: 0x1804A6010
	|-SpanningTree.Edge<object>.set_child
	*/

	public void .ctor(SpanningTree.Node<T> source, SpanningTree.Node<T> target, int order, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xD53600 Offset: 0xD51C00 VA: 0x180D53600
	|-SpanningTree.Edge<object>..ctor
	*/

}

public struct Span<T> // TypeDefIndex: 6729
{	private readonly Pinnable<T> _pinnable; // 0x0
	private readonly IntPtr _byteOffset; // 0x0
	private readonly int _length; // 0x0

	public int Length { get; }
	public T Item { get; }
	internal Pinnable<T> Pinnable { get; }
	internal IntPtr ByteOffset { get; }


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
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3A60 Offset: 0x1E2E60 VA: 0x1801E3A60
	|-Span<byte>.Equals
	|
	|-RVA: 0x1E3A50 Offset: 0x1E2E50 VA: 0x1801E3A50
	|-Span<short>.Equals
	|
	|-RVA: 0x1E3A80 Offset: 0x1E2E80 VA: 0x1801E3A80
	|-Span<object>.Equals
	*/

	[ObsoleteAttribute] // RVA: 0xC9B90 Offset: 0xC8F90 VA: 0x1800C9B90
	[EditorBrowsableAttribute] // RVA: 0xC9B90 Offset: 0xC8F90 VA: 0x1800C9B90
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3A90 Offset: 0x1E2E90 VA: 0x1801E3A90
	|-Span<byte>.GetHashCode
	|
	|-RVA: 0x1E3AB0 Offset: 0x1E2EB0 VA: 0x1801E3AB0
	|-Span<short>.GetHashCode
	|
	|-RVA: 0x1E3AC0 Offset: 0x1E2EC0 VA: 0x1801E3AC0
	|-Span<object>.GetHashCode
	*/

	public static Span<T> op_Implicit(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13678B0 Offset: 0x1365EB0 VA: 0x1813678B0
	|-Span<byte>.op_Implicit
	|
	|-RVA: 0x1367970 Offset: 0x1365F70 VA: 0x181367970
	|-Span<short>.op_Implicit
	|
	|-RVA: 0x1367C40 Offset: 0x1366240 VA: 0x181367C40
	|-Span<object>.op_Implicit
	*/

	public static Span<T> op_Implicit(ArraySegment<T> segment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1367B30 Offset: 0x1366130 VA: 0x181367B30
	|-Span<byte>.op_Implicit
	|
	|-RVA: 0x13679D0 Offset: 0x1365FD0 VA: 0x1813679D0
	|-Span<short>.op_Implicit
	|
	|-RVA: 0x1367A80 Offset: 0x1366080 VA: 0x181367A80
	|-Span<object>.op_Implicit
	*/

	public void .ctor(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3DA0 Offset: 0x1E31A0 VA: 0x1801E3DA0
	|-Span<byte>..ctor
	|
	|-RVA: 0x1E3EF0 Offset: 0x1E32F0 VA: 0x1801E3EF0
	|-Span<short>..ctor
	|
	|-RVA: 0x1E3C40 Offset: 0x1E3040 VA: 0x1801E3C40
	|-Span<object>..ctor
	*/

	public void .ctor(T[] array, int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3EE0 Offset: 0x1E32E0 VA: 0x1801E3EE0
	|-Span<byte>..ctor
	|
	|-RVA: 0x1E4030 Offset: 0x1E3430 VA: 0x1801E4030
	|-Span<short>..ctor
	|
	|-RVA: 0x1E4020 Offset: 0x1E3420 VA: 0x1801E4020
	|-Span<object>..ctor
	*/

	[CLSCompliantAttribute] // RVA: 0x6F430 Offset: 0x6E830 VA: 0x18006F430
	public void .ctor(void* pointer, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3DB0 Offset: 0x1E31B0 VA: 0x1801E3DB0
	|-Span<byte>..ctor
	|
	|-RVA: 0x1E3F00 Offset: 0x1E3300 VA: 0x1801E3F00
	|-Span<short>..ctor
	|
	|-RVA: 0x1E3C80 Offset: 0x1E3080 VA: 0x1801E3C80
	|-Span<object>..ctor
	*/

	internal void .ctor(Pinnable<T> pinnable, IntPtr byteOffset, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3C50 Offset: 0x1E3050 VA: 0x1801E3C50
	|-Span<byte>..ctor
	|-Span<short>..ctor
	|-Span<object>..ctor
	*/

	public ref T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E4050 Offset: 0x1E3450 VA: 0x1801E4050
	|-Span<byte>.get_Item
	|-Span<short>.get_Item
	|-Span<object>.get_Item
	*/

	public void CopyTo(Span<T> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E39C0 Offset: 0x1E2DC0 VA: 0x1801E39C0
	|-Span<byte>.CopyTo
	|-Span<short>.CopyTo
	|-Span<object>.CopyTo
	*/

	public bool TryCopyTo(Span<T> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3C10 Offset: 0x1E3010 VA: 0x1801E3C10
	|-Span<byte>.TryCopyTo
	|-Span<short>.TryCopyTo
	|-Span<object>.TryCopyTo
	*/

	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3BE0 Offset: 0x1E2FE0 VA: 0x1801E3BE0
	|-Span<byte>.ToString
	|
	|-RVA: 0x1E3BF0 Offset: 0x1E2FF0 VA: 0x1801E3BF0
	|-Span<short>.ToString
	|
	|-RVA: 0x1E3C00 Offset: 0x1E3000 VA: 0x1801E3C00
	|-Span<object>.ToString
	*/

	public Span<T> Slice(int start, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3AE0 Offset: 0x1E2EE0 VA: 0x1801E3AE0
	|-Span<byte>.Slice
	|-Span<short>.Slice
	|-Span<object>.Slice
	*/

	[EditorBrowsableAttribute] // RVA: 0x7D7C0 Offset: 0x7CBC0 VA: 0x18007D7C0
	internal ref T DangerousGetPinnableReference() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1E3A30 Offset: 0x1E2E30 VA: 0x1801E3A30
	|-Span<byte>.DangerousGetPinnableReference
	|-Span<short>.DangerousGetPinnableReference
	|-Span<object>.DangerousGetPinnableReference
	*/

	internal Pinnable<T> get_Pinnable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	|-Span<byte>.get_Pinnable
	|-Span<short>.get_Pinnable
	|-Span<object>.get_Pinnable
	*/

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
[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
internal static class SpanHelpers // TypeDefIndex: 6731

	public static void CopyTo<T>(ref T dst, int dstLength, ref T src, int srcLength) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF09710 Offset: 0xF07D10 VA: 0x180F09710
	|-SpanHelpers.CopyTo<byte>
	|
	|-RVA: 0xF09C60 Offset: 0xF08260 VA: 0x180F09C60
	|-SpanHelpers.CopyTo<short>
	|
	|-RVA: 0xF0A1C0 Offset: 0xF087C0 VA: 0x180F0A1C0
	|-SpanHelpers.CopyTo<object>
	*/

	[ExtensionAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public static IntPtr Add<T>(IntPtr start, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xED9160 Offset: 0xED7760 VA: 0x180ED9160
	|-SpanHelpers.Add<byte>
	|-SpanHelpers.Add<short>
	|-SpanHelpers.Add<object>
	*/

	public static bool IsReferenceOrContainsReferences<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBF4BC0 Offset: 0xBF31C0 VA: 0x180BF4BC0
	|-SpanHelpers.IsReferenceOrContainsReferences<byte>
	|-SpanHelpers.IsReferenceOrContainsReferences<short>
	|-SpanHelpers.IsReferenceOrContainsReferences<object>
	*/

	private static bool IsReferenceOrContainsReferencesCore(Type type) { }

}

public static class SpanHelpers.PerTypeValues<T> // TypeDefIndex: 6732
{	public static readonly bool IsReferenceOrContainsReferences; // 0x0
	public static readonly T[] EmptyArray; // 0x0
	public static readonly IntPtr ArrayAdjustment; // 0x0


	private static IntPtr MeasureArrayAdjustment() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1364EA0 Offset: 0x13634A0 VA: 0x181364EA0
	|-SpanHelpers.PerTypeValues<byte>.MeasureArrayAdjustment
	|-SpanHelpers.PerTypeValues<short>.MeasureArrayAdjustment
	|-SpanHelpers.PerTypeValues<object>.MeasureArrayAdjustment
	*/

	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1365570 Offset: 0x1363B70 VA: 0x181365570
	|-SpanHelpers.PerTypeValues<byte>..cctor
	|
	|-RVA: 0x1365390 Offset: 0x1363990 VA: 0x181365390
	|-SpanHelpers.PerTypeValues<short>..cctor
	|
	|-RVA: 0x1365750 Offset: 0x1363D50 VA: 0x181365750
	|-SpanHelpers.PerTypeValues<object>..cctor
	*/

}

internal struct SpanWriter // TypeDefIndex: 6924
{	private readonly Span<byte> _data; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int <Length>k__BackingField; // 0x18

	public int Length { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_Length() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_Length(int value) { }

	public void .ctor(Span<byte> data) { }

	public void Write<T>(T value, bool reverse = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F3CF0 Offset: 0x1F30F0 VA: 0x1801F3CF0
	|-SpanWriter.Write<byte>
	|
	|-RVA: 0x1F3E60 Offset: 0x1F3260 VA: 0x1801F3E60
	|-SpanWriter.Write<ushort>
	|
	|-RVA: 0x1F3FD0 Offset: 0x1F33D0 VA: 0x1801F3FD0
	|-SpanWriter.Write<ulong>
	*/

	public void Write<T>(Span<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1F3BC0 Offset: 0x1F2FC0 VA: 0x1801F3BC0
	|-SpanWriter.Write<byte>
	*/

}


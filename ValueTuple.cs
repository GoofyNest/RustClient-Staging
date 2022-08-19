public struct ValueTuple : IEquatable<ValueTuple>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple> // TypeDefIndex: 125
{	// Methods

	// RVA: 0x234480 Offset: 0x233880 VA: 0x180234480 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x21B060 Offset: 0x21A460 VA: 0x18021B060 Slot: 4
	public bool Equals(ValueTuple other) { }

	// RVA: 0x2345C0 Offset: 0x2339C0 VA: 0x1802345C0 Slot: 5
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }

	// RVA: 0x234610 Offset: 0x233A10 VA: 0x180234610 Slot: 8
	private int System.IComparable.CompareTo(object other) { }

	// RVA: 0x117E00 Offset: 0x117200 VA: 0x180117E00 Slot: 9
	public int CompareTo(ValueTuple other) { }

	// RVA: 0x2344D0 Offset: 0x2338D0 VA: 0x1802344D0 Slot: 7
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	// RVA: 0x117E00 Offset: 0x117200 VA: 0x180117E00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x117E00 Offset: 0x117200 VA: 0x180117E00 Slot: 6
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }

	// RVA: 0x234700 Offset: 0x233B00 VA: 0x180234700 Slot: 3
	public override string ToString() { }

	// RVA: 0x21475B0 Offset: 0x2145BB0 VA: 0x1821475B0
	internal static int CombineHashCodes(int h1, int h2) { }

	// RVA: 0x2147630 Offset: 0x2145C30 VA: 0x182147630
	internal static int CombineHashCodes(int h1, int h2, int h3) { }

}


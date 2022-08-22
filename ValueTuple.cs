public struct ValueTuple : IEquatable<ValueTuple>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple> // TypeDefIndex: 125
{	// Methods

	// RVA: 0x234400 Offset: 0x233800 VA: 0x180234400 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x222C40 Offset: 0x222040 VA: 0x180222C40 Slot: 4
	public bool Equals(ValueTuple other) { }

	// RVA: 0x234540 Offset: 0x233940 VA: 0x180234540 Slot: 5
	private bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }

	// RVA: 0x234590 Offset: 0x233990 VA: 0x180234590 Slot: 8
	private int System.IComparable.CompareTo(object other) { }

	// RVA: 0x117D80 Offset: 0x117180 VA: 0x180117D80 Slot: 9
	public int CompareTo(ValueTuple other) { }

	// RVA: 0x234450 Offset: 0x233850 VA: 0x180234450 Slot: 7
	private int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	// RVA: 0x117D80 Offset: 0x117180 VA: 0x180117D80 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x117D80 Offset: 0x117180 VA: 0x180117D80 Slot: 6
	private int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }

	// RVA: 0x234680 Offset: 0x233A80 VA: 0x180234680 Slot: 3
	public override string ToString() { }

	// RVA: 0x2147ED0 Offset: 0x21464D0 VA: 0x182147ED0
	internal static int CombineHashCodes(int h1, int h2) { }

	// RVA: 0x2147F50 Offset: 0x2146550 VA: 0x182147F50
	internal static int CombineHashCodes(int h1, int h2, int h3) { }

}


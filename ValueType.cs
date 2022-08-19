public abstract class ValueType // TypeDefIndex: 417
{	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x2147990 Offset: 0x2145F90 VA: 0x182147990
	private static bool InternalEquals(object o1, object o2, out object[] fields) { }

	// RVA: 0x2147700 Offset: 0x2145D00 VA: 0x182147700
	internal static bool DefaultEquals(object o1, object o2) { }

	// RVA: 0x10D53B0 Offset: 0x10D39B0 VA: 0x1810D53B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x21479A0 Offset: 0x2145FA0 VA: 0x1821479A0
	internal static int InternalGetHashCode(object o, out object[] fields) { }

	// RVA: 0x2147900 Offset: 0x2145F00 VA: 0x182147900 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21479B0 Offset: 0x2145FB0 VA: 0x1821479B0 Slot: 3
	public override string ToString() { }

}

internal enum ValueType // TypeDefIndex: 4249
{	// Fields
	public int value__; // 0x0
	public const ValueType Unknown = -1;
	public const ValueType Null = 0;
	public const ValueType Bool = 1;
	public const ValueType Numeric = 2;
	public const ValueType Str = 3;
	public const ValueType Float = 4;
	public const ValueType Decimal = 5;
	public const ValueType Object = 6;
	public const ValueType Date = 7;

}

public enum ValueType // TypeDefIndex: 8138
{	// Fields
	public int value__; // 0x0
	public const ValueType String = 0;
	public const ValueType Number = 1;
	public const ValueType Object = 2;
	public const ValueType Array = 3;
	public const ValueType Boolean = 4;
	public const ValueType Null = 5;

}


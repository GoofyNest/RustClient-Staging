public abstract class ValueType // TypeDefIndex: 417
{	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x21477D0 Offset: 0x2145DD0 VA: 0x1821477D0
	private static bool InternalEquals(object o1, object o2, out object[] fields) { }

	// RVA: 0x2147540 Offset: 0x2145B40 VA: 0x182147540
	internal static bool DefaultEquals(object o1, object o2) { }

	// RVA: 0x10D53B0 Offset: 0x10D39B0 VA: 0x1810D53B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x21477E0 Offset: 0x2145DE0 VA: 0x1821477E0
	internal static int InternalGetHashCode(object o, out object[] fields) { }

	// RVA: 0x2147740 Offset: 0x2145D40 VA: 0x182147740 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21477F0 Offset: 0x2145DF0 VA: 0x1821477F0 Slot: 3
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


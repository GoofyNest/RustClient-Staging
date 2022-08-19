public abstract class StringComparer : IComparer, IEqualityComparer, IComparer<string>, IEqualityComparer<string> // TypeDefIndex: 303
{	// Fields
	private static readonly StringComparer _invariantCulture; // 0x0
	private static readonly StringComparer _invariantCultureIgnoreCase; // 0x8
	private static readonly StringComparer _ordinal; // 0x10
	private static readonly StringComparer _ordinalIgnoreCase; // 0x18

	// Properties
	public static StringComparer InvariantCultureIgnoreCase { get; }
	public static StringComparer CurrentCultureIgnoreCase { get; }
	public static StringComparer Ordinal { get; }
	public static StringComparer OrdinalIgnoreCase { get; }

	// Methods

	// RVA: 0x18B0590 Offset: 0x18AEB90 VA: 0x1818B0590
	public static StringComparer get_InvariantCultureIgnoreCase() { }

	// RVA: 0x18B0510 Offset: 0x18AEB10 VA: 0x1818B0510
	public static StringComparer get_CurrentCultureIgnoreCase() { }

	// RVA: 0x18B0650 Offset: 0x18AEC50 VA: 0x1818B0650
	public static StringComparer get_Ordinal() { }

	// RVA: 0x18B05F0 Offset: 0x18AEBF0 VA: 0x1818B05F0
	public static StringComparer get_OrdinalIgnoreCase() { }

	// RVA: 0x18B0190 Offset: 0x18AE790 VA: 0x1818B0190
	public static StringComparer Create(CultureInfo culture, bool ignoreCase) { }

	// RVA: 0x18AFFD0 Offset: 0x18AE5D0 VA: 0x1818AFFD0 Slot: 4
	public int Compare(object x, object y) { }

	// RVA: 0x18B0230 Offset: 0x18AE830 VA: 0x1818B0230 Slot: 5
	public bool Equals(object x, object y) { }

	// RVA: 0x18B0310 Offset: 0x18AE910 VA: 0x1818B0310 Slot: 6
	public int GetHashCode(object obj) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int Compare(string x, string y);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool Equals(string x, string y);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int GetHashCode(string obj);

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x18B03C0 Offset: 0x18AE9C0 VA: 0x1818B03C0
	private static void .cctor() { }

}


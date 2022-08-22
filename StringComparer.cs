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

	// RVA: 0x18B0550 Offset: 0x18AEB50 VA: 0x1818B0550
	public static StringComparer get_InvariantCultureIgnoreCase() { }

	// RVA: 0x18B04D0 Offset: 0x18AEAD0 VA: 0x1818B04D0
	public static StringComparer get_CurrentCultureIgnoreCase() { }

	// RVA: 0x18B0610 Offset: 0x18AEC10 VA: 0x1818B0610
	public static StringComparer get_Ordinal() { }

	// RVA: 0x18B05B0 Offset: 0x18AEBB0 VA: 0x1818B05B0
	public static StringComparer get_OrdinalIgnoreCase() { }

	// RVA: 0x18B0150 Offset: 0x18AE750 VA: 0x1818B0150
	public static StringComparer Create(CultureInfo culture, bool ignoreCase) { }

	// RVA: 0x18AFF90 Offset: 0x18AE590 VA: 0x1818AFF90 Slot: 4
	public int Compare(object x, object y) { }

	// RVA: 0x18B01F0 Offset: 0x18AE7F0 VA: 0x1818B01F0 Slot: 5
	public bool Equals(object x, object y) { }

	// RVA: 0x18B02D0 Offset: 0x18AE8D0 VA: 0x1818B02D0 Slot: 6
	public int GetHashCode(object obj) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int Compare(string x, string y);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool Equals(string x, string y);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int GetHashCode(string obj);

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x18B0380 Offset: 0x18AE980 VA: 0x1818B0380
	private static void .cctor() { }

}


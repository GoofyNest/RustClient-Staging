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

	// RVA: 0x18AFF30 Offset: 0x18AE530 VA: 0x1818AFF30
	public static StringComparer get_InvariantCultureIgnoreCase() { }

	// RVA: 0x18AFEB0 Offset: 0x18AE4B0 VA: 0x1818AFEB0
	public static StringComparer get_CurrentCultureIgnoreCase() { }

	// RVA: 0x18AFFF0 Offset: 0x18AE5F0 VA: 0x1818AFFF0
	public static StringComparer get_Ordinal() { }

	// RVA: 0x18AFF90 Offset: 0x18AE590 VA: 0x1818AFF90
	public static StringComparer get_OrdinalIgnoreCase() { }

	// RVA: 0x18AFB30 Offset: 0x18AE130 VA: 0x1818AFB30
	public static StringComparer Create(CultureInfo culture, bool ignoreCase) { }

	// RVA: 0x18AF970 Offset: 0x18ADF70 VA: 0x1818AF970 Slot: 4
	public int Compare(object x, object y) { }

	// RVA: 0x18AFBD0 Offset: 0x18AE1D0 VA: 0x1818AFBD0 Slot: 5
	public bool Equals(object x, object y) { }

	// RVA: 0x18AFCB0 Offset: 0x18AE2B0 VA: 0x1818AFCB0 Slot: 6
	public int GetHashCode(object obj) { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int Compare(string x, string y);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool Equals(string x, string y);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int GetHashCode(string obj);

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x18AFD60 Offset: 0x18AE360 VA: 0x1818AFD60
	private static void .cctor() { }

}


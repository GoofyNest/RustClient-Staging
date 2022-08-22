internal class CompatibleComparer : IEqualityComparer // TypeDefIndex: 1386
{	// Fields
	private IComparer _comparer; // 0x10
	private IHashCodeProvider _hcp; // 0x18

	// Properties
	internal IComparer Comparer { get; }
	internal IHashCodeProvider HashCodeProvider { get; }

	// Methods

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	internal void .ctor(IComparer comparer, IHashCodeProvider hashCodeProvider) { }

	// RVA: 0x1452D20 Offset: 0x1451320 VA: 0x181452D20
	public int Compare(object a, object b) { }

	// RVA: 0x1452EC0 Offset: 0x14514C0 VA: 0x181452EC0 Slot: 4
	public bool Equals(object a, object b) { }

	// RVA: 0x1453020 Offset: 0x1451620 VA: 0x181453020 Slot: 5
	public int GetHashCode(object obj) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal IComparer get_Comparer() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal IHashCodeProvider get_HashCodeProvider() { }

}

internal class CompatibleComparer : IEqualityComparer // TypeDefIndex: 3105
{	// Fields
	private IComparer _comparer; // 0x10
	private static IComparer defaultComparer; // 0x0
	private IHashCodeProvider _hcp; // 0x18
	private static IHashCodeProvider defaultHashProvider; // 0x8

	// Properties
	public IComparer Comparer { get; }
	public IHashCodeProvider HashCodeProvider { get; }
	public static IComparer DefaultComparer { get; }
	public static IHashCodeProvider DefaultHashCodeProvider { get; }

	// Methods

	// RVA: 0x522CB0 Offset: 0x5212B0 VA: 0x180522CB0
	internal void .ctor(IComparer comparer, IHashCodeProvider hashCodeProvider) { }

	// RVA: 0x15BF4D0 Offset: 0x15BDAD0 VA: 0x1815BF4D0 Slot: 4
	public bool Equals(object a, object b) { }

	// RVA: 0x15BF5E0 Offset: 0x15BDBE0 VA: 0x1815BF5E0 Slot: 5
	public int GetHashCode(object obj) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public IComparer get_Comparer() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public IHashCodeProvider get_HashCodeProvider() { }

	// RVA: 0x15BF690 Offset: 0x15BDC90 VA: 0x1815BF690
	public static IComparer get_DefaultComparer() { }

	// RVA: 0x15BF760 Offset: 0x15BDD60 VA: 0x1815BF760
	public static IHashCodeProvider get_DefaultHashCodeProvider() { }

}


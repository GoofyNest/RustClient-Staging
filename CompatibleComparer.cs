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

	// RVA: 0x1452A60 Offset: 0x1451060 VA: 0x181452A60
	public int Compare(object a, object b) { }

	// RVA: 0x1452C00 Offset: 0x1451200 VA: 0x181452C00 Slot: 4
	public bool Equals(object a, object b) { }

	// RVA: 0x1452D60 Offset: 0x1451360 VA: 0x181452D60 Slot: 5
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

	// RVA: 0x15BF210 Offset: 0x15BD810 VA: 0x1815BF210 Slot: 4
	public bool Equals(object a, object b) { }

	// RVA: 0x15BF320 Offset: 0x15BD920 VA: 0x1815BF320 Slot: 5
	public int GetHashCode(object obj) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public IComparer get_Comparer() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public IHashCodeProvider get_HashCodeProvider() { }

	// RVA: 0x15BF3D0 Offset: 0x15BD9D0 VA: 0x1815BF3D0
	public static IComparer get_DefaultComparer() { }

	// RVA: 0x15BF4A0 Offset: 0x15BDAA0 VA: 0x1815BF4A0
	public static IHashCodeProvider get_DefaultHashCodeProvider() { }

}


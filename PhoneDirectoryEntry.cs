public class PhoneDirectoryEntry : MonoBehaviour // TypeDefIndex: 10899
{	// Fields
	public RustText PhoneNumber; // 0x18
	public RustText PhoneName; // 0x20
	public GameObject DeleteIcon; // 0x28
	public GameObject CensorIcon; // 0x30
	private PhoneDialler diallerDialog; // 0x38
	private string rawNumberString; // 0x40
	private string cachedName; // 0x48
	private int cachedNumber; // 0x50
	private PhoneDirectoryEntry.NumberType assignedType; // 0x54

	// Methods

	// RVA: 0x907390 Offset: 0x905990 VA: 0x180907390
	public void Populate(PhoneDirectory.DirectoryEntry entry, PhoneDialler forDialog, PhoneDirectoryEntry.NumberType type) { }

	// RVA: 0x907490 Offset: 0x905A90 VA: 0x180907490
	private void SetPhoneName(string phoneName, int number, PhoneDirectoryEntry.NumberType type) { }

	// RVA: 0x907360 Offset: 0x905960 VA: 0x180907360
	public void OnClickedDial() { }

	// RVA: 0x9072A0 Offset: 0x9058A0 VA: 0x1809072A0
	public void OnClickedDelete() { }

	// RVA: 0x907570 Offset: 0x905B70 VA: 0x180907570
	public void .ctor() { }

}

public enum PhoneDirectoryEntry.NumberType // TypeDefIndex: 10900
{	// Fields
	public int value__; // 0x0
	public const PhoneDirectoryEntry.NumberType Directory = 0;
	public const PhoneDirectoryEntry.NumberType Contact = 1;

}


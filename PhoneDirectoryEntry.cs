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

	// RVA: 0x906D70 Offset: 0x905370 VA: 0x180906D70
	public void Populate(PhoneDirectory.DirectoryEntry entry, PhoneDialler forDialog, PhoneDirectoryEntry.NumberType type) { }

	// RVA: 0x906E70 Offset: 0x905470 VA: 0x180906E70
	private void SetPhoneName(string phoneName, int number, PhoneDirectoryEntry.NumberType type) { }

	// RVA: 0x906D40 Offset: 0x905340 VA: 0x180906D40
	public void OnClickedDial() { }

	// RVA: 0x906C80 Offset: 0x905280 VA: 0x180906C80
	public void OnClickedDelete() { }

	// RVA: 0x906F50 Offset: 0x905550 VA: 0x180906F50
	public void .ctor() { }

}

public enum PhoneDirectoryEntry.NumberType // TypeDefIndex: 10900
{	// Fields
	public int value__; // 0x0
	public const PhoneDirectoryEntry.NumberType Directory = 0;
	public const PhoneDirectoryEntry.NumberType Contact = 1;

}


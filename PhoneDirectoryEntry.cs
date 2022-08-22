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

	// RVA: 0x906E80 Offset: 0x905480 VA: 0x180906E80
	public void Populate(PhoneDirectory.DirectoryEntry entry, PhoneDialler forDialog, PhoneDirectoryEntry.NumberType type) { }

	// RVA: 0x906F80 Offset: 0x905580 VA: 0x180906F80
	private void SetPhoneName(string phoneName, int number, PhoneDirectoryEntry.NumberType type) { }

	// RVA: 0x906E50 Offset: 0x905450 VA: 0x180906E50
	public void OnClickedDial() { }

	// RVA: 0x906D90 Offset: 0x905390 VA: 0x180906D90
	public void OnClickedDelete() { }

	// RVA: 0x907060 Offset: 0x905660 VA: 0x180907060
	public void .ctor() { }

}

public enum PhoneDirectoryEntry.NumberType // TypeDefIndex: 10900
{	// Fields
	public int value__; // 0x0
	public const PhoneDirectoryEntry.NumberType Directory = 0;
	public const PhoneDirectoryEntry.NumberType Contact = 1;

}


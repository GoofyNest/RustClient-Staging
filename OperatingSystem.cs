public sealed class OperatingSystem : ICloneable, ISerializable // TypeDefIndex: 384
{	// Fields
	private PlatformID _platform; // 0x10
	private Version _version; // 0x18
	private string _servicePack; // 0x20

	// Properties
	public PlatformID Platform { get; }
	public Version Version { get; }
	public string ServicePack { get; }

	// Methods

	// RVA: 0x1683E80 Offset: 0x1682480 VA: 0x181683E80
	public void .ctor(PlatformID platform, Version version) { }

	// RVA: 0x1683FC0 Offset: 0x16825C0 VA: 0x181683FC0
	private void .ctor(SerializationInfo information, StreamingContext context) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public PlatformID get_Platform() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public Version get_Version() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public string get_ServicePack() { }

	// RVA: 0x1683B20 Offset: 0x1682120 VA: 0x181683B20 Slot: 4
	public object Clone() { }

	// RVA: 0x1683C90 Offset: 0x1682290 VA: 0x181683C90 Slot: 5
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1683D30 Offset: 0x1682330 VA: 0x181683D30 Slot: 3
	public override string ToString() { }

}


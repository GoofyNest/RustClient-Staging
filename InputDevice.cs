public struct InputDevice : IEquatable<InputDevice> // TypeDefIndex: 4145
{	// Fields
	private ulong m_DeviceId; // 0x0
	private bool m_Initialized; // 0x8

	// Properties
	private ulong deviceId { get; }

	// Methods

	// RVA: 0x23E6F0 Offset: 0x23DAF0 VA: 0x18023E6F0
	internal void .ctor(ulong deviceId) { }

	// RVA: 0x23E700 Offset: 0x23DB00 VA: 0x18023E700
	private ulong get_deviceId() { }

	// RVA: 0x23E5D0 Offset: 0x23D9D0 VA: 0x18023E5D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x23E680 Offset: 0x23DA80 VA: 0x18023E680 Slot: 4
	public bool Equals(InputDevice other) { }

	// RVA: 0x23E6C0 Offset: 0x23DAC0 VA: 0x18023E6C0 Slot: 2
	public override int GetHashCode() { }

}


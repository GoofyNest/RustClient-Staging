public struct InputDevice : IEquatable<InputDevice> // TypeDefIndex: 4145
{	// Fields
	private ulong m_DeviceId; // 0x0
	private bool m_Initialized; // 0x8

	// Properties
	private ulong deviceId { get; }

	// Methods

	// RVA: 0x23E670 Offset: 0x23DA70 VA: 0x18023E670
	internal void .ctor(ulong deviceId) { }

	// RVA: 0x23E680 Offset: 0x23DA80 VA: 0x18023E680
	private ulong get_deviceId() { }

	// RVA: 0x23E550 Offset: 0x23D950 VA: 0x18023E550 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x23E600 Offset: 0x23DA00 VA: 0x18023E600 Slot: 4
	public bool Equals(InputDevice other) { }

	// RVA: 0x23E640 Offset: 0x23DA40 VA: 0x18023E640 Slot: 2
	public override int GetHashCode() { }

}


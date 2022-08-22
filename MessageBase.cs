public abstract class MessageBase // TypeDefIndex: 1727
{	// Fields
	private static byte[] header; // 0x0
	private int _type; // 0x10
	private NtlmFlags _flags; // 0x14

	// Properties
	public NtlmFlags Flags { get; set; }
	public int Type { get; }

	// Methods

	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	protected void .ctor(int messageType) { }

	// RVA: 0x57C9D0 Offset: 0x57AFD0 VA: 0x18057C9D0
	public NtlmFlags get_Flags() { }

	// RVA: 0x57C9F0 Offset: 0x57AFF0 VA: 0x18057C9F0
	public void set_Flags(NtlmFlags value) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public int get_Type() { }

	// RVA: 0x1AB85C0 Offset: 0x1AB6BC0 VA: 0x181AB85C0
	protected byte[] PrepareMessage(int messageSize) { }

	// RVA: 0x1AB8340 Offset: 0x1AB6940 VA: 0x181AB8340 Slot: 4
	protected virtual void Decode(byte[] message) { }

	// RVA: 0x1AB8200 Offset: 0x1AB6800 VA: 0x181AB8200
	protected bool CheckHeader(byte[] message) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract byte[] GetBytes();

	// RVA: 0x1AB86E0 Offset: 0x1AB6CE0 VA: 0x181AB86E0
	private static void .cctor() { }

}


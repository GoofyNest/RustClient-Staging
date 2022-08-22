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

	// RVA: 0x57C960 Offset: 0x57AF60 VA: 0x18057C960
	public NtlmFlags get_Flags() { }

	// RVA: 0x57C980 Offset: 0x57AF80 VA: 0x18057C980
	public void set_Flags(NtlmFlags value) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00
	public int get_Type() { }

	// RVA: 0x1AB8DB0 Offset: 0x1AB73B0 VA: 0x181AB8DB0
	protected byte[] PrepareMessage(int messageSize) { }

	// RVA: 0x1AB8B30 Offset: 0x1AB7130 VA: 0x181AB8B30 Slot: 4
	protected virtual void Decode(byte[] message) { }

	// RVA: 0x1AB89F0 Offset: 0x1AB6FF0 VA: 0x181AB89F0
	protected bool CheckHeader(byte[] message) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract byte[] GetBytes();

	// RVA: 0x1AB8ED0 Offset: 0x1AB74D0 VA: 0x181AB8ED0
	private static void .cctor() { }

}


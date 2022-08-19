public class Message // TypeDefIndex: 6693
{	// Fields
	public Message.Type type; // 0x10
	public BaseNetwork peer; // 0x18
	public Connection connection; // 0x20

	// Properties
	public NetRead read { get; }
	public NetWrite write { get; }

	// Methods

	// RVA: 0xE570D0 Offset: 0xE556D0 VA: 0x180E570D0
	public NetRead get_read() { }

	// RVA: 0x855180 Offset: 0x853780 VA: 0x180855180
	public NetWrite get_write() { }

	// RVA: 0x220FC20 Offset: 0x220E220 VA: 0x18220FC20 Slot: 4
	public virtual void Clear() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public enum Message.Type // TypeDefIndex: 6694
{	// Fields
	public byte value__; // 0x0
	public const Message.Type Welcome = 1;
	public const Message.Type Auth = 2;
	public const Message.Type Approved = 3;
	public const Message.Type Ready = 4;
	public const Message.Type Entities = 5;
	public const Message.Type EntityDestroy = 6;
	public const Message.Type GroupChange = 7;
	public const Message.Type GroupDestroy = 8;
	public const Message.Type RPCMessage = 9;
	public const Message.Type EntityPosition = 10;
	public const Message.Type ConsoleMessage = 11;
	public const Message.Type ConsoleCommand = 12;
	public const Message.Type Effect = 13;
	public const Message.Type DisconnectReason = 14;
	public const Message.Type Tick = 15;
	public const Message.Type Message = 16;
	public const Message.Type RequestUserInformation = 17;
	public const Message.Type GiveUserInformation = 18;
	public const Message.Type GroupEnter = 19;
	public const Message.Type GroupLeave = 20;
	public const Message.Type VoiceData = 21;
	public const Message.Type EAC = 22;
	public const Message.Type EntityFlags = 23;
	public const Message.Type World = 24;
	public const Message.Type ConsoleReplicatedVars = 25;
	public const Message.Type Last = 25;

}


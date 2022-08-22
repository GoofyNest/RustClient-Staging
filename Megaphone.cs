public class Megaphone : HeldEntity // TypeDefIndex: 8604
{	// Fields
	[HeaderAttribute] // RVA: 0xB04C0 Offset: 0xAF8C0 VA: 0x1800B04C0
	public VoiceProcessor voiceProcessor; // 0x1F8
	public float VoiceDamageMinFrequency; // 0x200
	public float VoiceDamageAmount; // 0x204
	public AudioSource VoiceSource; // 0x208
	public SoundDefinition StartBroadcastingSfx; // 0x210
	public SoundDefinition StopBroadcastingSfx; // 0x218
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static float <MegaphoneVoiceRange>k__BackingField; // 0x0
	[ClientVar] // RVA: 0x81380 Offset: 0x80780 VA: 0x180081380
	public static bool IgnorePushToTalk; // 0x4
	private static int BroadcastBoolAnim; // 0x8
	private float talkingLayerWeight; // 0x220

	// Properties
	[ReplicatedVar] // RVA: 0xB07E0 Offset: 0xAFBE0 VA: 0x1800B07E0
	public static float MegaphoneVoiceRange { get; set; }

	// Methods

	// RVA: 0x95D740 Offset: 0x95BD40 VA: 0x18095D740 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x95DA60 Offset: 0x95C060 VA: 0x18095DA60
	public static float get_MegaphoneVoiceRange() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x95DB20 Offset: 0x95C120 VA: 0x18095DB20
	public static void set_MegaphoneVoiceRange(float value) { }

	// RVA: 0x95D830 Offset: 0x95BE30 VA: 0x18095D830
	public bool Receive(byte[] data) { }

	// RVA: 0x95D310 Offset: 0x95B910 VA: 0x18095D310 Slot: 138
	public override void OnInput() { }

	// RVA: 0x95D940 Offset: 0x95BF40 VA: 0x18095D940
	private void Update() { }

	// RVA: 0x95D130 Offset: 0x95B730 VA: 0x18095D130 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x95D9F0 Offset: 0x95BFF0 VA: 0x18095D9F0
	public void .ctor() { }

	// RVA: 0x95D980 Offset: 0x95BF80 VA: 0x18095D980
	private static void .cctor() { }

}

